using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class MovsStock
    {
        public int Id { get; set; }
        public int IdStock { get; set; }
        public int IdOrigin { get; set; }
        public string TypeMov { get; set; }
        public float QuantMov { get; set; }
    }
}
