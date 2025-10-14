using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAKOPointOfSale.Model
{
    public class Permission
    {
        public int id { get; set; }

        // Foreign key to UserType
        [ForeignKey("userType")]
        public int user_type_id { get; set; }

        // The specific module or area (e.g., "Products", "Categories", "Users")
        public string module_name { get; set; }

        // Permissions
        public bool can_view { get; set; }
        public bool can_add { get; set; }
        public bool can_edit { get; set; }
        public bool can_delete { get; set; }
        public UserType userType { get; set; }

    }
}
