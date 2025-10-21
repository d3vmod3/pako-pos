using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions
{
    public class PrintReturnReceipt
    {
        public static void GenerateReturnReceiptFromTransactionId(int newTransactionId)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                // Header fields
                string returnNumber = "";
                int return_transaction_id = 0;
                decimal vatAmount = 0m, vatableSales = 0m, vatExempt = 0m, subTotal = 0m, grandTotal = 0m;
                string invoiceNumber = "";

                var items = new List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)>();

                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // 1️⃣ Get return number from ReturnTransactions
                    using (var cmd = new SqlCommand(@"
                        SELECT TOP 1 id, return_number, invoice_number
                        FROM ReturnTransactions
                        WHERE transaction_id = @transactionId", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", newTransactionId);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                returnNumber = r["return_number"].ToString();
                                invoiceNumber = r["invoice_number"].ToString();
                                return_transaction_id = Convert.ToInt32(r["id"]);
                            }
                            else
                            {
                                MessageBox.Show($"No return transaction found for Transaction ID: {newTransactionId}",
                                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // 2️⃣ Read transaction header
                    using (var cmd = new SqlCommand(@"
                        SELECT vat_amount, vatable_sales, vat_exempt, sub_total, grand_total
                        FROM Transactions
                        WHERE id = @transactionId AND transaction_type = 'Return'", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", newTransactionId);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                vatAmount = Convert.ToDecimal(r["vat_amount"]);
                                vatableSales = Convert.ToDecimal(r["vatable_sales"]);
                                vatExempt = Convert.ToDecimal(r["vat_exempt"]);
                                subTotal = Convert.ToDecimal(r["sub_total"]);
                                grandTotal = Convert.ToDecimal(r["grand_total"]);
                            }
                        }
                    }


                    // 3️⃣ Read items from ReturnItems
                    using (var cmd = new SqlCommand(@"
                       SELECT p.product_name, p.product_code, ri.quantity, ri.unit_price, ri.total_amount,
                                ri.discount, ri.discount_type, ri.unit_of_measurement
                        FROM ReturnItems ri
                        INNER JOIN Products p ON ri.product_id = p.id
                        WHERE ri.return_transaction_id = @returnTransactionId AND ri.transaction_type = 'Return'
                        ORDER BY ri.id", conn))
                    {
                        cmd.Parameters.AddWithValue("@returnTransactionId", return_transaction_id);
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

                // 4️⃣ Generate PDF
                SaveAsPdf(invoiceNumber, returnNumber, items, vatAmount, vatableSales, vatExempt, subTotal, grandTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating return receipt: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void SaveAsPdf(
            string invoiceNumber,
            string returnNumber,
            List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)> items,
            decimal vatAmount, decimal vatableSales, decimal vatExempt,
            decimal subTotal, decimal grandTotal)
        {
            try
            {
                string appPath = Application.StartupPath;
                string pdfPath = Path.Combine(appPath, $"Return_{returnNumber}.pdf");

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
                gfx.DrawString("**RETURN RECEIPT**", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                gfx.DrawString($"Return No: {returnNumber}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Invoice: {invoiceNumber}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Date: {DateTime.Now:yyyy-MM-dd HH:mm}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("ITEM          QTY  PRICE   TOTAL", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                foreach (var it in items)
                {
                    string displayName = it.productName.Length > 10 ? it.productCode : it.productName;
                    string qtyText = "-" + it.qty.ToString("0.##").PadLeft(5);
                    string priceText = "-" + it.unitPrice.ToString("F2").PadLeft(7);
                    string totalText = "-" + it.total.ToString("F2").PadLeft(8);

                    gfx.DrawString($"{displayName.PadRight(10)} {qtyText} {priceText} {totalText}", font, XBrushes.Black, new XPoint(x, y));
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
