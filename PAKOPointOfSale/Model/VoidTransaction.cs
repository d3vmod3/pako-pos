using PAKOPointOfSale.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VoidTransaction
{

    public int id { get; set; }
    public string void_number { get; set; }
    public string invoice_number { get; set; }

    [ForeignKey("transaction")]
    public int transaction_id { get; set; }
    public ICollection<Transaction> Transactions { get; set; }


}
