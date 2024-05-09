using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string CorporateReason { get; set; }
        public string Name { get; set; }
        public string Obsevation { get; set; }
        public string RegistrationType { get; set; }
        public string Status { get; set; }
    }
}
