using StockController.Data;
using StockController.Models;
using StockController.RegistersScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockController
{
    public partial class Home_Screen : Form
    {

        Color colorBack = Color.FromArgb(243, 203, 148);
        Color colorSecond = Color.FromArgb(225, 159, 69);

        Boolean boolLoad = true;

        public Home_Screen()
        {
            InitializeComponent();

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

        private void Home_Screen_Load(object sender, EventArgs e)
        {

            ColorSave colorSave = new ColorSave();
            colorSave = SelectDb.SelectColorSave(1);
            if (colorSave.Id == 0)
            {
                colorSave.Id = 1;
                colorSave.ColorBackCor = colorBack;
                colorSave.ColorSecondCor = colorSecond;
                colorSave.ColorBack = colorSave.ColorBackCor.ToString();
                colorSave.ColorSecond = colorSave.ColorSecondCor.ToString();

                InsertDb.InsertColorSave(colorSave);
            }
            else
            {                
                if (boolLoad)
                {
                    colorBack = colorSave.ColorBackCor;
                    colorSecond = colorSave.ColorSecondCor;
                }
                else
                {
                    colorSave.ColorBackCor = colorBack;
                    colorSave.ColorSecondCor = colorSecond;
                    colorSave.ColorBack = colorSave.ColorBackCor.ToString();
                    colorSave.ColorSecond = colorSave.ColorSecondCor.ToString();

                    UpdateDb.UpdateColorSave(colorSave);
                }
            }

            this.BackColor = colorBack;
            menu_Choices.BackColor = colorSecond;
            bt_Color.BackColor = colorSecond;
            bt_Color_Second.BackColor = colorSecond;    

        }

        private void bt_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = colorBack;
            colorDialog.FullOpen = true;


            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorBack = colorDialog.Color;
                boolLoad = false;
                Home_Screen_Load(sender, e);
            }
        }

        private void bt_Color_Second_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = colorSecond;
            colorDialog.FullOpen = true;
          
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorSecond = colorDialog.Color;
                boolLoad = false;
                Home_Screen_Load(sender, e);
            }
        }

        private void ts_Cad_Product_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Product_Screen screen_Product = new Product_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            screen_Product.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            screen_Product.Show();
        }

        private void ts_Cad_Category_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Category_Screen category_Screen = new Category_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            category_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            category_Screen.Show();
        }

        private void ts_Cad_Brand_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Brand_Screen brand_Screen = new Brand_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            brand_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            brand_Screen.Show();
        }

        private void ts_Cad_Unit_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UnitM_Screen unitM_Screen = new UnitM_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            unitM_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            unitM_Screen.Show();
        }

        private void ts_Cad_Supplier_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Supplier_Screen supplier_Screen = new Supplier_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            supplier_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            supplier_Screen.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            User_Screen user_Screen = new User_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            user_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            user_Screen.Show();
        }

        private void nventárioCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Inventory_Screen inventory_Screen = new Inventory_Screen(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            inventory_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            inventory_Screen.Show();
        }

        private void estoqueProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Product_Screen search_Product_Screen = new Search_Product_Screen(colorBack, colorSecond, 1);

            // Adds an event handler for the FormClosed event
            search_Product_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            search_Product_Screen.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Sales_Screen sales_Screen = new Sales_Screen(colorBack, colorSecond, "Purchases");

            // Adds an event handler for the FormClosed event
            sales_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            sales_Screen.Show();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Sales_Screen sales_Screen = new Sales_Screen(colorBack, colorSecond, "Sales");

            // Adds an event handler for the FormClosed event
            sales_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            sales_Screen.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Sales search_Sales = new Search_Sales(colorBack, colorSecond, "P");

            // Adds an event handler for the FormClosed event
            search_Sales.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            search_Sales.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Sales search_Sales = new Search_Sales(colorBack, colorSecond, "S");

            // Adds an event handler for the FormClosed event
            search_Sales.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            search_Sales.Show();
        }

        private void estatísticasDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Sales_Relat sales_Relat = new Sales_Relat(colorBack, colorSecond);

            // Adds an event handler for the FormClosed event
            sales_Relat.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
            };

            sales_Relat.Show();
        }
    }
}
