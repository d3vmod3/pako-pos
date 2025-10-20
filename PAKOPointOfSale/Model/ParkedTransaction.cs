using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAKOPointOfSale.Model
{
    public class ParkedTransaction
    {
        public int id { get; set; }
        public string park_number { get; set; }

        [ForeignKey("transaction")]
        public int transaction_id { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}