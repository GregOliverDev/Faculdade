using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockController
{
    public partial class Sales_Relat : Form
    {
        public Sales_Relat(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            bt_Export.BackColor = colorSecond;
            bt_Impri.BackColor = colorSecond;
            tb_Filter1.MaxLength = 15;
            tb_Filter2.MaxLength = 15;
            tb_Filter3.MaxLength = 50;
            tb_Filter4.MaxLength = 50;

            #region buttonFlat
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    //button.BackColor = Color.Blue;
                    //button.ForeColor = Color.White; 
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Arial", 10, FontStyle.Bold);

                }
            }
            #endregion
        }
    }
}
