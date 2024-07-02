namespace StockController.RegistersScreens
{
    partial class User_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Screen));
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.menu_User = new System.Windows.Forms.MenuStrip();
            this.ts_Search_Code = new System.Windows.Forms.ToolStripTextBox();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.lb_Type = new System.Windows.Forms.Label();
            this.tb_Type = new System.Windows.Forms.TextBox();
            this.bt_Ask = new System.Windows.Forms.Button();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Hori_2 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Hori_1 = new System.Windows.Forms.PictureBox();
            this.menu_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(391, 114);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(138, 27);
            this.bt_Delete.TabIndex = 51;
            this.bt_Delete.Text = "Excluir";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(391, 81);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 50;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Enabled = false;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(391, 48);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 49;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // menu_User
            // 
            this.menu_User.BackColor = System.Drawing.Color.White;
            this.menu_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Search_Code});
            this.menu_User.Location = new System.Drawing.Point(0, 0);
            this.menu_User.Name = "menu_User";
            this.menu_User.Size = new System.Drawing.Size(373, 27);
            this.menu_User.TabIndex = 48;
            // 
            // ts_Search_Code
            // 
            this.ts_Search_Code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_Search_Code.Name = "ts_Search_Code";
            this.ts_Search_Code.Size = new System.Drawing.Size(100, 23);
            this.ts_Search_Code.Leave += new System.EventHandler(this.ts_Search_Code_Leave);
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(373, 0);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(168, 157);
            this.sp_Choices.TabIndex = 57;
            this.sp_Choices.TabStop = false;
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pass.Location = new System.Drawing.Point(15, 60);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(60, 20);
            this.lb_Pass.TabIndex = 64;
            this.lb_Pass.Text = "Senha:";
            // 
            // tb_Pass
            // 
            this.tb_Pass.Enabled = false;
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(93, 60);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.Size = new System.Drawing.Size(204, 26);
            this.tb_Pass.TabIndex = 62;
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.BackColor = System.Drawing.Color.Transparent;
            this.lb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Type.Location = new System.Drawing.Point(15, 106);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(43, 20);
            this.lb_Type.TabIndex = 66;
            this.lb_Type.Text = "Tipo:";
            // 
            // tb_Type
            // 
            this.tb_Type.Enabled = false;
            this.tb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Type.Location = new System.Drawing.Point(93, 106);
            this.tb_Type.Name = "tb_Type";
            this.tb_Type.Size = new System.Drawing.Size(204, 26);
            this.tb_Type.TabIndex = 65;
            this.tb_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            // 
            // bt_Ask
            // 
            this.bt_Ask.Enabled = false;
            this.bt_Ask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ask.Image = global::StockController.Properties.Resources.ask;
            this.bt_Ask.Location = new System.Drawing.Point(303, 106);
            this.bt_Ask.Name = "bt_Ask";
            this.bt_Ask.Size = new System.Drawing.Size(29, 27);
            this.bt_Ask.TabIndex = 67;
            this.bt_Ask.UseVisualStyleBackColor = true;
            this.bt_Ask.Click += new System.EventHandler(this.bt_Ask_Click);
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(367, 29);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 420);
            this.pb_Borda_Vert_1.TabIndex = 59;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // pb_Borda_Hori_2
            // 
            this.pb_Borda_Hori_2.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_2.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_2.Location = new System.Drawing.Point(367, 9);
            this.pb_Borda_Hori_2.Name = "pb_Borda_Hori_2";
            this.pb_Borda_Hori_2.Size = new System.Drawing.Size(174, 25);
            this.pb_Borda_Hori_2.TabIndex = 58;
            this.pb_Borda_Hori_2.TabStop = false;
            // 
            // pb_Borda_Hori_1
            // 
            this.pb_Borda_Hori_1.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_1.Location = new System.Drawing.Point(0, 9);
            this.pb_Borda_Hori_1.Name = "pb_Borda_Hori_1";
            this.pb_Borda_Hori_1.Size = new System.Drawing.Size(380, 25);
            this.pb_Borda_Hori_1.TabIndex = 56;
            this.pb_Borda_Hori_1.TabStop = false;
            // 
            // User_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 157);
            this.Controls.Add(this.bt_Ask);
            this.Controls.Add(this.menu_User);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.pb_Borda_Hori_2);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.tb_Type);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.sp_Choices);
            this.Controls.Add(this.pb_Borda_Hori_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.menu_User.ResumeLayout(false);
            this.menu_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.MenuStrip menu_User;
        private System.Windows.Forms.ToolStripTextBox ts_Search_Code;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_1;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_2;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.TextBox tb_Type;
        private System.Windows.Forms.Button bt_Ask;
    }
}