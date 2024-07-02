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
    public partial class UnitM_Screen : Form
    {
        Color colorBack, colorSecond;

        // insert or update control variable
        string controlIG;

        public UnitM_Screen(Color colorBack, Color colorSecond)
        {
            InitializeComponent();
            this.BackColor = colorBack;
            this.colorBack = colorBack;
            this.colorSecond = colorSecond;
            menu_UnitM.BackColor = colorSecond;
            sp_Choices.BackColor = colorSecond;
            pb_Borda_Hori_1.BackColor = colorBack;
            pb_Borda_Hori_2.BackColor = colorSecond;
            pb_Borda_Vert_1.BackColor = colorBack;
            ts_Search_Code.MaxLength = 10;
            tb_Acronym.MaxLength = 5;
            tb_DecimalPlaces.MaxLength = 1;
            tb_Name_UnitM.MaxLength = 25;

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

        private void bt_Search_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Search_Screen search_Screen = new Search_Screen(colorBack, colorSecond, "UnitM", 1);

            // Adds an event handler for the FormClosed event
            search_Screen.FormClosed += (s, args) =>
            {
                // This block of code will be executed when the window is closed
                this.Enabled = true;
                int idUnitMSearch = search_Screen.idObj;
                if (idUnitMSearch > 0)
                {
                    ts_Search_Code.Text = idUnitMSearch.ToString();
                    ts_Search_Code_Leave(sender, e);
                }
            };

            search_Screen.Show();
        }

        private void bt_New_UnitM_Click(object sender, EventArgs e)
        {
            UnitM unitM = new UnitM();
            unitM = SelectDb.SelectUnitM(0, 2);
            unitM.Id = unitM.Id + 1;
            ts_Search_Code.Text = unitM.Id.ToString();
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
                UnitM unitM = new UnitM();
                unitM = SelectDb.SelectUnitM(cod, 1);
                if (unitM.Id == 0)
                {
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    ts_Search_Code.Enabled = false;
                    bt_New_UnitM.Enabled = false;
                    bt_Search.Enabled = false;

                    tb_Name_UnitM.Enabled = true;
                    tb_DecimalPlaces.Enabled = true;
                    tb_Acronym.Enabled = true;

                    controlIG = "Insert";
                }
                else
                {
                    bt_Save.Enabled = true;
                    bt_Cancel.Enabled = true;
                    bt_Delete.Enabled = true;
                    ts_Search_Code.Enabled = false;
                    bt_New_UnitM.Enabled = false;
                    bt_Search.Enabled = false;

                    tb_Name_UnitM.Enabled = true;
                    tb_Name_UnitM.Text = unitM.Name;
                    tb_DecimalPlaces.Enabled = true;
                    tb_DecimalPlaces.Text = unitM.DecimalPlaces.ToString();
                    tb_Acronym.Enabled = true;
                    tb_Acronym.Text = unitM.Acronym;

                    controlIG = "Update";
                }
            }

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            UnitM unitM = new UnitM();
            unitM.Id = int.Parse(ts_Search_Code.Text);

            if (string.IsNullOrEmpty(tb_Name_UnitM.Text))
            {
                MessageBox.Show("Preencha o campo Nome", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(tb_Acronym.Text))
                {
                    MessageBox.Show("Preencha o campo Sigla", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    if (string.IsNullOrEmpty(tb_DecimalPlaces.Text))
                    {
                        MessageBox.Show("Preencha o campo Casas Decimais", "Aviso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        unitM.Acronym = tb_Acronym.Text;
                        unitM.Name = tb_Name_UnitM.Text;
                        unitM.DecimalPlaces = int.Parse(tb_DecimalPlaces.Text);


                        if (controlIG == "Insert")
                        {
                            InsertDb.InsertUnitM(unitM);
                            bt_Cancel_Click(sender, e);
                            MessageBox.Show("Unidade de medida cadastrada com Sucesso", "Aviso", MessageBoxButtons.OK);

                        }
                        else if (controlIG == "Update")
                        {
                            UpdateDb.UpdateUnitM(unitM);
                            bt_Cancel_Click(sender, e);
                            MessageBox.Show("Unidade de medida atualizada com Sucesso", "Aviso", MessageBoxButtons.OK);

                        }
                    }
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (controlIG == "Insert")
            {
                MessageBox.Show("Unidade de medida não cadastrada ainda\nCancele o processo se precisar.", "AVISO", MessageBoxButtons.OK);
            }
            else if (controlIG == "Update")
            {
                UnitM unitM = new UnitM();
                unitM.Id = int.Parse(ts_Search_Code.Text);

                DeleteDb.DeleteUnitM(unitM);
                MessageBox.Show("Unidade de medida excluída com sucesso");
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

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            ts_Search_Code.Text = "";
            bt_Save.Enabled = false;
            bt_Cancel.Enabled = false;
            bt_Delete.Enabled = false;
            ts_Search_Code.Enabled = true;
            bt_New_UnitM.Enabled = true;
            bt_Search.Enabled = true;
            controlIG = "";

            tb_Name_UnitM.Enabled = false;
            tb_Name_UnitM.Text = "";
            tb_DecimalPlaces.Enabled = false;
            tb_DecimalPlaces.Text = "";
            tb_Acronym.Enabled = false;
            tb_Acronym.Text = "";
        }
    }
}
