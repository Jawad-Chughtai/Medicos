using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class ItemModel
    {
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public int DistributoID { get; set; }
        public int CompanyID { get; set; }
    }
}
