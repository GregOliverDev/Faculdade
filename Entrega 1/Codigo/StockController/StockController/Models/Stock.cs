using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public float Quant { get; set; }
    }
}
