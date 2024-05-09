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
    public partial class Login : Form
    {
        Color colorBack = Color.FromArgb(243, 203, 148);
        Color colorSecond = Color.FromArgb(225, 159, 69);
        public Login()
        {
            InitializeComponent();

            this.BackColor = colorBack;
            bt_Enter.BackColor = colorSecond;

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

        private void bt_Enter_Click(object sender, EventArgs e)
        {

            User user = new User();
            user = SelectDb.selectUser(tb_Name.Text);
            if (user.Id > 0)
            {
                if (user.Password == tb_Pass.Text)
                {  
                    this.Visible = false;
                    Home_Screen home_Screen = new Home_Screen();

                    // Adds an event handler for the FormClosed event
                    home_Screen.FormClosed += (s, args) =>
                    {
                        // This block of code will be executed when the window is closed
                        this.Close();
                    };

                    home_Screen.Show();
                }
                else
                {
                    MessageBox.Show("Senha incorreta.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CreateDb.CreateDataBase();
            CreateDb.CreateProductsTable();
            CreateDb.CreateCategoriesTable();
            CreateDb.CreateBatchesTable();
            CreateDb.CreateBrandsTable();
            CreateDb.CreateUnitMsTable();
            CreateDb.CreateSuppliersTable();
            CreateDb.CreateBarcodesTable();
            CreateDb.CreateColorsTable();
            CreateDb.CreateUsersTable();
            CreateDb.CreateCodesSuppliersTable();
            CreateDb.CreatePurchasesTable();
            CreateDb.CreateSalesTable();
            CreateDb.CreateStockTable();
            CreateDb.CreateMovsStockTable();

            User user = new User();
            user = SelectDb.selectUser("dev");
            if (user.Id != 1)
            {
                InsertDb.InsertUserDev();
            }

            tb_Name.Text = "dev";
            tb_Pass.Text = "dev";
        }
    }
}
