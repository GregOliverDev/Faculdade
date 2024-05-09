using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class Purchases
    {
        public int Id { get; set; }
        public int IdSupplier { get; set; }
        public float Value { get; set; }

    }
}
