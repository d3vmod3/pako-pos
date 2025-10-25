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
    public class PrintSalesInvoiceReceipt ()
    {
        public static void GenerateReceiptFromDatabase(string invoiceNumber)
        {
            //try
            //{
                string connString = PAKOPointOfSale.Program.ConnString;

                // Header fields
                decimal vatAmount = 0m, vatableSales = 0m, vatExempt = 0m, subTotal = 0m, grandTotal = 0m;
                string paymentMethod = "";
                decimal cashReceived = 0m, cashChange = 0m;
                string status = "";

                // Items list: name, qty, unitPrice, total, discount, discountType, uom
                var items = new List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)>();

                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // 1) Read transaction header
                    using (var cmd = new SqlCommand(@"
                        SELECT id, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total,
                               payment_method, cash_received, cash_change, status
                        FROM Transactions
                        WHERE invoice_number = @invoiceNumber AND status = 'Success'", conn))
                    {
                        cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                // Use DBNull checks
                                vatAmount = r.IsDBNull(r.GetOrdinal("vat_amount")) ? 0m : Convert.ToDecimal(r["vat_amount"]);
                                vatableSales = r.IsDBNull(r.GetOrdinal("vatable_sales")) ? 0m : Convert.ToDecimal(r["vatable_sales"]);
                                vatExempt = r.IsDBNull(r.GetOrdinal("vat_exempt")) ? 0m : Convert.ToDecimal(r["vat_exempt"]);
                                subTotal = r.IsDBNull(r.GetOrdinal("sub_total")) ? 0m : Convert.ToDecimal(r["sub_total"]);
                                grandTotal = r.IsDBNull(r.GetOrdinal("grand_total")) ? 0m : Convert.ToDecimal(r["grand_total"]);
                                paymentMethod = r.IsDBNull(r.GetOrdinal("payment_method")) ? "" : r["payment_method"].ToString();
                                cashReceived = r.IsDBNull(r.GetOrdinal("cash_received")) ? 0m : Convert.ToDecimal(r["cash_received"]);
                                cashChange = r.IsDBNull(r.GetOrdinal("cash_change")) ? 0m : Convert.ToDecimal(r["cash_change"]);
                                status = r.IsDBNull(r.GetOrdinal("status")) ? "" : r["status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show($"No successful transaction found for invoice: {invoiceNumber}",
                                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // 2) Read sales invoice items and their discount fields (from SalesInvoiceItems)
                    using (var cmd = new SqlCommand(@"
                        SELECT p.product_name, p.product_code, si.quantity, si.unit_price, si.total_amount, si.discount, si.discount_type, si.unit_of_measurement
                        FROM SalesInvoiceItems si
                        INNER JOIN Products p ON si.product_id = p.id
                        INNER JOIN Transactions t ON si.transaction_id = t.id
                        WHERE t.invoice_number = @invoiceNumber
                        ORDER BY si.id", conn))
                    {
                        cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                string productName = r.IsDBNull(r.GetOrdinal("product_name")) ? "" : r["product_name"].ToString();
                                string productCode = r.IsDBNull(r.GetOrdinal("product_code")) ? "" : r["product_code"].ToString();
                                decimal qty = r.IsDBNull(r.GetOrdinal("quantity")) ? 0m : Convert.ToDecimal(r["quantity"]);
                                decimal unitPrice = r.IsDBNull(r.GetOrdinal("unit_price")) ? 0m : Convert.ToDecimal(r["unit_price"]);
                                decimal total = r.IsDBNull(r.GetOrdinal("total_amount")) ? 0m : Convert.ToDecimal(r["total_amount"]);
                                decimal discount = r.IsDBNull(r.GetOrdinal("discount")) ? 0m : Convert.ToDecimal(r["discount"]);
                                string discountType = r.IsDBNull(r.GetOrdinal("discount_type")) ? "" : r["discount_type"].ToString();
                                string uom = r.IsDBNull(r.GetOrdinal("unit_of_measurement")) ? "" : r["unit_of_measurement"].ToString();

                                items.Add((productName, productCode, qty, unitPrice, total, discount, discountType, uom));

                            }
                        }
                    }
                } // end using conn

                // Generate PDF
                SaveAsPdf(invoiceNumber, items, vatAmount, vatableSales, vatExempt, subTotal, grandTotal,
                    paymentMethod, cashReceived, cashChange);
            }
            //catch (Exception ex)
            //{
                //MessageBox.Show("Error generating receipt: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        

        private static void SaveAsPdf(
            string invoiceNumber,
            List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)> items,
            decimal vatAmount, decimal vatableSales, decimal vatExempt,
            decimal subTotal, decimal grandTotal,
            string paymentMethod, decimal cashReceived, decimal cashChange)
        {
            try
            {
                string appPath = Application.StartupPath;
                string pdfPath = Path.Combine(appPath, $"Receipt_{invoiceNumber}.pdf");

                var doc = new PdfDocument();
                var page = doc.AddPage();
                page.Width = XUnit.FromMillimeter(80);
                page.Height = XUnit.FromMillimeter(280); // a bit taller to fit more lines

                var gfx = XGraphics.FromPdfPage(page);
                var font = new XFont("Consolas", 9, XFontStyle.Regular);
                var bold = new XFont("Consolas", 9, XFontStyle.Bold);

                double x = 0;
                double y = 10;
                double lineHeight = 12;

                gfx.DrawString("PAKO Riderstuff", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("**Sales Invoice**", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Invoice: {invoiceNumber}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Date: {DateTime.Now:yyyy-MM-dd HH:mm}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("ITEM          QTY  PRICE   TOTAL", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                // Items
                foreach (var it in items)
                {
                    // Use product code if product name is longer than 10 chars
                    string displayName = it.productName.Length > 10 ? it.productCode : it.productName;

                    string qtyText = it.qty.ToString("0.##").PadLeft(5);
                    string uom = it.uom.ToString();
                    string priceText = it.unitPrice.ToString("F2").PadLeft(7);
                    string totalText = it.total.ToString("F2").PadLeft(8);

                    // Format the line
                    gfx.DrawString($"{displayName.PadRight(10)}{qtyText}{uom}{priceText}{totalText}", font, XBrushes.Black, new XPoint(x, y));
                    y += lineHeight;

                    // Display discount if applicable
                    if (!string.IsNullOrWhiteSpace(it.discountType) && !it.discountType.Equals("none", StringComparison.OrdinalIgnoreCase) && it.discount > 0)
                    {
                        gfx.DrawString($" -₱{it.discount:F2} ({it.discountType})", font, XBrushes.Black, new XPoint(x + 5, y));
                        y += lineHeight;
                    }
                }

                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Subtotal:     ₱{subTotal:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"VATable Sales:      ₱{vatableSales:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"VAT Amount (12%):    ₱{vatAmount:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"VAT Exempt:   ₱{vatExempt:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString("--------------------------------------", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"GRAND TOTAL:  ₱{grandTotal:F2}", bold, XBrushes.Black, new XPoint(x, y)); y += lineHeight + 4;
                gfx.DrawString($"Payment: {paymentMethod}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Cash:         ₱{cashReceived:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;
                gfx.DrawString($"Change:       ₱{cashChange:F2}", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight + 8;
                gfx.DrawString("Thank you for your purchase!", font, XBrushes.Black, new XPoint(x, y)); y += lineHeight;

                doc.Save(pdfPath);

                // Open file (default PDF viewer / Chrome)
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
