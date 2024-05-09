using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockController.Models
{
    public class ColorSave
    {
        public int Id { get; set; }
        public string ColorBack { get; set; }
        public string ColorSecond { get; set; }
        public Color ColorBackCor { get; set; }
        public Color ColorSecondCor { get; set; }
    }
}
