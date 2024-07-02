using StockController.Data;
using StockController.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StockController
{
    public partial class Product_Screen : Form
    {
        Color colorBack, colorSecond;

        // insert or update control variable
        string controlIG, strStatusCbx = "";

        public Product_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            menu_Product.BackColor = colorSecond;
            sp_Choices.BackColor = colorSecond;
            pb_Borda_Hori_1.BackColor = colorBack;
            pb_Borda_Hori_2.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;
            lb_Status_Product.BackColor = colorSecond;
            ts_Search_Code.MaxLength = 15;
            tb_Brand_Product.MaxLength = 10;
            tb_Category_Product.MaxLength = 10;
            tb_UnitM_Product.MaxLength = 10;
            tb_Value_Product.MaxLength = 20;
            tb_Cost_Product.MaxLength = 20;
            tb_Descri_Product.MaxLength = 200;
            tb_Name_Product.MaxLength = 50;

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
        private void cbx_Use_Batch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Use_Batch.Checked)
            {
                bt_Batches.Visible = true;
            }
            else
            {
                bt_Batches.Visible = false;
            }
        }
        #endregion

        private void bt_Search_Click(object sender, EventArgs e)
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
                    ts_Search_Code.Text = codeProductSearch.ToString();
                    ts_Search_Code_Leave(sender, e);
                }
            };

            search_Product_Screen.Show();

        }

        private void bt_New_Product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = SelectDb.SelectProduct(0, 2);
            product.Code = product.Code + 1;
            ts_Search_Code.Text = product.Code.ToString();
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
                Product product = new Product();
                product = SelectDb.SelectProduct(cod, 1);
                if (product.Id == 0)
                {
                    ts_Search_Code.Enabled = false;
                    bt_New_Product.Enabled = false;
                    bt_Search.Enabled = false;

                    tb_Name_Product.Enabled = true;

                    tb_Category_Product.Enabled = true;
                    bt_Search_Category.Enabled = true;

                    tb_Brand_Product.Enabled = true;
                    bt_Search_Brand.Enabled = true;

                    tb_UnitM_Product.Enabled = true;
                    bt_Search_UnitM.Enabled = true;

                    tb_Value_Product.Enabled = true;
                    tb_Cost_Product.Enabled = true;

                    cbx_Use_Batch.Enabled = true;
                    cbx_Active.Enabled = true;
                    cbx_Inactive.Enabled = true;

                    cbx_Active.Checked = true;

                    tb_Descri_Product.Enabled = true;

                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;

                    bt_Batches.Enabled = true;
                    bt_Barcode.Enabled = true;
                    bt_Supplier_Codes.Enabled = true;

                    controlIG = "Insert";
                }
                else
                {
                    ts_Search_Code.Enabled = false;
                    bt_New_Product.Enabled = false;
                    bt_Search.Enabled = false;

                    tb_Name_Product.Enabled = true;
                    tb_Name_Product.Text = product.Name;

                    tb_Category_Product.Enabled = true;
                    tb_Category_Product.Text = product.IdCategory.ToString();
                    bt_Search_Category.Enabled = true;

                    tb_Brand_Product.Enabled = true;
                    tb_Brand_Product.Text = product.IdBrand.ToString();
                    bt_Search_Brand.Enabled = true;

                    tb_UnitM_Product.Enabled = true;
                    tb_UnitM_Product.Text = product.IdUnitM.ToString();
                    bt_Search_UnitM.Enabled = true;

                    tb_Value_Product.Enabled = true;
                    tb_Value_Product.Text = product.Value.ToString();

                    tb_Cost_Product.Enabled = true;
                    tb_Cost_Product.Text = product.ReplacementCost.ToString();

                    cbx_Use_Batch.Enabled = true;


                    if (product.Status == "Ativo")
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

                    DataTable useBatch = SelectDb.SelectBatchAll(product.Code);
                    if (useBatch.Rows.Count > 0)
                    {
                        cbx_Use_Batch.Checked = true;
                    }

                    tb_Descri_Product.Enabled = true;
                    tb_Descri_Product.Text = product.Description;

                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;

                    bt_Batches.Enabled = true;
                    bt_Barcode.Enabled = true;
                    bt_Supplier_Codes.Enabled = true;

                    tb_Category_Product_Leave(sender, e);
                    tb_Brand_Product_Leave(sender, e);
                    tb_UnitM_Product_Leave(sender, e);

                    controlIG = "Update";
                }
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Name_Product.Text))
            {
                MessageBox.Show("Preencha o campo Nome", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(tb_Descri_Product.Text))
                {
                    MessageBox.Show("Preencha o campo Descrição", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    if (string.IsNullOrEmpty(tb_Value_Product.Text))
                    {
                        MessageBox.Show("Preencha o campo Valor", "Aviso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(tb_Cost_Product.Text))
                        {
                            MessageBox.Show("Preencha o campo Custo Reposição", "Aviso", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(tb_UnitM_Product.Text))
                            {
                                MessageBox.Show("Preencha o campo Unidade", "Aviso", MessageBoxButtons.OK);
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(tb_Brand_Product.Text))
                                {
                                    MessageBox.Show("Preencha o campo Marca", "Aviso", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(tb_Category_Product.Text))
                                    {
                                        MessageBox.Show("Preencha o campo Categoria", "Aviso", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        Product product = new Product();
                                        product = SelectDb.SelectProduct(product.Code, 1);
                                        product.Code = int.Parse(ts_Search_Code.Text);
                                        product.Name = tb_Name_Product.Text;
                                        product.Value = float.Parse(tb_Value_Product.Text);
                                        product.Description = tb_Descri_Product.Text;
                                        product.ReplacementCost = float.Parse(tb_Cost_Product.Text);
                                        product.IdCategory = int.Parse(tb_Category_Product.Text);
                                        product.IdBrand = int.Parse(tb_Brand_Product.Text);
                                        product.IdUnitM = int.Parse(tb_UnitM_Product.Text);
                                        product.Status = strStatusCbx;

                                        string strCheckName = product.Name.Replace(" ", "").Replace("\r\n", "");
                                        string strCheckDesc = product.Description.Replace(" ", "").Replace("\r\n", "");
                                        string strCheckStatus = product.Status.Replace(" ", "").Replace("\r\n", "");

                                        if (controlIG == "Insert")
                                        {
                                            if (strCheckDesc == "")
                                            {
                                                MessageBox.Show("Preencha o campo Descrição.", "Aviso", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                InsertDb.InsertProduct(product);

                                                Stock stock = new Stock();
                                                stock.IdProduct = product.Code;
                                                stock.Quant = 0;
                                                InsertDb.InsertStock(stock);
                                                bt_Cancel_Click(sender, e);
                                                MessageBox.Show("Produto cadastrado com Sucesso", "Aviso", MessageBoxButtons.OK);
                                            }
                                        }
                                        else if (controlIG == "Update")
                                        {
                                            if (strCheckDesc == "")
                                            {
                                                MessageBox.Show("Preencha o campo Descrição.", "Aviso", MessageBoxButtons.OK);
                                            }
                                            else
                                            {
                                                UpdateDb.UpdateProduct(product);
                                                bt_Cancel_Click(sender, e);
                                                MessageBox.Show("Produto atualizado com Sucesso", "Aviso", MessageBoxButtons.OK);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (controlIG == "Insert")
            {
                MessageBox.Show("Produto não cadastrado ainda\nCancele o processo se precisar.", "AVISO", MessageBoxButtons.OK);
            }
            else if (controlIG == "Update")
            {
                Product product = new Product();
                product.Code = int.Parse(ts_Search_Code.Text);

                DeleteDb.DeleteProduct(product);
                Stock stock = new Stock();
                stock.IdProduct = product.Code;
                DeleteDb.DeleteStock(stock);
                MessageBox.Show("Produto excluído com sucesso");
                bt_Cancel_Click(sender, e);
            }
        }

        private void tb_Category_Product_Leave(object sender, EventArgs e)
        {
            string txtIdCategory = tb_Category_Product.Text;
            if (string.IsNullOrEmpty(txtIdCategory))
            {
                txtIdCategory = string.Empty;
                tb_Viewer_Category.Text = txtIdCategory;
            }
            else
            {
                int idCategory = Convert.ToInt32(txtIdCategory);
                Category category = new Category();
                category = SelectDb.SelectCategory(idCategory, 1);

                if (category.Id == 0)
                {
                    MessageBox.Show("Categoria não encontrada.");
                    tb_Category_Product.Text = "";
                    tb_Viewer_Category.Text = "";
                }
                else
                {
                    tb_Viewer_Category.Text = category.Description;
                }
            }

        }

        private void bt_Search_Category_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "Category", 1);

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idCategorySearch = search_Screen.idObj;
                Category category = new Category();
                category = SelectDb.SelectCategory(idCategorySearch, 1);
                tb_Viewer_Category.Text = category.Description;
                tb_Category_Product.Text = category.Id.ToString();
            };

            search_Screen.Show();
        }

        private void tb_Brand_Product_Leave(object sender, EventArgs e)
        {
            string txtidBrand = tb_Brand_Product.Text;
            if (string.IsNullOrEmpty(txtidBrand))
            {
                txtidBrand = string.Empty;
                tb_Viewer_Brand.Text = string.Empty;
            }
            else
            {
                int idBrand = Convert.ToInt32(txtidBrand);
                Brand brand = new Brand();
                brand = SelectDb.SelectBrand(idBrand, 1);
                if (brand.Id == 0)
                {
                    MessageBox.Show("Marca não encontrada.");
                    tb_Brand_Product.Text = "";
                    tb_Viewer_Brand.Text = "";
                }
                else
                {
                    tb_Viewer_Brand.Text = brand.Description;
                }
            }
        }

        private void bt_Search_Brand_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "Brand", 1);

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idBrandSearch = search_Screen.idObj;
                Brand brand = new Brand();
                brand = SelectDb.SelectBrand(idBrandSearch, 1);
                tb_Viewer_Brand.Text = brand.Description;
                tb_Brand_Product.Text = brand.Id.ToString();
            };

            search_Screen.Show();
        }

        private void tb_UnitM_Product_Leave(object sender, EventArgs e)
        {
            string txtIdUnit = tb_UnitM_Product.Text;
            if (string.IsNullOrEmpty(txtIdUnit))
            {
                txtIdUnit = string.Empty;
                tb_Viewer_UnitM.Text = string.Empty;
            }
            else
            {
                int idUnitM = Convert.ToInt32(txtIdUnit);
                UnitM unitM = new UnitM();
                unitM = SelectDb.SelectUnitM(idUnitM, 1);
                if (unitM.Id == 0)
                {
                    MessageBox.Show("Unidade de medida não encontrada.");
                    tb_UnitM_Product.Text = "";
                    tb_Viewer_UnitM.Text = "";
                }
                else
                {
                    tb_Viewer_UnitM.Text = unitM.Name;
                }
            }
        }

        private void bt_Search_UnitM_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "UnitM", 1);

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idUnitMSearch = search_Screen.idObj;
                UnitM unitM = new UnitM();
                unitM = SelectDb.SelectUnitM(idUnitMSearch, 1);
                tb_Viewer_UnitM.Text = unitM.Name;
                tb_UnitM_Product.Text = unitM.Id.ToString();
            };

            search_Screen.Show();
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
            ts_Search_Code.Enabled = true;
            bt_New_Product.Enabled = true;
            bt_Search.Enabled = true;

            tb_Name_Product.Enabled = false;
            tb_Name_Product.Text = "";

            tb_Category_Product.Enabled = false;
            tb_Category_Product.Text = "";
            tb_Viewer_Category.Text = "";
            bt_Search_Category.Enabled = false;

            tb_Brand_Product.Enabled = false;
            tb_Brand_Product.Text = "";
            tb_Viewer_Brand.Text = "";
            bt_Search_Brand.Enabled = false;

            tb_UnitM_Product.Enabled = false;
            tb_UnitM_Product.Text = "";
            tb_Viewer_UnitM.Text = "";
            bt_Search_UnitM.Enabled = false;

            tb_UnitM_Product.Enabled = false;
            tb_UnitM_Product.Text = "";
            tb_Viewer_UnitM.Text = "";
            bt_Search_UnitM.Enabled = false;

            tb_Value_Product.Enabled = false;
            tb_Value_Product.Text = "";
            tb_Cost_Product.Enabled = false;
            tb_Cost_Product.Text = "";

            cbx_Use_Batch.Checked = false;
            cbx_Active.Checked = false;
            cbx_Inactive.Checked = false;

            cbx_Use_Batch.Enabled = false;
            cbx_Active.Enabled = false;
            cbx_Inactive.Enabled = false;

            tb_Descri_Product.Enabled = false;
            tb_Descri_Product.Text = "";

            bt_Save.Enabled = false;
            bt_Cancel.Enabled = false;
            bt_Delete.Enabled = false;

            bt_Batches.Enabled = false;
            bt_Barcode.Enabled = false;
            bt_Supplier_Codes.Enabled = false;

            controlIG = "";
        }

        private void bt_Batches_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Additional_Product_Screen additional_Product_Screen = new Additional_Product_Screen(colorBack, colorSecond, "Batch", Convert.ToInt32(ts_Search_Code.Text));

            // Adds an event handler for the FormClosed event
            additional_Product_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            additional_Product_Screen.Show();
        }

        private void bt_Supplier_Codes_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Additional_Product_Screen additional_Product_Screen = new Additional_Product_Screen(colorBack, colorSecond, "Supplier", Convert.ToInt32(ts_Search_Code.Text));

            // Adds an event handler for the FormClosed event
            additional_Product_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            additional_Product_Screen.Show();
        }

        private void bt_Barcode_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Additional_Product_Screen additional_Product_Screen = new Additional_Product_Screen(colorBack, colorSecond, "Barcode", Convert.ToInt32(ts_Search_Code.Text));

            // Adds an event handler for the FormClosed event
            additional_Product_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            additional_Product_Screen.Show();
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
