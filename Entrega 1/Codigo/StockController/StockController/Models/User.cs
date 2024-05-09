using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class User
    {
        public int Id { get; set; }
        public string CnpjCfp { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }    
        public int Type { get; set; }
    }
}
