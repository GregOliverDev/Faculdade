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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockController
{
    public partial class Supplier_Screen : Form
    {
        Color colorBack, colorSecond;

        // insert or update control variable
        string controlIG, strStatusCbx = "", regisType = "";

        public Supplier_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            menu_Supplier.BackColor = colorSecond;
            sp_Choices.BackColor = colorSecond;
            pb_Borda_Hori_1.BackColor = colorBack;
            pb_Borda_Hori_2.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;
            lb_Status_Supplier.BackColor = colorSecond;
            ts_Search_Code.MaxLength = 10;
            tb_Name_Supplier.MaxLength = 50;
            tb_CorporateReason.MaxLength = 50;
            tb_Obs_Supplier.MaxLength = 200;

            tb_CpfCnpj.KeyPress += tb_CpfCnpj_KeyPress;

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
        private void cbx_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Active.Checked)
            {
                cbx_Inactive.Enabled = false;
                strStatusCbx = "Ativo";
            }
            else
            {
                cbx_Inactive.Enabled = true;
                strStatusCbx = "";
            }

        }
        private void cbx_Inactive_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_Inactive.Checked)
            {
                cbx_Active.Enabled = false;
                strStatusCbx = "Inativo";
            }
            else
            {
                cbx_Active.Enabled = true;
                strStatusCbx = "";
            }
        }
        private void cbx_Cpf_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_Cpf.Checked)
            {
                cbx_CNPJ.Enabled = false;
                tb_CpfCnpj.Enabled = true;
                regisType = "Cpf";
            }
            else
            {
                cbx_CNPJ.Enabled = true;
                tb_CpfCnpj.Enabled = false;
                regisType = "";
                tb_CpfCnpj.Text = "";
            }
        }
        private void cbx_CNPJ_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_CNPJ.Checked)
            {
                cbx_Cpf.Enabled = false;
                tb_CpfCnpj.Enabled = true;
                regisType = "CNPJ";
            }
            else
            {
                cbx_Cpf.Enabled = true;
                tb_CpfCnpj.Enabled = false;
                regisType = "";
                tb_CpfCnpj.Text = "";
            }
        }
        #endregion

        private void bt_Search_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "Supplier", 1);

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idSupplierSearch = search_Screen.idObj;
                Supplier supplier = new Supplier();
                supplier = SelectDb.SelectSupplier(idSupplierSearch, 1);
                if (supplier.Id != 0)
                {
                    ts_Search_Code.Text = supplier.Id.ToString();
                    ts_Search_Code_Leave(sender, e);
                }
            };

            search_Screen.Show();
        }

        private void bt_New_Supplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier = SelectDb.SelectSupplier(0, 2);
            supplier.Id = supplier.Id + 1;
            ts_Search_Code.Text = supplier.Id.ToString();
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
                bt_Cancel_Click(sender, e);
            }
            else
            {
                Supplier supplier = new Supplier();
                supplier = SelectDb.SelectSupplier(cod, 1);
                if (supplier.Id == 0)
                {
                    tb_Name_Supplier.Enabled = true;
                    tb_CorporateReason.Enabled = true;

                    cbx_Active.Enabled = true;
                    cbx_Inactive.Enabled = true;

                    cbx_Cpf.Enabled = true;
                    cbx_CNPJ.Enabled = true;

                    tb_CpfCnpj.Enabled = false;
                    tb_Obs_Supplier.Enabled = true;

                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    bt_Save.Enabled = true;

                    bt_New_Supplier.Enabled = false;
                    bt_Search.Enabled = false;
                    ts_Search_Code.Enabled = false;
                    controlIG = "Insert";
                }
                else
                {
                    tb_Name_Supplier.Enabled = true;
                    tb_Name_Supplier.Text = supplier.Name;
                    tb_CorporateReason.Enabled = true;
                    tb_CorporateReason.Text = supplier.CorporateReason;
                    tb_CpfCnpj.Enabled = false;

                    if (supplier.Status == "Ativo")
                    {
                        cbx_Active.Enabled = true;
                        cbx_Active.Checked = true;
                        strStatusCbx = "Ativo";
                    }
                    else
                    {
                        cbx_Inactive.Enabled = true;
                        cbx_Inactive.Checked = true;
                        strStatusCbx = "Inativo";
                    }

                    if (supplier.RegistrationType == "Cpf")
                    {
                        cbx_Cpf.Enabled = true;
                        cbx_Cpf.Checked = true;
                        tb_CpfCnpj.Enabled = true;
                        regisType = "Cpf";
                    }
                    else
                    {
                        cbx_CNPJ.Enabled = true;
                        cbx_CNPJ.Checked = true;
                        tb_CpfCnpj.Enabled = true;
                        regisType = "CNPJ";
                    }

                    tb_CpfCnpj.Text = supplier.CpfCnpj;
                    tb_Obs_Supplier.Enabled = true;
                    tb_Obs_Supplier.Text = supplier.Obsevation;

                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    bt_Save.Enabled = true;

                    bt_New_Supplier.Enabled = false;
                    bt_Search.Enabled = false;
                    ts_Search_Code.Enabled = false;
                    controlIG = "Update";
                }
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Id = int.Parse(ts_Search_Code.Text);
            supplier.CpfCnpj = tb_CpfCnpj.Text;
            supplier.CorporateReason = tb_CorporateReason.Text;
            supplier.Name = tb_Name_Supplier.Text;
            supplier.Obsevation = tb_Obs_Supplier.Text;
            supplier.RegistrationType = regisType;
            supplier.Status = strStatusCbx;

            string strCheck = supplier.Name.Replace(" ", "").Replace("\r\n", "");

            if (controlIG == "Insert")
            {
                if (strCheck == "")
                {
                    MessageBox.Show("Preencha o campo Nome.", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    InsertDb.InsertSupplier(supplier);
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Fornecedor cadastrado com Sucesso", "Aviso", MessageBoxButtons.OK);
                }
            }
            else if (controlIG == "Update")
            {
                if (strCheck == "")
                {
                    MessageBox.Show("Preencha o campo Nome.", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    UpdateDb.UpdateSupplier(supplier);
                    bt_Cancel_Click(sender, e);
                    MessageBox.Show("Fornecedor atualizado com Sucesso", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (controlIG == "Insert")
            {
                MessageBox.Show("Fornecedor não cadastrado ainda\nCancele o processo se precisar.", "AVISO", MessageBoxButtons.OK);
            }
            else if (controlIG == "Update")
            {
                Supplier supplier = new Supplier();
                supplier.Id = int.Parse(ts_Search_Code.Text);

                DeleteDb.DeleteSupplier(supplier);
                MessageBox.Show("Fornecedor excluído com sucesso");
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

        private void tb_CpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (regisType == "Cpf")
            {
                tb_CpfCnpj.MaxLength = 14;
            }
            else
            {
                tb_CpfCnpj.MaxLength = 18;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (regisType == "Cpf")
            {
                if (char.IsDigit(e.KeyChar) && (tb_CpfCnpj.SelectionStart == 3 || tb_CpfCnpj.SelectionStart == 7))
                {
                    tb_CpfCnpj.Text += ".";
                    tb_CpfCnpj.SelectionStart = tb_CpfCnpj.Text.Length;
                }

                if (char.IsDigit(e.KeyChar) && tb_CpfCnpj.SelectionStart == 11)
                {
                    tb_CpfCnpj.Text += "-";
                    tb_CpfCnpj.SelectionStart = tb_CpfCnpj.Text.Length;
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) && (tb_CpfCnpj.SelectionStart == 2 || tb_CpfCnpj.SelectionStart == 6))
                {
                    tb_CpfCnpj.Text += ".";
                    tb_CpfCnpj.SelectionStart = tb_CpfCnpj.Text.Length;
                }
                if (char.IsDigit(e.KeyChar) && tb_CpfCnpj.SelectionStart == 10)
                {
                    tb_CpfCnpj.Text += "/";
                    tb_CpfCnpj.SelectionStart = tb_CpfCnpj.Text.Length;
                }
                if (char.IsDigit(e.KeyChar) && tb_CpfCnpj.SelectionStart == 15)
                {
                    tb_CpfCnpj.Text += "-";
                    tb_CpfCnpj.SelectionStart = tb_CpfCnpj.Text.Length;
                }
            }
            if (e.KeyChar == (char)Keys.Back && tb_CpfCnpj.SelectionStart <= 0)
            {
                e.Handled = true;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            tb_Name_Supplier.Enabled = false;
            tb_Name_Supplier.Text = "";
            tb_CorporateReason.Enabled = false;
            tb_CorporateReason.Text = "";

            cbx_Active.Checked = false;
            cbx_Inactive.Checked = false;
            cbx_Active.Enabled = false;
            cbx_Inactive.Enabled = false;

            cbx_Cpf.Checked = false;
            cbx_CNPJ.Checked = false;
            cbx_Cpf.Enabled = false;
            cbx_CNPJ.Enabled = false;

            tb_CpfCnpj.Enabled = false;
            tb_CpfCnpj.Text = "";
            tb_Obs_Supplier.Enabled = false;
            tb_Obs_Supplier.Text = "";

            bt_Cancel.Enabled = false;
            bt_Delete.Enabled = false;
            bt_Save.Enabled = false;

            bt_New_Supplier.Enabled = true;
            bt_Search.Enabled = true;
            ts_Search_Code.Enabled = true;
            ts_Search_Code.Text = "";
            regisType = "";
            strStatusCbx = "";
        }

    }
}
