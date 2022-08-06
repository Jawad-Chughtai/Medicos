using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class InvoiceItemsModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string BatchTitle { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double ItemTotal { get; set; }
        public bool IsStock { get; set; }
        public int UpdatedStock { get; set; }
        public DateTime Expiry { get; set; }
    }
}
