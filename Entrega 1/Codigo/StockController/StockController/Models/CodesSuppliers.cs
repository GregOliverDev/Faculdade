using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class CodesSuppliers
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdSupplier { get; set; }
        public string Code { get; set; }
    }
}
