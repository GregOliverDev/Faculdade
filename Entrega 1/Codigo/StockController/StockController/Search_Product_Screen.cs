using StockController.Data;
using StockController.Models;
using StockController.Shared;
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
    public partial class Search_Product_Screen : Form
    {
        string cbxChecked;

        public int codeProduct = 0;

        int controlDgv = 0;

        public Search_Product_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
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
        }

        public Search_Product_Screen(Color colorBack, Color colorSecond, int consult)
        {
            InitializeComponent();
            this.BackColor = colorBack;
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

            if (consult == 1)
            {
                bt_Select.Visible = false;
                this.Text = "Consulta Estoque";
            }
        }

        #region checkBox
        private void cbx_Code_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Code.Checked)
            {
                cbxChecked = cbx_Code.Text;
                cbx_Name.Enabled = false;
                controlDgv = 0;
                tb_Filter1.Enabled = true;
                tb_Filter2.Enabled = true;
            }
            else
            {
                cbxChecked = "";
                cbx_Name.Enabled = true;
                dgv_Search.Rows.Clear();
                controlDgv = 0;
                tb_Filter1.Enabled = false;
                tb_Filter2.Enabled = false;
                tb_Filter1.Text = "";
                tb_Filter2.Text = "";
            }

        }

        private void cbx_Name_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_Name.Checked)
            {
                cbxChecked = cbx_Name.Text;
                cbx_Code.Enabled = false;
                controlDgv = 0;
                tb_Filter1.Enabled = true;
                tb_Filter2.Enabled = true;
            }
            else
            {
                cbxChecked = "";
                cbx_Code.Enabled = true;
                dgv_Search.Rows.Clear();
                controlDgv = 0;
                tb_Filter1.Enabled = false;
                tb_Filter2.Enabled = false;
                tb_Filter1.Text = "";
                tb_Filter2.Text = "";
            }
        }
        #endregion

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            dgv_Search.Rows.Clear();
            controlDgv = 0;
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
            dgv_Search.Rows.Clear();
            DataTable dataTable = new DataTable();

            dataTable = SelectDb.SelectProductAll(tb_Filter1.Text, tb_Filter2.Text, cbxChecked);

            foreach (DataRow linha in dataTable.Rows)
            {
                dgv_Search.Rows.Add(linha.ItemArray);
            }
            int countDgv_Search = dgv_Search.RowCount;
            lb_Found.Text = "Produtos Encontrados: " + countDgv_Search.ToString();

        }

        private void bt_Select_Click(object sender, EventArgs e)
        {
            if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
            {
                Product product = new Product();
                product.Code = int.Parse(dgv_Search.SelectedRows[0].Cells[4].Value.ToString());

                codeProduct = product.Code;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma linha ou cadastre um novo produto.");
            }
        }

        private void dgv_Search_Click(object sender, EventArgs e)
        {
            if (controlDgv == 0)
            {
                bt_Search_Click(sender, e);
                controlDgv = 1;
            }
        }

        private void Dgv_Search_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Search.SelectedRows.Count > 0)
            {
                Product product = new Product();
                product.Code = int.Parse(dgv_Search.SelectedRows[0].Cells[4].Value.ToString());

                Stock stock = new Stock();
                stock = SelectDb.SelectStock(product.Code);

                lb_Quant_Current.Text = stock.Quant.ToString();
            }
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {
            ExportExcel.ExportDataGridViewToExcel(dgv_Search);
        }
    }
}
