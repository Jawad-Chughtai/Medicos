using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class BatchModel
    {
        public string BatchNumber { get; set; }
        public string BatchExpiry { get; set; }
        public double ItemPrice { get; set; }
        public int ItemStock { get; set; }
    }
}
