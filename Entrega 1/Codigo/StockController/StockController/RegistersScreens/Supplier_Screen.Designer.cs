namespace StockController
{
    partial class Supplier_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Screen));
            this.bt_New_Supplier = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.menu_Supplier = new System.Windows.Forms.MenuStrip();
            this.ts_Search_Code = new System.Windows.Forms.ToolStripTextBox();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.tb_Name_Supplier = new System.Windows.Forms.TextBox();
            this.lb_Name_Supplier = new System.Windows.Forms.Label();
            this.tb_CpfCnpj = new System.Windows.Forms.TextBox();
            this.lb_RegistrationType = new System.Windows.Forms.Label();
            this.cbx_Cpf = new System.Windows.Forms.CheckBox();
            this.cbx_CNPJ = new System.Windows.Forms.CheckBox();
            this.tb_CorporateReason = new System.Windows.Forms.TextBox();
            this.lb_CorporateReason = new System.Windows.Forms.Label();
            this.tb_Obs_Supplier = new System.Windows.Forms.TextBox();
            this.lb_Obs_Supplier = new System.Windows.Forms.Label();
            this.lb_Status_Supplier = new System.Windows.Forms.Label();
            this.pb_Borda_Hori_1 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Hori_2 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.cbx_Inactive = new System.Windows.Forms.CheckBox();
            this.cbx_Active = new System.Windows.Forms.CheckBox();
            this.pb_Cube_Transparent = new System.Windows.Forms.PictureBox();
            this.menu_Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cube_Transparent)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_New_Supplier
            // 
            this.bt_New_Supplier.Image = global::StockController.Properties.Resources.addIcon;
            this.bt_New_Supplier.Location = new System.Drawing.Point(142, 1);
            this.bt_New_Supplier.Name = "bt_New_Supplier";
            this.bt_New_Supplier.Size = new System.Drawing.Size(27, 26);
            this.bt_New_Supplier.TabIndex = 39;
            this.bt_New_Supplier.UseVisualStyleBackColor = true;
            this.bt_New_Supplier.Click += new System.EventHandler(this.bt_New_Supplier_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.Location = new System.Drawing.Point(109, 1);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(27, 26);
            this.bt_Search.TabIndex = 38;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // menu_Supplier
            // 
            this.menu_Supplier.BackColor = System.Drawing.Color.White;
            this.menu_Supplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Search_Code});
            this.menu_Supplier.Location = new System.Drawing.Point(0, 0);
            this.menu_Supplier.Name = "menu_Supplier";
            this.menu_Supplier.Size = new System.Drawing.Size(498, 27);
            this.menu_Supplier.TabIndex = 36;
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
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(498, 0);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(174, 323);
            this.sp_Choices.TabIndex = 37;
            this.sp_Choices.TabStop = false;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(522, 280);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(138, 27);
            this.bt_Delete.TabIndex = 42;
            this.bt_Delete.Text = "Excluir";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(522, 247);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 41;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Enabled = false;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(522, 214);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 40;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // tb_Name_Supplier
            // 
            this.tb_Name_Supplier.Enabled = false;
            this.tb_Name_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name_Supplier.Location = new System.Drawing.Point(68, 45);
            this.tb_Name_Supplier.Name = "tb_Name_Supplier";
            this.tb_Name_Supplier.Size = new System.Drawing.Size(409, 26);
            this.tb_Name_Supplier.TabIndex = 53;
            // 
            // lb_Name_Supplier
            // 
            this.lb_Name_Supplier.AutoSize = true;
            this.lb_Name_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name_Supplier.Location = new System.Drawing.Point(14, 48);
            this.lb_Name_Supplier.Name = "lb_Name_Supplier";
            this.lb_Name_Supplier.Size = new System.Drawing.Size(55, 20);
            this.lb_Name_Supplier.TabIndex = 52;
            this.lb_Name_Supplier.Text = "Nome:";
            // 
            // tb_CpfCnpj
            // 
            this.tb_CpfCnpj.Enabled = false;
            this.tb_CpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CpfCnpj.Location = new System.Drawing.Point(254, 129);
            this.tb_CpfCnpj.Name = "tb_CpfCnpj";
            this.tb_CpfCnpj.Size = new System.Drawing.Size(185, 26);
            this.tb_CpfCnpj.TabIndex = 55;
            // 
            // lb_RegistrationType
            // 
            this.lb_RegistrationType.AutoSize = true;
            this.lb_RegistrationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RegistrationType.Location = new System.Drawing.Point(14, 127);
            this.lb_RegistrationType.Name = "lb_RegistrationType";
            this.lb_RegistrationType.Size = new System.Drawing.Size(133, 20);
            this.lb_RegistrationType.TabIndex = 54;
            this.lb_RegistrationType.Text = "Tipo de Inscrição:";
            // 
            // cbx_Cpf
            // 
            this.cbx_Cpf.AutoSize = true;
            this.cbx_Cpf.Enabled = false;
            this.cbx_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Cpf.Location = new System.Drawing.Point(153, 129);
            this.cbx_Cpf.Name = "cbx_Cpf";
            this.cbx_Cpf.Size = new System.Drawing.Size(59, 24);
            this.cbx_Cpf.TabIndex = 57;
            this.cbx_Cpf.Text = "CPF";
            this.cbx_Cpf.UseVisualStyleBackColor = true;
            this.cbx_Cpf.CheckedChanged += new System.EventHandler(this.cbx_Cpf_CheckedChanged);
            // 
            // cbx_CNPJ
            // 
            this.cbx_CNPJ.AutoSize = true;
            this.cbx_CNPJ.Enabled = false;
            this.cbx_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CNPJ.Location = new System.Drawing.Point(153, 153);
            this.cbx_CNPJ.Name = "cbx_CNPJ";
            this.cbx_CNPJ.Size = new System.Drawing.Size(68, 24);
            this.cbx_CNPJ.TabIndex = 58;
            this.cbx_CNPJ.Text = "CNPJ";
            this.cbx_CNPJ.UseVisualStyleBackColor = true;
            this.cbx_CNPJ.CheckedChanged += new System.EventHandler(this.cbx_CNPJ_CheckedChanged);
            // 
            // tb_CorporateReason
            // 
            this.tb_CorporateReason.Enabled = false;
            this.tb_CorporateReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CorporateReason.Location = new System.Drawing.Point(121, 75);
            this.tb_CorporateReason.Name = "tb_CorporateReason";
            this.tb_CorporateReason.Size = new System.Drawing.Size(356, 26);
            this.tb_CorporateReason.TabIndex = 60;
            // 
            // lb_CorporateReason
            // 
            this.lb_CorporateReason.AutoSize = true;
            this.lb_CorporateReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CorporateReason.Location = new System.Drawing.Point(14, 80);
            this.lb_CorporateReason.Name = "lb_CorporateReason";
            this.lb_CorporateReason.Size = new System.Drawing.Size(107, 20);
            this.lb_CorporateReason.TabIndex = 59;
            this.lb_CorporateReason.Text = "Razão Social:";
            // 
            // tb_Obs_Supplier
            // 
            this.tb_Obs_Supplier.Enabled = false;
            this.tb_Obs_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Obs_Supplier.Location = new System.Drawing.Point(18, 246);
            this.tb_Obs_Supplier.Multiline = true;
            this.tb_Obs_Supplier.Name = "tb_Obs_Supplier";
            this.tb_Obs_Supplier.Size = new System.Drawing.Size(469, 61);
            this.tb_Obs_Supplier.TabIndex = 62;
            // 
            // lb_Obs_Supplier
            // 
            this.lb_Obs_Supplier.AutoSize = true;
            this.lb_Obs_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Obs_Supplier.Location = new System.Drawing.Point(14, 223);
            this.lb_Obs_Supplier.Name = "lb_Obs_Supplier";
            this.lb_Obs_Supplier.Size = new System.Drawing.Size(106, 20);
            this.lb_Obs_Supplier.TabIndex = 61;
            this.lb_Obs_Supplier.Text = "Observações:";
            // 
            // lb_Status_Supplier
            // 
            this.lb_Status_Supplier.AutoSize = true;
            this.lb_Status_Supplier.BackColor = System.Drawing.Color.Transparent;
            this.lb_Status_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status_Supplier.Location = new System.Drawing.Point(518, 41);
            this.lb_Status_Supplier.Name = "lb_Status_Supplier";
            this.lb_Status_Supplier.Size = new System.Drawing.Size(56, 20);
            this.lb_Status_Supplier.TabIndex = 64;
            this.lb_Status_Supplier.Text = "Status";
            // 
            // pb_Borda_Hori_1
            // 
            this.pb_Borda_Hori_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_1.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_1.Location = new System.Drawing.Point(-66, 9);
            this.pb_Borda_Hori_1.Name = "pb_Borda_Hori_1";
            this.pb_Borda_Hori_1.Size = new System.Drawing.Size(564, 25);
            this.pb_Borda_Hori_1.TabIndex = 65;
            this.pb_Borda_Hori_1.TabStop = false;
            // 
            // pb_Borda_Hori_2
            // 
            this.pb_Borda_Hori_2.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_2.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_2.Location = new System.Drawing.Point(498, 9);
            this.pb_Borda_Hori_2.Name = "pb_Borda_Hori_2";
            this.pb_Borda_Hori_2.Size = new System.Drawing.Size(174, 25);
            this.pb_Borda_Hori_2.TabIndex = 66;
            this.pb_Borda_Hori_2.TabStop = false;
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(491, 29);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 384);
            this.pb_Borda_Vert_1.TabIndex = 67;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // cbx_Inactive
            // 
            this.cbx_Inactive.AutoSize = true;
            this.cbx_Inactive.Enabled = false;
            this.cbx_Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Inactive.Location = new System.Drawing.Point(526, 94);
            this.cbx_Inactive.Name = "cbx_Inactive";
            this.cbx_Inactive.Size = new System.Drawing.Size(75, 24);
            this.cbx_Inactive.TabIndex = 70;
            this.cbx_Inactive.Text = "Inativo";
            this.cbx_Inactive.UseVisualStyleBackColor = true;
            this.cbx_Inactive.CheckedChanged += new System.EventHandler(this.cbx_Inactive_CheckedChanged);
            // 
            // cbx_Active
            // 
            this.cbx_Active.AutoSize = true;
            this.cbx_Active.Enabled = false;
            this.cbx_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Active.Location = new System.Drawing.Point(526, 64);
            this.cbx_Active.Name = "cbx_Active";
            this.cbx_Active.Size = new System.Drawing.Size(63, 24);
            this.cbx_Active.TabIndex = 69;
            this.cbx_Active.Text = "Ativo";
            this.cbx_Active.UseVisualStyleBackColor = true;
            this.cbx_Active.CheckedChanged += new System.EventHandler(this.cbx_Active_CheckedChanged);
            // 
            // pb_Cube_Transparent
            // 
            this.pb_Cube_Transparent.BackColor = System.Drawing.Color.Transparent;
            this.pb_Cube_Transparent.Location = new System.Drawing.Point(522, 64);
            this.pb_Cube_Transparent.Name = "pb_Cube_Transparent";
            this.pb_Cube_Transparent.Size = new System.Drawing.Size(138, 57);
            this.pb_Cube_Transparent.TabIndex = 68;
            this.pb_Cube_Transparent.TabStop = false;
            // 
            // Supplier_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 323);
            this.Controls.Add(this.cbx_Inactive);
            this.Controls.Add(this.cbx_Active);
            this.Controls.Add(this.pb_Cube_Transparent);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.pb_Borda_Hori_2);
            this.Controls.Add(this.lb_Status_Supplier);
            this.Controls.Add(this.tb_Obs_Supplier);
            this.Controls.Add(this.lb_Obs_Supplier);
            this.Controls.Add(this.tb_CorporateReason);
            this.Controls.Add(this.lb_CorporateReason);
            this.Controls.Add(this.cbx_CNPJ);
            this.Controls.Add(this.cbx_Cpf);
            this.Controls.Add(this.tb_CpfCnpj);
            this.Controls.Add(this.lb_RegistrationType);
            this.Controls.Add(this.tb_Name_Supplier);
            this.Controls.Add(this.lb_Name_Supplier);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_New_Supplier);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.menu_Supplier);
            this.Controls.Add(this.sp_Choices);
            this.Controls.Add(this.pb_Borda_Hori_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Supplier_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Fornecedor";
            this.menu_Supplier.ResumeLayout(false);
            this.menu_Supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cube_Transparent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_New_Supplier;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.MenuStrip menu_Supplier;
        private System.Windows.Forms.ToolStripTextBox ts_Search_Code;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_Name_Supplier;
        private System.Windows.Forms.Label lb_Name_Supplier;
        private System.Windows.Forms.TextBox tb_CpfCnpj;
        private System.Windows.Forms.Label lb_RegistrationType;
        private System.Windows.Forms.CheckBox cbx_Cpf;
        private System.Windows.Forms.CheckBox cbx_CNPJ;
        private System.Windows.Forms.TextBox tb_CorporateReason;
        private System.Windows.Forms.Label lb_CorporateReason;
        private System.Windows.Forms.TextBox tb_Obs_Supplier;
        private System.Windows.Forms.Label lb_Obs_Supplier;
        private System.Windows.Forms.Label lb_Status_Supplier;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_1;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_2;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.CheckBox cbx_Inactive;
        private System.Windows.Forms.CheckBox cbx_Active;
        private System.Windows.Forms.PictureBox pb_Cube_Transparent;
    }
}