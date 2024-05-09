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

namespace StockController.RegistersScreens
{
    public partial class User_Screen : Form
    {
        Color colorBack, colorSecond;

        // insert or update control variable
        string controlIG;

        public User_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            menu_User.BackColor = colorSecond;
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

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            tb_Name.Enabled = false;
            tb_Name.Text = "";
            tb_Pass.Enabled = false;
            tb_Pass.Text = "";
            tb_Type.Enabled = false;
            tb_Type.Text = "";

            bt_Save.Enabled = false;
            bt_Cancel.Enabled = false;
            bt_Delete.Enabled = false;
            ts_Search_Code.Enabled = true;
            controlIG = "";

            ts_Search_Code.Text = "";
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = ts_Search_Code.Text;
            user.Name = tb_Name.Text;
            user.Password = tb_Pass.Text;
            user.Type = Convert.ToInt32(tb_Type.Text);

            if (controlIG == "Insert")
            {
                InsertDb.InsertUser(user);
                bt_Cancel_Click(sender, e);
                MessageBox.Show("Usuário cadastrado com Sucesso", "Aviso", MessageBoxButtons.OK);

            }
            else if (controlIG == "Update")
            {
                UpdateDb.UpdateUser(user);
                bt_Cancel_Click(sender, e);
                MessageBox.Show("Usuário atualizada com Sucesso", "Aviso", MessageBoxButtons.OK);

            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (controlIG == "Insert")
            {
                MessageBox.Show("Usuário não cadastrada.");
            }
            else
            {
                User user = new User();
                user = SelectDb.selectUser(ts_Search_Code.Text);

                DeleteDb.DeleteUser(user);
                MessageBox.Show("Usuário excluído com sucesso");
                bt_Cancel_Click(sender, e);
            }
        }

        private void ts_Search_Code_Leave(object sender, EventArgs e)
        {
            string codString = ts_Search_Code.Text;

            if (codString == "")
            {
                MessageBox.Show("Digite um nome valido", "Aviso", MessageBoxButtons.OK);
                bt_Cancel_Click(sender, e);
            }
            else
            {
                User user = new User();
                user = SelectDb.selectUser(ts_Search_Code.Text);
                if (user.Id == 0)
                {
                    tb_Name.Enabled = true;
                    tb_Pass.Enabled = true;
                    tb_Type.Enabled = true;
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    ts_Search_Code.Enabled = false;

                    controlIG = "Insert";
                }
                else
                {
                    tb_Name.Enabled = true;
                    tb_Name.Text = user.Name;
                    tb_Pass.Enabled = true;
                    tb_Pass.Text = user.Password;
                    tb_Type.Enabled = true;
                    tb_Type.Text = user.Type.ToString();

                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    ts_Search_Code.Enabled = false;

                    controlIG = "Update";
                }
            }
        }
    }
}
