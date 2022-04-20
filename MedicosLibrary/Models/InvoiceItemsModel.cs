using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    class InvoiceItemsModel
    {
        public int InvoiceID { get; set; }
        public int ItemID { get; set; }
        public int ItemQuantity { get; set; }
        public double Total { get; set; }
    }
}
