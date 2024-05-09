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
using System.Xml;

namespace StockController
{
    public partial class Search_Screen : Form
    {
        public int idObj { get; set; }

        string cbxChecked, strTypeSearch;
        int controlSearch = 0, controlDgv = 0;

        public Search_Screen(Color colorBack, Color colorSecond, string strTypeSearch)
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
            dgv_Supplier.Visible = false;
            dgv_UnitMs.BackgroundColor = colorBack;

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

            if (strTypeSearch == "Brand")
            {
                this.Text = this.Text + " Marca";
                lb_Found.Text = "Marcas Encontradas: 0";
                cbx_Name.Text = "Descrição";
            }
            else if (strTypeSearch == "Category")
            {
                this.Text = this.Text + " Categoria";
                lb_Found.Text = "Categorias Encontradas: 0";
                cbx_Name.Text = "Descrição";
                dgv_Search.Columns["MovStock"].Visible = true;
            }
        }
        public Search_Screen(Color colorBack, Color colorSecond, string strTypeSearch, int controlSearch)
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
            dgv_Supplier.Visible = false;
            dgv_UnitMs.BackgroundColor = colorBack;

            this.controlSearch = controlSearch;

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

            if (strTypeSearch == "Brand")
            {
                this.Text = this.Text + " Marca";
                lb_Found.Text = "Marcas Encontradas: 0";
                cbx_Name.Text = "Descrição";
            }
            else if (strTypeSearch == "Category")
            {
                this.Text = this.Text + " Categoria";
                lb_Found.Text = "Categorias Encontradas: 0";
                cbx_Name.Text = "Descrição";
                dgv_Search.Columns["MovStock"].Visible = true;
            }
            else if (strTypeSearch == "Supplier")
            {
                this.Text = this.Text + " Fornecedor";
                lb_Found.Text = "Fornecedores Encontrados: 0";
                cbx_Name.Text = "Nome";
                dgv_Search.Visible = false;
                dgv_Supplier.Visible = true;
            }
            else if (strTypeSearch == "UnitM")
            {
                this.Text = this.Text + " Unidade de Medida";
                lb_Found.Text = "Unidades de Medida Encontradas: 0";
                cbx_Name.Text = "Nome";
                dgv_Search.Visible = false;
                dgv_Supplier.Visible = false;
                dgv_UnitMs.Visible = true;
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
                dgv_Supplier.Rows.Clear();
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
                dgv_Supplier.Rows.Clear();
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
            dgv_Supplier.Rows.Clear();
            dgv_UnitMs.Rows.Clear();
            controlDgv = 0;
            tb_Filter1.Text = "";
            tb_Filter2.Text = "";
        }

        private void dgv_Search_Click(object sender, EventArgs e)
        {
            if (controlDgv == 0)
            {
                bt_Search_Click(sender, e);
                controlDgv = 1;
            }
        }

        private void bt_Select_Click(object sender, EventArgs e)
        {
            if (controlSearch == 0)
            {
                if (strTypeSearch == "Brand")
                {
                    if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                    {
                        idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma linha ou cadastre uma nova marca.");
                    }
                }
                else if (strTypeSearch == "Category")
                {
                    if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                    {
                        idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma linha ou cadastre uma nova categoria.");
                    }
                }
            }
            else
            {
                if (strTypeSearch == "Brand")
                {
                    if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                    {
                        idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());

                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma linha ou cadastre uma nova marca.");
                    }
                }
                else if (strTypeSearch == "Category")
                {
                    if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                    {
                        idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma linha ou cadastre uma nova categoria.");
                    }
                }
                else if (strTypeSearch == "Supplier")
                {
                    if (dgv_Supplier.SelectedRows.Count == 1 && dgv_Supplier.SelectedRows[0].Cells[0].Value != null)
                    {
                        idObj = int.Parse(dgv_Supplier.SelectedRows[0].Cells[0].Value.ToString());

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma linha ou cadastre um novo Fornecedor.");
                    }
                }
                else if (strTypeSearch == "UnitM")
                {
                    if (dgv_UnitMs.SelectedRows.Count == 1 && dgv_UnitMs.SelectedRows[0].Cells[0].Value != null)
                    {
                        idObj = int.Parse(dgv_UnitMs.SelectedRows[0].Cells[0].Value.ToString());

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma linha ou cadastre uma nova Unidade de medida.");
                    }
                }
            }
            
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
            if (strTypeSearch == "Brand")
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectBrandAll(tb_Filter1.Text, tb_Filter2.Text, cbxChecked);
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
                int countDgv_Search = dgv_Search.RowCount;
                lb_Found.Text = "Marcas Encontradas: " + countDgv_Search.ToString();
            }
            else if (strTypeSearch == "Category")
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectCategoryAll(tb_Filter1.Text, tb_Filter2.Text, cbxChecked);
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
                int countDgv_Search = dgv_Search.RowCount;
                lb_Found.Text = "Categorias Encontradas: " + countDgv_Search.ToString();
            }
            else if (strTypeSearch == "Supplier")
            {
                dgv_Supplier.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectSupplierAll(tb_Filter1.Text, tb_Filter2.Text, cbxChecked);
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Supplier.Rows.Add(linha.ItemArray);
                }
                int countDgv_Search = dgv_Supplier.RowCount;
                lb_Found.Text = "Fornecedores Encontradas: " + countDgv_Search.ToString();
            }
            else if (strTypeSearch == "UnitM")
            {
                dgv_UnitMs.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectUnitMsAll(tb_Filter1.Text, tb_Filter2.Text, cbxChecked);
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_UnitMs.Rows.Add(linha.ItemArray);
                }
                int countDgv_Search = dgv_UnitMs.RowCount;
                lb_Found.Text = "Unidades de Medida Encontradas: " + countDgv_Search.ToString();
            }
        }
    }
}
