using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace PAKOPointOfSale.Transactions
{
    public partial class ReceiptPrinter : Form
    {
        public ReceiptPrinter()
        {
            InitializeComponent();
        }

        private void ReceiptPrinter_Load(object sender, EventArgs e)
        {

        }
        public void PrintReceipt()
        {

        }

        private void printSalesInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Consolas", 10);
            float y = 20;

            g.DrawString("MOTO SHOP POS", new Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 10, y);
            y += 30;
            g.DrawString("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"), font, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("--------------------------------------", font, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("ITEM              QTY   PRICE", font, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("Spark Plug         2   150.00", font, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("Oil Change         1  1200.00", font, Brushes.Black, 10, y);
            y += 30;
            g.DrawString("--------------------------------------", font, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("TOTAL: ₱1350.00", new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, 10, y);
            y += 40;
            g.DrawString("Thank you!", font, Brushes.Black, 10, y);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveAsPdf();
        }
        public void SaveAsPdf()
        {
            try
            {
                string appPath = Application.StartupPath;
                string pdfPath = System.IO.Path.Combine(appPath, "receipt.pdf");

                // Create PDF
                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.AddPage();

                // Set page width to 80mm, height to arbitrary large value (dynamic height)
                page.Width = XUnit.FromMillimeter(80);
                page.Height = XUnit.FromMillimeter(200); // start height, can add pages if needed

                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 10, XFontStyle.Regular);

                int y = 10; // start printing 10 units from top
                int lineHeight = 15;

                // Example content - header
                gfx.DrawString("My Store", font, XBrushes.Black, new XPoint(0, y));
                y += lineHeight;

                gfx.DrawString("Address line 1", font, XBrushes.Black, new XPoint(0, y));
                y += lineHeight;

                gfx.DrawString("------------------------", font, XBrushes.Black, new XPoint(0, y));
                y += lineHeight;

                // Example items
                string[] items = { "Item1      10.00", "Item2       5.00", "Item3       7.50" };
                foreach (var item in items)
                {
                    gfx.DrawString(item, font, XBrushes.Black, new XPoint(0, y));
                    y += lineHeight;
                }

                gfx.DrawString("------------------------", font, XBrushes.Black, new XPoint(0, y));
                y += lineHeight;

                // Total
                gfx.DrawString("Total:     22.50", font, XBrushes.Black, new XPoint(0, y));

                // Save PDF
                doc.Save(pdfPath);

                MessageBox.Show($"Receipt saved as PDF:\n{pdfPath}", "PDF Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open PDF
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving PDF: " + ex.Message);
            }
        }

    }
}
