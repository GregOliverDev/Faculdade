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
    public partial class Category_Screen : Form
    {
        Color colorBack, colorSecond;

        // insert or update control variable
        string controlIG, controlCbxMovStock = "";
        public Category_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            menu_Category.BackColor = colorSecond;
            sp_Choices.BackColor = colorSecond;
            pb_Borda_Hori_1.BackColor = colorBack;
            pb_Borda_Hori_2.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;

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

        #region checkBox
        private void cbx_Mov_No_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Mov_No.Checked)
            {
                cbx_Mov_Yes.Enabled = false;
                controlCbxMovStock = "Não";
            }
            else
            {
                cbx_Mov_Yes.Enabled = true;
                controlCbxMovStock = "";
            }

        }

        private void cbx_Mov_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Mov_Yes.Checked)
            {
                cbx_Mov_No.Enabled = false;
                controlCbxMovStock = "Sim";
            }
            else
            {
                cbx_Mov_No.Enabled = true;
                controlCbxMovStock = "";
            }

        }
        #endregion
        private void bt_Search_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "Category");

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idCategorySearch = search_Screen.idObj;
                if (idCategorySearch > 0)
                {
                    ts_Search_Code.Text = idCategorySearch.ToString();
                    ts_Search_Code_Leave(sender, e);
                }
            };

            search_Screen.Show();
        }

        private void bt_New_Category_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category = SelectDb.SelectCategory(0, 2);
            category.Id = category.Id + 1;
            ts_Search_Code.Text = category.Id.ToString();
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
                MessageBox.Show("Digite um codigo valido", "Aviso", MessageBoxButtons.OK);
                tb_Descri_Category.Enabled = false;
                bt_Save.Enabled = false;
                bt_Cancel.Enabled = false;
                bt_Delete.Enabled = false;
                cbx_Mov_No.Enabled = false;
                cbx_Mov_Yes.Enabled = false;
                ts_Search_Code.Enabled = true;
                bt_New_Category.Enabled = true;
                bt_Search.Enabled = true;
                controlIG = "";
            }
            else
            {
                Category category = new Category();
                category = SelectDb.SelectCategory(cod, 1);
                if (category.Id == 0)
                {
                    tb_Descri_Category.Enabled = true;
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    cbx_Mov_No.Enabled = true;
                    cbx_Mov_Yes.Enabled = true;
                    ts_Search_Code.Enabled = false;
                    bt_New_Category.Enabled = false;
                    bt_Search.Enabled = false;
                    controlIG = "Insert";
                }
                else
                {
                    tb_Descri_Category.Enabled = true;
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    cbx_Mov_No.Enabled = true;
                    cbx_Mov_Yes.Enabled = true;
                    ts_Search_Code.Enabled = false;
                    bt_New_Category.Enabled = false;
                    bt_Search.Enabled = false;
                    controlIG = "Update";
                    tb_Descri_Category.Text = category.Description;
                    if (category.MovStock == "Não")
                    {
                        cbx_Mov_No.Checked = true;
                    }
                    else
                    {
                        cbx_Mov_Yes.Checked = true;
                    }
                }
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = int.Parse(ts_Search_Code.Text);
            category.Description = tb_Descri_Category.Text;
            category.MovStock = controlCbxMovStock;

            string strCheck = category.Description.Replace(" ", "").Replace("\r\n", "");

            if (controlIG == "Insert")
            {
                if (strCheck == "")
                {
                    MessageBox.Show("Preencha o campo Descrição.", "Aviso", MessageBoxButtons.OK);
                }
                else if (controlCbxMovStock == "")
                {
                    MessageBox.Show("Selecione uma opção de movimento de estoque.", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    InsertDb.InsertCategory(category);
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Categoria cadastrada com Sucesso", "Aviso", MessageBoxButtons.OK);
                }
            }
            else if (controlIG == "Update")
            {
                if (strCheck == "")
                {
                    MessageBox.Show("Preencha o campo Descrição.", "Aviso", MessageBoxButtons.OK);
                }
                else if (controlCbxMovStock == "")
                {
                    MessageBox.Show("Selecione uma opção de movimento de estoque.", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    UpdateDb.UpdateCategory(category);
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Categoria atualizada com Sucesso", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (controlIG == "Insert")
            {
                MessageBox.Show("Categoria não cadastrada ainda\nCancele o processo se precisar.", "AVISO", MessageBoxButtons.OK);
            }
            else if (controlIG == "Update")
            {
                Category category = new Category();
                category.Id = int.Parse(ts_Search_Code.Text);

                DeleteDb.DeleteCategory(category);
                MessageBox.Show("Categoria excluída com sucesso");
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
            tb_Descri_Category.Enabled = false;
            bt_Save.Enabled = false;
            bt_Cancel.Enabled = false;
            bt_Delete.Enabled = false;
            cbx_Mov_No.Checked = false;
            cbx_Mov_Yes.Checked = false;
            cbx_Mov_No.Enabled = false;
            cbx_Mov_Yes.Enabled = false;
            ts_Search_Code.Enabled = true;
            bt_New_Category.Enabled = true;
            bt_Search.Enabled = true;
            controlIG = "";
            tb_Descri_Category.Text = "";
        }
    }
}
