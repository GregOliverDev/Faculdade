namespace StockController
{
    partial class UnitM_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitM_Screen));
            this.tb_Name_UnitM = new System.Windows.Forms.TextBox();
            this.lb_Name_UnitM = new System.Windows.Forms.Label();
            this.lb_Acronym = new System.Windows.Forms.Label();
            this.bt_New_UnitM = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.menu_UnitM = new System.Windows.Forms.MenuStrip();
            this.ts_Search_Code = new System.Windows.Forms.ToolStripTextBox();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Hori_2 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Hori_1 = new System.Windows.Forms.PictureBox();
            this.tb_Acronym = new System.Windows.Forms.TextBox();
            this.tb_DecimalPlaces = new System.Windows.Forms.TextBox();
            this.lb_DecimalPlaces = new System.Windows.Forms.Label();
            this.menu_UnitM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name_UnitM
            // 
            this.tb_Name_UnitM.Enabled = false;
            this.tb_Name_UnitM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name_UnitM.Location = new System.Drawing.Point(66, 46);
            this.tb_Name_UnitM.Name = "tb_Name_UnitM";
            this.tb_Name_UnitM.Size = new System.Drawing.Size(371, 26);
            this.tb_Name_UnitM.TabIndex = 51;
            // 
            // lb_Name_UnitM
            // 
            this.lb_Name_UnitM.AutoSize = true;
            this.lb_Name_UnitM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name_UnitM.Location = new System.Drawing.Point(12, 49);
            this.lb_Name_UnitM.Name = "lb_Name_UnitM";
            this.lb_Name_UnitM.Size = new System.Drawing.Size(55, 20);
            this.lb_Name_UnitM.TabIndex = 50;
            this.lb_Name_UnitM.Text = "Nome:";
            // 
            // lb_Acronym
            // 
            this.lb_Acronym.AutoSize = true;
            this.lb_Acronym.BackColor = System.Drawing.Color.Transparent;
            this.lb_Acronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Acronym.Location = new System.Drawing.Point(12, 86);
            this.lb_Acronym.Name = "lb_Acronym";
            this.lb_Acronym.Size = new System.Drawing.Size(48, 20);
            this.lb_Acronym.TabIndex = 49;
            this.lb_Acronym.Text = "Sigla:";
            // 
            // bt_New_UnitM
            // 
            this.bt_New_UnitM.Image = global::StockController.Properties.Resources.addIcon;
            this.bt_New_UnitM.Location = new System.Drawing.Point(142, 1);
            this.bt_New_UnitM.Name = "bt_New_UnitM";
            this.bt_New_UnitM.Size = new System.Drawing.Size(27, 26);
            this.bt_New_UnitM.TabIndex = 48;
            this.bt_New_UnitM.UseVisualStyleBackColor = true;
            this.bt_New_UnitM.Click += new System.EventHandler(this.bt_New_UnitM_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.Location = new System.Drawing.Point(109, 1);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(27, 26);
            this.bt_Search.TabIndex = 47;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // menu_UnitM
            // 
            this.menu_UnitM.BackColor = System.Drawing.Color.White;
            this.menu_UnitM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Search_Code});
            this.menu_UnitM.Location = new System.Drawing.Point(0, 0);
            this.menu_UnitM.Name = "menu_UnitM";
            this.menu_UnitM.Size = new System.Drawing.Size(498, 27);
            this.menu_UnitM.TabIndex = 42;
            // 
            // ts_Search_Code
            // 
            this.ts_Search_Code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_Search_Code.Name = "ts_Search_Code";
            this.ts_Search_Code.Size = new System.Drawing.Size(100, 23);
            this.ts_Search_Code.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ts_Search_Code.Leave += new System.EventHandler(this.ts_Search_Code_Leave);
            this.ts_Search_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(522, 139);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(138, 27);
            this.bt_Delete.TabIndex = 46;
            this.bt_Delete.Text = "Excluir";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(522, 106);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 45;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Enabled = false;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(522, 73);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 44;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(498, 0);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(174, 192);
            this.sp_Choices.TabIndex = 43;
            this.sp_Choices.TabStop = false;
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(491, 29);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 384);
            this.pb_Borda_Vert_1.TabIndex = 54;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // pb_Borda_Hori_2
            // 
            this.pb_Borda_Hori_2.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_2.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_2.Location = new System.Drawing.Point(498, 9);
            this.pb_Borda_Hori_2.Name = "pb_Borda_Hori_2";
            this.pb_Borda_Hori_2.Size = new System.Drawing.Size(174, 25);
            this.pb_Borda_Hori_2.TabIndex = 53;
            this.pb_Borda_Hori_2.TabStop = false;
            // 
            // pb_Borda_Hori_1
            // 
            this.pb_Borda_Hori_1.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_1.Location = new System.Drawing.Point(-66, 9);
            this.pb_Borda_Hori_1.Name = "pb_Borda_Hori_1";
            this.pb_Borda_Hori_1.Size = new System.Drawing.Size(564, 25);
            this.pb_Borda_Hori_1.TabIndex = 52;
            this.pb_Borda_Hori_1.TabStop = false;
            // 
            // tb_Acronym
            // 
            this.tb_Acronym.Enabled = false;
            this.tb_Acronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Acronym.Location = new System.Drawing.Point(66, 83);
            this.tb_Acronym.Name = "tb_Acronym";
            this.tb_Acronym.Size = new System.Drawing.Size(67, 26);
            this.tb_Acronym.TabIndex = 55;
            // 
            // tb_DecimalPlaces
            // 
            this.tb_DecimalPlaces.Enabled = false;
            this.tb_DecimalPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DecimalPlaces.Location = new System.Drawing.Point(291, 83);
            this.tb_DecimalPlaces.Name = "tb_DecimalPlaces";
            this.tb_DecimalPlaces.Size = new System.Drawing.Size(67, 26);
            this.tb_DecimalPlaces.TabIndex = 57;
            this.tb_DecimalPlaces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            // 
            // lb_DecimalPlaces
            // 
            this.lb_DecimalPlaces.AutoSize = true;
            this.lb_DecimalPlaces.BackColor = System.Drawing.Color.Transparent;
            this.lb_DecimalPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DecimalPlaces.Location = new System.Drawing.Point(158, 86);
            this.lb_DecimalPlaces.Name = "lb_DecimalPlaces";
            this.lb_DecimalPlaces.Size = new System.Drawing.Size(127, 20);
            this.lb_DecimalPlaces.TabIndex = 56;
            this.lb_DecimalPlaces.Text = "Casas Decimais:";
            // 
            // UnitM_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 192);
            this.Controls.Add(this.tb_DecimalPlaces);
            this.Controls.Add(this.lb_DecimalPlaces);
            this.Controls.Add(this.tb_Acronym);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.pb_Borda_Hori_2);
            this.Controls.Add(this.tb_Name_UnitM);
            this.Controls.Add(this.lb_Name_UnitM);
            this.Controls.Add(this.lb_Acronym);
            this.Controls.Add(this.bt_New_UnitM);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.menu_UnitM);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.sp_Choices);
            this.Controls.Add(this.pb_Borda_Hori_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitM_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Unidade de Medida";
            this.menu_UnitM.ResumeLayout(false);
            this.menu_UnitM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name_UnitM;
        private System.Windows.Forms.Label lb_Name_UnitM;
        private System.Windows.Forms.Label lb_Acronym;
        private System.Windows.Forms.Button bt_New_UnitM;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.MenuStrip menu_UnitM;
        private System.Windows.Forms.ToolStripTextBox ts_Search_Code;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_2;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_1;
        private System.Windows.Forms.TextBox tb_Acronym;
        private System.Windows.Forms.TextBox tb_DecimalPlaces;
        private System.Windows.Forms.Label lb_DecimalPlaces;
    }
}