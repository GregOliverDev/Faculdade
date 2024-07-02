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
    public partial class Brand_Screen : Form
    {
        Color colorBack, colorSecond;

        // insert or update control variable
        string controlIG;

        public Brand_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            menu_Brand.BackColor = colorSecond;
            sp_Choices.BackColor = colorSecond;
            pb_Borda_Hori_1.BackColor = colorBack;
            pb_Borda_Hori_2.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;
            ts_Search_Code.MaxLength = 10;

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

        private void bt_Search_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "Brand");

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idBrandSearch = search_Screen.idObj;
                if (idBrandSearch > 0)
                {
                    ts_Search_Code.Text = idBrandSearch.ToString();
                    ts_Search_Code_Leave(sender, e);
                }
            };

            search_Screen.Show();
        }

        private void bt_New_Brand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand = SelectDb.SelectBrand(0, 2);
            brand.Id = brand.Id + 1;
            ts_Search_Code.Text = brand.Id.ToString();
            ts_Search_Code_Leave(sender, e);
        }

        private void ts_Search_Code_Leave(object sender, EventArgs e)
        {
            string codString = ts_Search_Code.Text;
            int cod;
            #region checkString
            if (codString == "" || codString == null)
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(codString);
            }
            #endregion

            if (cod <= 0)
            {
                tb_Descri_Brand.Enabled = false;
                bt_Save.Enabled = false;
                bt_Cancel.Enabled = false;
                bt_Delete.Enabled = false;
                ts_Search_Code.Enabled = true;
                bt_New_Brand.Enabled = true;
                bt_Search.Enabled = true;
                controlIG = "";
            }
            else
            {
                Brand brand = new Brand();
                brand = SelectDb.SelectBrand(cod, 1);
                if (brand.Id == 0)
                {
                    tb_Descri_Brand.Enabled = true;
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    ts_Search_Code.Enabled = false;
                    bt_New_Brand.Enabled = false;
                    bt_Search.Enabled = false;
                    controlIG = "Insert";
                }
                else
                {
                    tb_Descri_Brand.Enabled = true;
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    ts_Search_Code.Enabled = false;
                    bt_New_Brand.Enabled = false;
                    bt_Search.Enabled = false;
                    controlIG = "Update";
                    tb_Descri_Brand.Text = brand.Description;
                }
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.Id = int.Parse(ts_Search_Code.Text);
            brand.Description = tb_Descri_Brand.Text;

            string strCheck= brand.Description.Replace(" ", "").Replace("\r\n", "");

            if (controlIG == "Insert")
            {
                if (strCheck == "")
                {
                    MessageBox.Show("Preencha o campo Descrição.","Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    InsertDb.InsertBrand(brand);
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Marca cadastrada com Sucesso", "Aviso", MessageBoxButtons.OK);
                }
            }
            else if (controlIG == "Update")
            {
                if (strCheck == "")
                {
                    MessageBox.Show("Preencha o campo Descrição.", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    UpdateDb.UpdateBrand(brand);
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Marca atualizada com Sucesso", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (controlIG == "Insert")
            {
                MessageBox.Show("Marca não cadastrada ainda\nCancele o processo se precisar.", "AVISO", MessageBoxButtons.OK) ;
            }
            else if(controlIG == "Update")
            {
                Brand brand = new Brand();
                brand.Id = int.Parse(ts_Search_Code.Text);                

                DeleteDb.DeleteBrand(brand);
                MessageBox.Show("Marca excluída com sucesso");
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

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            ts_Search_Code.Text = "";
            tb_Descri_Brand.Enabled = false;
            bt_Save.Enabled = false;
            bt_Cancel.Enabled = false;
            bt_Delete.Enabled = false;
            ts_Search_Code.Enabled = true;
            bt_New_Brand.Enabled = true;
            bt_Search.Enabled = true;
            controlIG = "";
            tb_Descri_Brand.Text = "";
        }
    }
}
