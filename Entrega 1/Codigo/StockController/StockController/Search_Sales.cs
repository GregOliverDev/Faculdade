using StockController.Data;
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
    public partial class Search_Sales : Form
    {

        string strTypeSearch = "";
        public Search_Sales(Color colorBack, Color colorSecond, string strTypeSearch)
        {
            InitializeComponent();
            this.BackColor = colorBack; 
            this.strTypeSearch = strTypeSearch;
            sp_Choices.BackColor = colorSecond;
            sp_Menu.BackColor = colorSecond;
            dgv_Search.BackgroundColor = colorBack;
            pb_Borda_Hori_1.BackColor = colorBack;
            pb_Borda_Hori_2.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;
            lb_Type_Filter.BackColor = colorSecond;

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

            if (strTypeSearch == "S")
            {
                this.Text = this.Text + "Vendas";
                dgv_Search.Columns["Origin"].HeaderText = "Cliente";
            }
            else
            {
                this.Text = this.Text + "Compras";
                dgv_Search.Columns["Origin"].HeaderText = "Fornecedor";
            }
        }

        private void cbx_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Name.Checked)
            {
                dgv_Search.Rows.Clear();
                tb_Filter1.Enabled = true;
                tb_Filter2.Enabled = true;
                tb_Filter1.Text = "";
                tb_Filter2.Text = "";
            }
            else
            {
                dgv_Search.Rows.Clear();
                tb_Filter1.Enabled = false;
                tb_Filter2.Enabled = false;
                tb_Filter1.Text = "";
                tb_Filter2.Text = "";
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            dgv_Search.Rows.Clear();
            tb_Filter1.Text = "";
            tb_Filter2.Text = "";
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (tb_Filter1.Text != "")
            {
                if (tb_Filter2.Text == "")
                {
                    tb_Filter2.Text = tb_Filter1.Text;
                }
            }
            if (strTypeSearch == "S")
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectSalesAll(tb_Filter1.Text, tb_Filter2.Text);
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
            }
            else
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectPurchasesAll(tb_Filter1.Text, tb_Filter2.Text);
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
            }
        }
    }
}
