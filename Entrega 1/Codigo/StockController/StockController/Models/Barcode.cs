using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class Barcode
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string GtinEan { get; set; }
        public string Bar128 { get; set; }
    }
}