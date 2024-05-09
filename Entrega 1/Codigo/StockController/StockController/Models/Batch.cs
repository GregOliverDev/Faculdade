using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class Batch
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime FabricationDate { get; set; }
        public int Number { get; set; }
        public string Obsevation { get; set; }
    }
}
