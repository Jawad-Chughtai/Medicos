using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText;

namespace MedicosLibrary.Models
{
    public class InvoiceModel
    {
        public string InvoiceId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public double InvoiceTotal { get; set; }
        public double Discount { get; set; }
        public List<InvoiceItemsModel> Items { get; set; }

        public void ShowInvoice()
        {

        }
    }

}
