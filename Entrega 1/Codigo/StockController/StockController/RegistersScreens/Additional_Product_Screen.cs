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
    public partial class Additional_Product_Screen : Form
    {
        string controlForm = "";
        int idProductCurrent = 0;

        Color colorBack, colorSecond;
        public Additional_Product_Screen(Color colorBack, Color colorSecond, string controlForm, int idProductCurrent)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.controlForm = controlForm;
            sp_Choices.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;
            lb_Add.BackColor = colorSecond;
            lb_Delete.BackColor = colorSecond;
            this.idProductCurrent = idProductCurrent;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;

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

            if (controlForm == "Barcode")
            {
                this.Text = this.Text + "Códigos de barras";
                lb_Code1.Text = "Código Gtin:";
                lb_Code2.Text = "Código 128:";
                lb_Code3.Visible = false;
                lb_Code4.Visible = false;
                dtp_Date1.Visible = false;
                dtp_Date2.Visible = false;
                bt_Search_Supplier.Visible = false;

                dgv_Search.Location = new System.Drawing.Point(12, 97);
                dgv_Search.Size = new System.Drawing.Size(480, 238);

                dgv_Search.Columns["Cod2"].HeaderText = "GtinEan";
                dgv_Search.Columns["Cod3"].HeaderText = "Código 128";

                dgv_Search.Columns["Cod1"].Visible = false;
                dgv_Search.Columns["Cod3"].Visible = true;

            }
            else if (controlForm == "Batch")
            {
                this.Text = this.Text + "Lotes";
                lb_Code1.Text = "Número:";
                lb_Code2.Text = "Observação:";
                lb_Code3.Text = "Data Fabricação:";
                lb_Code4.Text = "Data Vencimento:";
                bt_Search_Supplier.Visible = false;

                dgv_Search.Columns["Cod2"].HeaderText = "Data de Vencimento";
                dgv_Search.Columns["Cod3"].HeaderText = "Data de Fabricação";
                dgv_Search.Columns["Cod4"].HeaderText = "Número";
                dgv_Search.Columns["Cod5"].HeaderText = "Observação";
                dgv_Search.Columns["Cod1"].Visible = false;
                dgv_Search.Columns["Cod3"].Visible = true;
                dgv_Search.Columns["Cod4"].Visible = true;
                dgv_Search.Columns["Cod5"].Visible = true;

            }
            else if (controlForm == "Supplier")
            {
                this.Text = this.Text + "Código de Fornecedor";
                lb_Code1.Text = "Fornecedor:";
                lb_Code2.Text = "Código:";
                lb_Code3.Visible = false;
                lb_Code4.Visible = false;
                dtp_Date1.Visible = false;
                dtp_Date2.Visible = false;
                bt_Search_Supplier.Visible = true;

                dgv_Search.Location = new System.Drawing.Point(12, 97);
                dgv_Search.Size = new System.Drawing.Size(480, 238);

                dgv_Search.Columns["Cod2"].HeaderText = "Fornecedor";
                dgv_Search.Columns["Cod3"].HeaderText = "Código";

                dgv_Search.Columns["Cod1"].Visible = false;
                dgv_Search.Columns["Cod3"].Visible = true;
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Search_Supplier_Click(object sender, EventArgs e)
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
                    tb1.Text = supplier.Id.ToString();
                }
            };

            search_Screen.Show();
        }

        private void Additional_Product_Screen_Load(object sender, EventArgs e)
        {
            attGrid();
        }

        private void bt_Add_Obj_Click(object sender, EventArgs e)
        {
            if (controlForm == "Barcode")
            {
                Barcode barcode = new Barcode();
                barcode = SelectDb.SelectBarcode(0, 2);
                int idCurrent = barcode.Id + 1;
                barcode.Id = idCurrent;

                barcode.IdProduct = idProductCurrent;
                barcode.GtinEan = tb1.Text;
                barcode.Bar128 = tb2.Text;

                InsertDb.InsertBarcode(barcode);

                tb1.Text = "";
                tb2.Text = "";
                attGrid();
            }
            else if (controlForm == "Batch")
            {
                Batch batch = new Batch();
                batch = SelectDb.SelectBatch(0, 2);
                int idCurrent = batch.Id + 1;
                batch.Id = idCurrent;

                batch.IdProduct = idProductCurrent;
                batch.FabricationDate = dtp_Date1.Value;
                batch.DueDate = dtp_Date2.Value;

                if (tb1.Text == "")
                {
                    batch.Number = 0;
                }
                else
                {
                    batch.Number = Convert.ToInt32(tb1.Text);
                }
                batch.Obsevation = tb2.Text;

                InsertDb.InsertBatch(batch);

                tb1.Text = "";
                tb2.Text = "";
                dtp_Date1.Value = DateTime.Today;
                dtp_Date2.Value = DateTime.Today;
                attGrid();
            }
            else if (controlForm == "Supplier")
            {
                CodesSuppliers codesSuppliers = new CodesSuppliers();
                codesSuppliers = SelectDb.SelectCodesSuppliers(0, 2);
                int idCurrent = codesSuppliers.Id + 1;
                codesSuppliers.Id = idCurrent;

                codesSuppliers.IdProduct = idProductCurrent;
                codesSuppliers.IdSupplier = Convert.ToInt32(tb1.Text);
                codesSuppliers.Code = tb2.Text;

                InsertDb.InsertCodesSuppliers(codesSuppliers);

                tb1.Text = "";
                tb2.Text = "";
                attGrid();
            }
        }

        private void bt_Less_Obj_Click(object sender, EventArgs e)
        {
            if (controlForm == "Barcode")
            {
                int idObj = 0;
                Barcode barcode = new Barcode();

                if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                {
                    idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.");
                }
                barcode.Id = idObj;

                DeleteDb.DeleteBarcode(barcode);
                attGrid();
            }
            else if (controlForm == "Batch")
            {
                int idObj = 0;
                Batch batch = new Batch();
                if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                {
                    idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.");
                }
                batch.Id = idObj;
                DeleteDb.DeleteBatch(batch);
                attGrid();
            }
            else if (controlForm == "Supplier")
            {
                int idObj = 0;
                CodesSuppliers codesSuppliers = new CodesSuppliers();
                if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                {
                    idObj = int.Parse(dgv_Search.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.");
                }
                codesSuppliers.Id = idObj;
                DeleteDb.DeleteCodesSuppliers(codesSuppliers);
                attGrid();
            }
        }

        private void attGrid()
        {
            if (controlForm == "Barcode")
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectBarcodeAll();
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
            }
            else if (controlForm == "Batch")
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectBatchAll();
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
            }
            else if (controlForm == "Supplier")
            {
                dgv_Search.Rows.Clear();
                DataTable dataTable = new DataTable();
                dataTable = SelectDb.SelectCodesSuppliersAll();
                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
            }
        }
    }
}
