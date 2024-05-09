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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StockController
{
    public partial class Sales_Screen : Form
    {
        Color colorBack, colorSecond;
        string option = "";

        Sales sales = new Sales();
        Purchases purchases = new Purchases();

        Stock stock = new Stock();
        MovsStock movsStock = new MovsStock();

        Product product = new Product();

        Supplier supplier = new Supplier();

        public Sales_Screen(Color colorBack, Color colorSecond, string option)
        {
            InitializeComponent();
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            this.BackColor = colorBack;
            pb_Borda_Vert_1.BackColor = colorBack;
            sp_Choices.BackColor = colorSecond;
            lb_Add.BackColor = colorSecond;
            lb_Delete.BackColor = colorSecond;
            this.option = option;

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

            if (option == "Sales")
            {
                this.Text = "Vendas";
                lb_txt1.Text = "Cliente: ";
                bt_Search_Supplier.Visible = false;
            }
            else if (option == "Purchases")
            {
                this.Text = "Compras";
                lb_txt1.Text = "Fornecedor:";
                tb_txt1.Enabled = false;
            }
        }

        private void Sales_Screen_Load(object sender, EventArgs e)
        {
            if (option == "Sales")
            {
                sales = new Sales();
                purchases = new Purchases();
                stock = new Stock();
                movsStock = new MovsStock();
                product = new Product();
                supplier = new Supplier();

                sales = SelectDb.SelectSales(0, 2);
                sales.Id = sales.Id + 1;
                sales.Cliente = "";
                sales.Value = 0;
                InsertDb.InsertSales(sales);
            }
            else if (option == "Purchases")
            {
                sales = new Sales();
                purchases = new Purchases();
                stock = new Stock();
                movsStock = new MovsStock();
                product = new Product();
                supplier = new Supplier();

                purchases = SelectDb.SelectPurchases(0, 2);
                purchases.Id = purchases.Id + 1;
                purchases.IdSupplier = 0;
                purchases.Value = 0;
                InsertDb.InsertPurchases(purchases);
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (option == "Sales")
            {
                sales.Cliente = tb_txt1.Text;
                string strValue = tb_Tot_Value.Text;
                sales.Value = float.Parse(strValue);
                UpdateDb.UpdateSales(sales);

                bt_Cancel_Click(sender, e);
            }
            else if (option == "Purchases")
            {
                purchases.IdSupplier = supplier.Id;
                string strValue = tb_Tot_Value.Text;
                purchases.Value = float.Parse(strValue);
                UpdateDb.UpdatePurchases(purchases);

                bt_Cancel_Click(sender, e);
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            tb_txt1.Text = "";
            tb_Product.Text = "";
            tb_Viewer_Produto.Text = "";
            tb_Quant.Text = "";

            dgv_Search.Rows.Clear();

            tb_Tot_Value.Text = "";
            if (option == "Sales")
            {
                if (sales.Value == 0)
                {
                    DeleteDb.DeleteSales(sales);
                }
            }
            else if (option == "Purchases")
            {
                if (purchases.Value == 0)
                {
                    DeleteDb.DeletePurchases(purchases);
                }
            }
            Sales_Screen_Load(sender, e);
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
                product = SelectDb.SelectProduct(codeProductSearch, 1);
                if (product.Code > 0)
                {
                    tb_Product.Text = codeProductSearch.ToString();
                    tb_Viewer_Produto.Text = product.Value.ToString();

                    stock = SelectDb.SelectStock(product.Code);
                }
            };

            search_Product_Screen.Show();
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
                supplier = SelectDb.SelectSupplier(idSupplierSearch, 1);
                if (supplier.Id != 0)
                {
                    tb_txt1.Text = supplier.Name;
                }
            };

            search_Screen.Show();
        }

        private void bt_Add_Obj_Click(object sender, EventArgs e)
        {
            float quant = float.Parse(tb_Quant.Text);
            if (product.Id > 0)
            {
                if (option == "Sales")
                {
                    if (quant <= stock.Quant)
                    {
                        tb_Product.Text = "";
                        tb_Viewer_Produto.Text = "";
                        tb_Quant.Text = "";

                        stock.Quant = stock.Quant - quant;

                        UpdateDb.UpdateStock(stock);

                        MovsStock movsStockAux = new MovsStock();

                        movsStockAux.IdStock = stock.Id;
                        movsStockAux.IdOrigin = sales.Id;
                        movsStockAux.TypeMov = "Saida";
                        movsStockAux.QuantMov = quant;

                        InsertDb.InsertMovsStock(movsStockAux);

                        if (tb_Tot_Value.Text == null || tb_Tot_Value.Text == "")
                        {
                            string strValue = "0";
                            float valueTot = float.Parse(strValue);
                            valueTot += product.Value * quant;

                            tb_Tot_Value.Text = valueTot.ToString();
                        }
                        else
                        {
                            string strValue = tb_Tot_Value.Text;
                            float valueTot = float.Parse(strValue);
                            valueTot += product.Value * quant;

                            tb_Tot_Value.Text = valueTot.ToString();
                        }


                        stock = new Stock();
                        movsStock = new MovsStock();
                        product = new Product();

                        AttDgv();
                    }
                    else
                    {
                        MessageBox.Show("Quantidade digitada maior que a do Estoque", "Aviso", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    tb_Product.Text = "";
                    tb_Viewer_Produto.Text = "";
                    tb_Quant.Text = "";

                    stock.Quant = stock.Quant + quant;

                    UpdateDb.UpdateStock(stock);

                    MovsStock movsStockAux = new MovsStock();

                    movsStockAux.IdStock = stock.Id;
                    movsStockAux.IdOrigin = purchases.Id;
                    movsStockAux.TypeMov = "Entrada";
                    movsStockAux.QuantMov = quant;

                    InsertDb.InsertMovsStock(movsStockAux);

                    if (tb_Tot_Value.Text == null || tb_Tot_Value.Text == "")
                    {
                        string strValue = "0";
                        float valueTot = float.Parse(strValue);
                        valueTot += product.Value * quant;

                        tb_Tot_Value.Text = valueTot.ToString();
                    }
                    else
                    {
                        string strValue = tb_Tot_Value.Text;
                        float valueTot = float.Parse(strValue);
                        valueTot += product.Value * quant;

                        tb_Tot_Value.Text = valueTot.ToString();
                    }

                    stock = new Stock();
                    movsStock = new MovsStock();
                    product = new Product();

                    AttDgv();
                }
            }
            else
            {
                tb_Product.Text = "";
                tb_Viewer_Produto.Text = "";
                tb_Quant.Text = "";
                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK);
            }


        }

        private void tb_Product_Leave(object sender, EventArgs e)
        {
            string strCode = tb_Product.Text;
            product = SelectDb.SelectProduct(Convert.ToInt32(strCode), 1);
            if (product.Code > 0)
            {
                tb_Viewer_Produto.Text = product.Value.ToString();

                stock = SelectDb.SelectStock(product.Code);
            }
        }

        private void Sales_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (option == "Sales")
            {
                if (sales.Value == 0)
                {
                    DeleteDb.DeleteSales(sales);
                }
            }
            else if (option == "Purchases")
            {
                if (purchases.Value == 0)
                {
                    DeleteDb.DeletePurchases(purchases);
                }
            }
        }

        private void bt_Less_Obj_Click(object sender, EventArgs e)
        {
            if (option == "Sales")
            {
                if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                {
                    Product product1 = new Product();
                    product1.Code = int.Parse(dgv_Search.SelectedRows[0].Cells[4].Value.ToString());

                    product1 = SelectDb.SelectProduct(product1.Code, 1);

                    stock = SelectDb.SelectStock(product1.Code);

                    MovsStock movsStockAux = new MovsStock();

                    movsStockAux.IdOrigin = sales.Id;
                    movsStockAux.IdStock = stock.Id;

                    movsStockAux = SelectDb.SelectMovsStock(movsStockAux);

                    if (tb_Tot_Value.Text == null || tb_Tot_Value.Text == "")
                    {
                        string strValue = "0";
                        float valueTot = float.Parse(strValue);
                        valueTot = valueTot - product1.Value * movsStockAux.QuantMov;

                        tb_Tot_Value.Text = valueTot.ToString();
                    }
                    else
                    {
                        string strValue = tb_Tot_Value.Text;
                        float valueTot = float.Parse(strValue);
                        valueTot = valueTot - product1.Value * movsStockAux.QuantMov;

                        tb_Tot_Value.Text = valueTot.ToString();
                    }

                    DeleteDb.DeleteMovsStock(movsStockAux);
                    AttDgv();
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.");
                }
            }
            else
            {
                if (dgv_Search.SelectedRows.Count == 1 && dgv_Search.SelectedRows[0].Cells[0].Value != null)
                {
                    Product product1 = new Product();
                    product1.Code = int.Parse(dgv_Search.SelectedRows[0].Cells[4].Value.ToString());

                    product1 = SelectDb.SelectProduct(product1.Code, 1);

                    stock = SelectDb.SelectStock(product1.Code);

                    MovsStock movsStockAux = new MovsStock();

                    movsStockAux.IdOrigin = purchases.Id;
                    movsStockAux.IdStock = stock.Id;

                    movsStockAux = SelectDb.SelectMovsStock(movsStockAux);

                    if (tb_Tot_Value.Text == null || tb_Tot_Value.Text == "")
                    {
                        string strValue = "0";
                        float valueTot = float.Parse(strValue);
                        valueTot = valueTot - product1.Value * movsStockAux.QuantMov;

                        tb_Tot_Value.Text = valueTot.ToString();
                    }
                    else
                    {
                        string strValue = tb_Tot_Value.Text;
                        float valueTot = float.Parse(strValue);
                        valueTot = valueTot - product1.Value * movsStockAux.QuantMov;

                        tb_Tot_Value.Text = valueTot.ToString();
                    }

                    DeleteDb.DeleteMovsStock(movsStockAux);
                    AttDgv();
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.");
                }
            }
        }

        public void AttDgv()
        {
            if (option == "Sales")
            {
                DataTable dataTable = new DataTable();
                dgv_Search.Rows.Clear();
                dataTable = SelectDb.SelectProductAllCode(sales.Id, "Saida");

                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
            }
            else
            {
                DataTable dataTable = new DataTable();
                dgv_Search.Rows.Clear();
                dataTable = SelectDb.SelectProductAllCode(purchases.Id, "Entrada");

                foreach (DataRow linha in dataTable.Rows)
                {
                    dgv_Search.Rows.Add(linha.ItemArray);
                }
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
