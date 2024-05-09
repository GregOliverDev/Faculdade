namespace StockController
{
    partial class Search_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Sales));
            this.bt_Export = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.lb_Filter = new System.Windows.Forms.Label();
            this.tb_Filter1 = new System.Windows.Forms.TextBox();
            this.lb_Sum = new System.Windows.Forms.Label();
            this.tb_Filter2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbx_Name = new System.Windows.Forms.CheckBox();
            this.pb_Cube_Transparent = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.lb_Type_Filter = new System.Windows.Forms.Label();
            this.pb_Borda_Hori_2 = new System.Windows.Forms.PictureBox();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.pb_Borda_Hori_1 = new System.Windows.Forms.PictureBox();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.sp_Menu = new System.Windows.Forms.Splitter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cube_Transparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Export
            // 
            this.bt_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Export.Location = new System.Drawing.Point(634, 120);
            this.bt_Export.Name = "bt_Export";
            this.bt_Export.Size = new System.Drawing.Size(138, 27);
            this.bt_Export.TabIndex = 68;
            this.bt_Export.Text = "Exportar Dados";
            this.bt_Export.UseVisualStyleBackColor = true;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(634, 422);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 66;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.Location = new System.Drawing.Point(578, 32);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(27, 27);
            this.bt_Search.TabIndex = 64;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // lb_Filter
            // 
            this.lb_Filter.AutoSize = true;
            this.lb_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lb_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Filter.Location = new System.Drawing.Point(132, 37);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(48, 20);
            this.lb_Filter.TabIndex = 63;
            this.lb_Filter.Text = "Filtro:";
            // 
            // tb_Filter1
            // 
            this.tb_Filter1.Enabled = false;
            this.tb_Filter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Filter1.Location = new System.Drawing.Point(186, 33);
            this.tb_Filter1.Name = "tb_Filter1";
            this.tb_Filter1.Size = new System.Drawing.Size(175, 26);
            this.tb_Filter1.TabIndex = 59;
            // 
            // lb_Sum
            // 
            this.lb_Sum.AutoSize = true;
            this.lb_Sum.BackColor = System.Drawing.Color.Transparent;
            this.lb_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sum.Location = new System.Drawing.Point(367, 33);
            this.lb_Sum.Name = "lb_Sum";
            this.lb_Sum.Size = new System.Drawing.Size(24, 25);
            this.lb_Sum.TabIndex = 60;
            this.lb_Sum.Text = "+";
            // 
            // tb_Filter2
            // 
            this.tb_Filter2.Enabled = false;
            this.tb_Filter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Filter2.Location = new System.Drawing.Point(397, 32);
            this.tb_Filter2.Name = "tb_Filter2";
            this.tb_Filter2.Size = new System.Drawing.Size(175, 26);
            this.tb_Filter2.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(123, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 57);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // cbx_Name
            // 
            this.cbx_Name.AutoSize = true;
            this.cbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Name.Location = new System.Drawing.Point(21, 35);
            this.cbx_Name.Name = "cbx_Name";
            this.cbx_Name.Size = new System.Drawing.Size(70, 24);
            this.cbx_Name.TabIndex = 58;
            this.cbx_Name.Text = "Nome";
            this.cbx_Name.UseVisualStyleBackColor = true;
            this.cbx_Name.CheckedChanged += new System.EventHandler(this.cbx_Name_CheckedChanged);
            // 
            // pb_Cube_Transparent
            // 
            this.pb_Cube_Transparent.BackColor = System.Drawing.Color.Transparent;
            this.pb_Cube_Transparent.Location = new System.Drawing.Point(12, 20);
            this.pb_Cube_Transparent.Name = "pb_Cube_Transparent";
            this.pb_Cube_Transparent.Size = new System.Drawing.Size(105, 57);
            this.pb_Cube_Transparent.TabIndex = 56;
            this.pb_Cube_Transparent.TabStop = false;
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(606, 85);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 450);
            this.pb_Borda_Vert_1.TabIndex = 53;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // lb_Type_Filter
            // 
            this.lb_Type_Filter.AutoSize = true;
            this.lb_Type_Filter.BackColor = System.Drawing.Color.Transparent;
            this.lb_Type_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Type_Filter.Location = new System.Drawing.Point(8, 0);
            this.lb_Type_Filter.Name = "lb_Type_Filter";
            this.lb_Type_Filter.Size = new System.Drawing.Size(95, 20);
            this.lb_Type_Filter.TabIndex = 55;
            this.lb_Type_Filter.Text = "Tipo de filtro";
            // 
            // pb_Borda_Hori_2
            // 
            this.pb_Borda_Hori_2.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_2.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_2.Location = new System.Drawing.Point(619, 65);
            this.pb_Borda_Hori_2.Name = "pb_Borda_Hori_2";
            this.pb_Borda_Hori_2.Size = new System.Drawing.Size(165, 25);
            this.pb_Borda_Hori_2.TabIndex = 54;
            this.pb_Borda_Hori_2.TabStop = false;
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(619, 83);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(165, 378);
            this.sp_Choices.TabIndex = 51;
            this.sp_Choices.TabStop = false;
            // 
            // pb_Borda_Hori_1
            // 
            this.pb_Borda_Hori_1.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_1.Location = new System.Drawing.Point(0, 65);
            this.pb_Borda_Hori_1.Name = "pb_Borda_Hori_1";
            this.pb_Borda_Hori_1.Size = new System.Drawing.Size(623, 25);
            this.pb_Borda_Hori_1.TabIndex = 52;
            this.pb_Borda_Hori_1.TabStop = false;
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToDeleteRows = false;
            this.dgv_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Origin,
            this.Valor});
            this.dgv_Search.Location = new System.Drawing.Point(12, 108);
            this.dgv_Search.MultiSelect = false;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.ReadOnly = true;
            this.dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search.Size = new System.Drawing.Size(575, 341);
            this.dgv_Search.TabIndex = 67;
            // 
            // sp_Menu
            // 
            this.sp_Menu.BackColor = System.Drawing.Color.White;
            this.sp_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sp_Menu.Location = new System.Drawing.Point(0, 0);
            this.sp_Menu.Name = "sp_Menu";
            this.sp_Menu.Size = new System.Drawing.Size(784, 83);
            this.sp_Menu.TabIndex = 69;
            this.sp_Menu.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Search_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bt_Export);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.lb_Filter);
            this.Controls.Add(this.tb_Filter1);
            this.Controls.Add(this.lb_Sum);
            this.Controls.Add(this.tb_Filter2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbx_Name);
            this.Controls.Add(this.pb_Cube_Transparent);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.lb_Type_Filter);
            this.Controls.Add(this.pb_Borda_Hori_2);
            this.Controls.Add(this.sp_Choices);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.sp_Menu);
            this.Controls.Add(this.pb_Borda_Hori_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cube_Transparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Export;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label lb_Filter;
        private System.Windows.Forms.TextBox tb_Filter1;
        private System.Windows.Forms.Label lb_Sum;
        private System.Windows.Forms.TextBox tb_Filter2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbx_Name;
        private System.Windows.Forms.PictureBox pb_Cube_Transparent;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.Label lb_Type_Filter;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_2;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_1;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Splitter sp_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}