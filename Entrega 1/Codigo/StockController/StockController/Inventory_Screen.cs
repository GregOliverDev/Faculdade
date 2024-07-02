using StockController.Data;
using StockController.Models;
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
    public partial class Inventory_Screen : Form
    {
        Color colorBack, colorSecond;
        Product product = new Product();
        Stock stock = new Stock();

        public Inventory_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            this.BackColor = colorBack;
            bt_Cancel.BackColor = colorSecond;
            bt_Save.BackColor = colorSecond;
            tb_Product.MaxLength = 15;
            tb_New_Stock.MaxLength = 7;

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

        private void bt_Search_Product_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Product_Screen search_Product_Screen = new Search_Product_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            search_Product_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int codeProductSearch = search_Product_Screen.codeProduct;
                if (codeProductSearch > 0)
                {
                    tb_Product.Text = codeProductSearch.ToString();
                    tb_Product_Leave(sender, e);
                }
            };

            search_Product_Screen.Show();
        }

        private void tb_Product_Leave(object sender, EventArgs e)
        {
            if (tb_Product.Text != null && tb_Product.Text != "")
            {
                product.Code = Convert.ToInt32(tb_Product.Text);
                product = SelectDb.SelectProduct(product.Code, 1);

                if (product.Id != 0)
                {
                    tb_Viewer_Produto.Text = product.Name;
                    tb_Product.Enabled = false;
                    bt_Search_Product.Enabled = false;
                    tb_New_Stock.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Save.Enabled = true;

                    tb_Product.Text = product.Code.ToString();
                    tb_Viewer_Produto.Text = product.Name;

                    stock = SelectDb.SelectStock(product.Code);

                    tb_Stock_Current.Text = stock.Quant.ToString();
                }
                else
                {
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            tb_Product.Enabled = true;
            bt_Search_Product.Enabled = true;
            tb_New_Stock.Enabled = false;
            bt_Cancel.Enabled = false;
            bt_Save.Enabled = false;

            tb_New_Stock.Text = "";
            tb_Product.Text = "";
            tb_Stock_Current.Text = "";
            tb_Viewer_Produto.Text = "";

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (tb_New_Stock.Text == null || tb_New_Stock.Text == "")
            {
                MessageBox.Show("Digite uma quantidade valida.", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                string strQuant = tb_New_Stock.Text;
                stock.Quant = float.Parse(strQuant);
                UpdateDb.UpdateStock(stock);

                MovsStock movsStock = new MovsStock();
                movsStock.IdStock = stock.Id;
                movsStock.IdOrigin = 0;
                movsStock.TypeMov = "Inventario Dia" + DateTime.Now.ToString();
                movsStock.QuantMov = stock.Quant;

                InsertDb.InsertMovsStock(movsStock);

                bt_Cancel_Click(sender, e);
            }
        }

        private void ts_Search_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ts_Search_Code_KeyPressFloat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

    }
}
