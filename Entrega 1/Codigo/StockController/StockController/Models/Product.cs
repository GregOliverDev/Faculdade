using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public int IdBrand { get; set; }
        public int IdUnitM {  get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public float ReplacementCost { get; set; }
        public string Status { get; set; }
        public float Value { get; set; }
    }
}
