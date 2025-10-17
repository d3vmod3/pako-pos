using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PAKOPointOfSale
{
    public static class SalesInvoiceFunctions
    {
        public static string GenerateNextInvoiceNumber()
        {
            string lastInvoice = null;
            using (SqlConnection conn = new SqlConnection(Program.ConnString))
            {
                conn.Open();
                string query = "SELECT TOP 1 invoice_number FROM Transactions WHERE status='success' ORDER BY id DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        lastInvoice = result.ToString();
                }

                int nextNumber = 1;

                if (!string.IsNullOrEmpty(lastInvoice))
                {
                    if (int.TryParse(lastInvoice, out int lastNumber))
                        nextNumber = lastNumber + 1;
                }

                // Pad with zeros to make 6 digits
                return nextNumber.ToString("D6"); // e.g., "000001", "000002"
            }
        }
        public static string GenerateNextVoidNumber()
        {
            string lastInvoice = null;
            using (SqlConnection conn = new SqlConnection(Program.ConnString))
            {
                conn.Open();
                string query = "SELECT TOP 1 void_number FROM VoidTransactions ORDER BY id DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        lastInvoice = result.ToString();
                }

                int nextNumber = 1;

                if (!string.IsNullOrEmpty(lastInvoice))
                {
                    if (int.TryParse(lastInvoice, out int lastNumber))
                        nextNumber = lastNumber + 1;
                }

                // Pad with zeros to make 6 digits
                return nextNumber.ToString("D6"); // e.g., "000001", "000002"
            }
        }

        public static decimal getVATAmount(decimal unit_price, decimal qty)
        {
            decimal vatAmount = 0.12m * ((qty * unit_price) / 1.12m);
            return vatAmount;
        }

        public static decimal getVATExempt(decimal unit_price, decimal qty)
        {
            decimal vatAmount = 0.12m * ((qty * unit_price) / 1.12m);
            return vatAmount;
        }

        public static decimal getVATableSales(decimal unit_price, decimal qty)
        {
            decimal vatableSales = (qty * unit_price) / 1.12m;
            return vatableSales;
        }

        public static decimal getSCDiscount(decimal unit_price, decimal rate, decimal qty)
        {
            decimal price = qty * unit_price;
            decimal vatableSales = price / 1.12m;
            decimal discount = rate * vatableSales;
            return discount;
        }
        public static decimal getPWDDiscount(decimal unit_price, decimal rate, decimal qty)
        {
            decimal price = qty * unit_price;
            decimal vatableSales = price / 1.12m;
            decimal discount = rate * vatableSales;
            return discount;
        }
        public static decimal getNAACDiscount(decimal unit_price, decimal rate, decimal qty)
        {
            decimal price = qty * unit_price;
            decimal discount = rate * price;
            return discount;
        }
    }
}
