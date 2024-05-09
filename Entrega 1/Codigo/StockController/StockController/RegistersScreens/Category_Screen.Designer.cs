namespace StockController
{
    partial class Category_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Screen));
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.menu_Category = new System.Windows.Forms.MenuStrip();
            this.ts_Search_Code = new System.Windows.Forms.ToolStripTextBox();
            this.pb_Borda_Hori_1 = new System.Windows.Forms.PictureBox();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.pb_Borda_Hori_2 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.bt_New_Category = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_Descri_Category = new System.Windows.Forms.TextBox();
            this.lb_Descri_Category = new System.Windows.Forms.Label();
            this.lb_Mov_Stock = new System.Windows.Forms.Label();
            this.cbx_Mov_Yes = new System.Windows.Forms.CheckBox();
            this.cbx_Mov_No = new System.Windows.Forms.CheckBox();
            this.menu_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(522, 160);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(138, 27);
            this.bt_Delete.TabIndex = 30;
            this.bt_Delete.Text = "Excluir";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(522, 127);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 29;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Enabled = false;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(522, 94);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 28;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // menu_Category
            // 
            this.menu_Category.BackColor = System.Drawing.Color.White;
            this.menu_Category.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Search_Code});
            this.menu_Category.Location = new System.Drawing.Point(0, 0);
            this.menu_Category.Name = "menu_Category";
            this.menu_Category.Size = new System.Drawing.Size(498, 27);
            this.menu_Category.TabIndex = 24;
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
            // pb_Borda_Hori_1
            // 
            this.pb_Borda_Hori_1.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_1.Location = new System.Drawing.Point(-66, 9);
            this.pb_Borda_Hori_1.Name = "pb_Borda_Hori_1";
            this.pb_Borda_Hori_1.Size = new System.Drawing.Size(564, 25);
            this.pb_Borda_Hori_1.TabIndex = 31;
            this.pb_Borda_Hori_1.TabStop = false;
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(498, 0);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(174, 235);
            this.sp_Choices.TabIndex = 26;
            this.sp_Choices.TabStop = false;
            // 
            // pb_Borda_Hori_2
            // 
            this.pb_Borda_Hori_2.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_2.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_2.Location = new System.Drawing.Point(498, 9);
            this.pb_Borda_Hori_2.Name = "pb_Borda_Hori_2";
            this.pb_Borda_Hori_2.Size = new System.Drawing.Size(174, 25);
            this.pb_Borda_Hori_2.TabIndex = 32;
            this.pb_Borda_Hori_2.TabStop = false;
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(491, 29);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 384);
            this.pb_Borda_Vert_1.TabIndex = 33;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // bt_New_Category
            // 
            this.bt_New_Category.Image = global::StockController.Properties.Resources.addIcon;
            this.bt_New_Category.Location = new System.Drawing.Point(142, 1);
            this.bt_New_Category.Name = "bt_New_Category";
            this.bt_New_Category.Size = new System.Drawing.Size(27, 26);
            this.bt_New_Category.TabIndex = 35;
            this.bt_New_Category.UseVisualStyleBackColor = true;
            this.bt_New_Category.Click += new System.EventHandler(this.bt_New_Category_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.Location = new System.Drawing.Point(109, 1);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(27, 26);
            this.bt_Search.TabIndex = 34;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tb_Descri_Category
            // 
            this.tb_Descri_Category.Enabled = false;
            this.tb_Descri_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descri_Category.Location = new System.Drawing.Point(12, 72);
            this.tb_Descri_Category.Multiline = true;
            this.tb_Descri_Category.Name = "tb_Descri_Category";
            this.tb_Descri_Category.Size = new System.Drawing.Size(469, 61);
            this.tb_Descri_Category.TabIndex = 39;
            // 
            // lb_Descri_Category
            // 
            this.lb_Descri_Category.AutoSize = true;
            this.lb_Descri_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Descri_Category.Location = new System.Drawing.Point(8, 49);
            this.lb_Descri_Category.Name = "lb_Descri_Category";
            this.lb_Descri_Category.Size = new System.Drawing.Size(84, 20);
            this.lb_Descri_Category.TabIndex = 38;
            this.lb_Descri_Category.Text = "Descrição:";
            // 
            // lb_Mov_Stock
            // 
            this.lb_Mov_Stock.AutoSize = true;
            this.lb_Mov_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lb_Mov_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mov_Stock.Location = new System.Drawing.Point(12, 146);
            this.lb_Mov_Stock.Name = "lb_Mov_Stock";
            this.lb_Mov_Stock.Size = new System.Drawing.Size(154, 20);
            this.lb_Mov_Stock.TabIndex = 37;
            this.lb_Mov_Stock.Text = "Movimenta Estoque:";
            // 
            // cbx_Mov_Yes
            // 
            this.cbx_Mov_Yes.AutoSize = true;
            this.cbx_Mov_Yes.Enabled = false;
            this.cbx_Mov_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Mov_Yes.Location = new System.Drawing.Point(172, 146);
            this.cbx_Mov_Yes.Name = "cbx_Mov_Yes";
            this.cbx_Mov_Yes.Size = new System.Drawing.Size(55, 24);
            this.cbx_Mov_Yes.TabIndex = 40;
            this.cbx_Mov_Yes.Text = "Sim";
            this.cbx_Mov_Yes.UseVisualStyleBackColor = true;
            this.cbx_Mov_Yes.CheckedChanged += new System.EventHandler(this.cbx_Mov_Yes_CheckedChanged);
            // 
            // cbx_Mov_No
            // 
            this.cbx_Mov_No.AutoSize = true;
            this.cbx_Mov_No.Enabled = false;
            this.cbx_Mov_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Mov_No.Location = new System.Drawing.Point(172, 176);
            this.cbx_Mov_No.Name = "cbx_Mov_No";
            this.cbx_Mov_No.Size = new System.Drawing.Size(57, 24);
            this.cbx_Mov_No.TabIndex = 41;
            this.cbx_Mov_No.Text = "Não";
            this.cbx_Mov_No.UseVisualStyleBackColor = true;
            this.cbx_Mov_No.CheckedChanged += new System.EventHandler(this.cbx_Mov_No_CheckedChanged);
            // 
            // Category_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 235);
            this.Controls.Add(this.cbx_Mov_No);
            this.Controls.Add(this.cbx_Mov_Yes);
            this.Controls.Add(this.tb_Descri_Category);
            this.Controls.Add(this.lb_Descri_Category);
            this.Controls.Add(this.lb_Mov_Stock);
            this.Controls.Add(this.bt_New_Category);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.pb_Borda_Hori_2);
            this.Controls.Add(this.menu_Category);
            this.Controls.Add(this.pb_Borda_Hori_1);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.sp_Choices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Category_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Categoria";
            this.menu_Category.ResumeLayout(false);
            this.menu_Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.MenuStrip menu_Category;
        private System.Windows.Forms.ToolStripTextBox ts_Search_Code;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_1;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_2;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.Button bt_New_Category;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_Descri_Category;
        private System.Windows.Forms.Label lb_Descri_Category;
        private System.Windows.Forms.Label lb_Mov_Stock;
        private System.Windows.Forms.CheckBox cbx_Mov_Yes;
        private System.Windows.Forms.CheckBox cbx_Mov_No;
    }
}