using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAKOPointOfSale.Transactions
{
    public class PrintVoidReceipt
    {
        public static void GenerateVoidReceiptFromTransactionId(int transactionId)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                // Header fields
                string voidNumber = "";
                decimal vatAmount = 0m, vatableSales = 0m, vatExempt = 0m, subTotal = 0m, grandTotal = 0m;
                string paymentMethod = "";
                decimal cashReceived = 0m, cashChange = 0m;
                string status = "";
                string invoiceNumber = "";

                var items = new List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)>();

                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // ✅ 1) Get void number from VoidTransactions
                    using (var cmd = new SqlCommand(@"
                        SELECT TOP 1 void_number
                        FROM VoidTransactions
                        WHERE transaction_id = @transactionId", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            voidNumber = result.ToString();
                        else
                            voidNumber = "N/A";
                    }

                    // 2) Read transaction header
                    using (var cmd = new SqlCommand(@"
                        SELECT id, invoice_number, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total,
                               payment_method, cash_received, cash_change, status
                        FROM Transactions
                        WHERE id = @transactionId AND transaction_type = 'void'", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                invoiceNumber = r["invoice_number"].ToString();
                                vatAmount = Convert.ToDecimal(r["vat_amount"]);
                                vatableSales = Convert.ToDecimal(r["vatable_sales"]);
                                vatExempt = Convert.ToDecimal(r["vat_exempt"]);
                                subTotal = Convert.ToDecimal(r["sub_total"]);
                                grandTotal = Convert.ToDecimal(r["grand_total"]);
                                paymentMethod = r["payment_method"].ToString();
                                cashReceived = Convert.ToDecimal(r["cash_received"]);
                                cashChange = Convert.ToDecimal(r["cash_change"]);
                                status = r["status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show($"No void transaction found for Transaction ID: {transactionId}",
                                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // 3) Read items
                    using (var cmd = new SqlCommand(@"
                        SELECT p.product_name, p.product_code, si.quantity, si.unit_price, si.total_amount, 
                               si.discount, si.discount_type, si.unit_of_measurement
                        FROM SalesInvoiceItems si
                        INNER JOIN Products p ON si.product_id = p.id
                        WHERE si.transaction_id = @transactionId
                        ORDER BY si.id", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                items.Add((
                                    r["product_name"].ToString(),
                                    r["product_code"].ToString(),
                                    Convert.ToDecimal(r["quantity"]),
                                    Convert.ToDecimal(r["unit_price"]),
                                    Convert.ToDecimal(r["total_amount"]),
                                    Convert.ToDecimal(r["discount"]),
                                    r["discount_type"].ToString(),
                                    r["unit_of_measurement"].ToString()
                                ));
                            }
                        }
                    }
                }

                // ✅ Pass voidNumber to the PDF
                SaveAsPdf(invoiceNumber, voidNumber, items, vatAmount, vatableSales, vatExempt, subTotal, grandTotal,
                    paymentMethod, cashReceived, cashChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating void receipt: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ⬇ Updated SaveAsPdf() to include voidNumber parameter
        private static void SaveAsPdf(
            string invoiceNumber,
            string voidNumber,
            List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)> items,
            decimal vatAmount, decimal vatableSales, decimal vatExempt,
            decimal subTotal, decimal grandTotal,
            string paymentMethod, decimal cashReceived, decimal cashChange)
        {
            try
            {
                string appPath = Application.StartupPath;
                string pdfPath = Path.Combine(appPath, $"Void_{invoiceNumber}.pdf");

                var doc = new PdfDocument();
                var page = doc.AddPage();
                page.Width = XUnit.FromMillimeter(80);
                page.Height = XUnit.FromMillimeter(280);

                var gfx = XGraphics.FromPdfPage(page);
                var font = new XFont("Consolas", 9, XFontStyle.Regular);
                var bold = new XFont("Consolas", 9, XFontStyle.Bold);

                double x = 0;
                double y = 10;
                double lineHeight = 12;

                gfx.DrawString("PAKO Riderstuff", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("**VOID RECEIPT**", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                // ✅ Add void number before invoice number
                gfx.DrawString($"Void No: {voidNumber}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Invoice: {invoiceNumber}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                gfx.DrawString($"Date: {DateTime.Now:yyyy-MM-dd HH:mm}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("ITEM          QTY  PRICE   TOTAL", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                foreach (var it in items)
                {
                    string displayName = it.productName.Length > 10 ? it.productCode : it.productName;
                    string qtyText = it.qty.ToString("0.##").PadLeft(5);
                    string priceText = it.unitPrice.ToString("F2").PadLeft(7);
                    string totalText = it.total.ToString("F2").PadLeft(8);

                    gfx.DrawString($"{displayName.PadRight(10)}{"-" + qtyText}{"-" + priceText}{"-" + totalText}", font, XBrushes.Black, new XPoint(x, y));
                    y += lineHeight;

                    if (!string.IsNullOrWhiteSpace(it.discountType) && !it.discountType.Equals("none", StringComparison.OrdinalIgnoreCase) && it.discount > 0)
                    {
                        gfx.DrawString($" -₱{it.discount:F2} ({it.discountType})", font, XBrushes.Black, new XPoint(x + 5, y));
                        y += lineHeight;
                    }
                }

                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Subtotal:     -₱{subTotal:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"VATable Sales:      -₱{vatableSales:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"VAT Amount (12%):    -₱{vatAmount:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"VAT Exempt:  -₱{vatExempt:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"GRAND TOTAL:  -₱{grandTotal:F2}", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight + 4;
                gfx.DrawString($"Payment: {paymentMethod}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Cash:         -₱{cashReceived:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Change:       -₱{cashChange:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight + 8;
                gfx.DrawString("THIS DOCUMENT IS NOT VALID FOR CLAIM OF INPUT TAX", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                doc.Save(pdfPath);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving PDF: " + ex.Message, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
