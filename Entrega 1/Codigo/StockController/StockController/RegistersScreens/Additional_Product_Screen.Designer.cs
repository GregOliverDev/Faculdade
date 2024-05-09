namespace StockController
{
    partial class Additional_Product_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additional_Product_Screen));
            this.bt_Back = new System.Windows.Forms.Button();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.lb_Code1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lb_Code2 = new System.Windows.Forms.Label();
            this.lb_Add = new System.Windows.Forms.Label();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.bt_Less_Obj = new System.Windows.Forms.Button();
            this.bt_Add_Obj = new System.Windows.Forms.Button();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.bt_Search_Supplier = new System.Windows.Forms.Button();
            this.dtp_Date1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date2 = new System.Windows.Forms.DateTimePicker();
            this.lb_Code3 = new System.Windows.Forms.Label();
            this.lb_Code4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Back
            // 
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.Location = new System.Drawing.Point(522, 308);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(138, 27);
            this.bt_Back.TabIndex = 26;
            this.bt_Back.Text = "Voltar";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(498, 0);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(174, 347);
            this.sp_Choices.TabIndex = 23;
            this.sp_Choices.TabStop = false;
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
            this.Cod1,
            this.Cod2,
            this.Cod3,
            this.Cod4,
            this.Cod5});
            this.dgv_Search.Location = new System.Drawing.Point(12, 177);
            this.dgv_Search.MultiSelect = false;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.ReadOnly = true;
            this.dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search.Size = new System.Drawing.Size(480, 158);
            this.dgv_Search.TabIndex = 27;
            // 
            // lb_Code1
            // 
            this.lb_Code1.AutoSize = true;
            this.lb_Code1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Code1.Location = new System.Drawing.Point(12, 9);
            this.lb_Code1.Name = "lb_Code1";
            this.lb_Code1.Size = new System.Drawing.Size(72, 20);
            this.lb_Code1.TabIndex = 28;
            this.lb_Code1.Text = "Codigo 1";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(115, 6);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(333, 26);
            this.tb1.TabIndex = 29;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(115, 50);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(333, 26);
            this.tb2.TabIndex = 31;
            // 
            // lb_Code2
            // 
            this.lb_Code2.AutoSize = true;
            this.lb_Code2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Code2.Location = new System.Drawing.Point(12, 53);
            this.lb_Code2.Name = "lb_Code2";
            this.lb_Code2.Size = new System.Drawing.Size(72, 20);
            this.lb_Code2.TabIndex = 30;
            this.lb_Code2.Text = "Codigo 2";
            // 
            // lb_Add
            // 
            this.lb_Add.AutoSize = true;
            this.lb_Add.BackColor = System.Drawing.Color.Transparent;
            this.lb_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add.Location = new System.Drawing.Point(549, 215);
            this.lb_Add.Name = "lb_Add";
            this.lb_Add.Size = new System.Drawing.Size(111, 20);
            this.lb_Add.TabIndex = 33;
            this.lb_Add.Text = "Adicionar Item";
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.BackColor = System.Drawing.Color.Transparent;
            this.lb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Delete.Location = new System.Drawing.Point(549, 253);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(97, 20);
            this.lb_Delete.TabIndex = 35;
            this.lb_Delete.Text = "Deletar Item";
            // 
            // bt_Less_Obj
            // 
            this.bt_Less_Obj.Image = global::StockController.Properties.Resources.lessIcon;
            this.bt_Less_Obj.Location = new System.Drawing.Point(522, 250);
            this.bt_Less_Obj.Name = "bt_Less_Obj";
            this.bt_Less_Obj.Size = new System.Drawing.Size(27, 26);
            this.bt_Less_Obj.TabIndex = 34;
            this.bt_Less_Obj.UseVisualStyleBackColor = true;
            this.bt_Less_Obj.Click += new System.EventHandler(this.bt_Less_Obj_Click);
            // 
            // bt_Add_Obj
            // 
            this.bt_Add_Obj.Image = global::StockController.Properties.Resources.addIcon;
            this.bt_Add_Obj.Location = new System.Drawing.Point(522, 212);
            this.bt_Add_Obj.Name = "bt_Add_Obj";
            this.bt_Add_Obj.Size = new System.Drawing.Size(27, 26);
            this.bt_Add_Obj.TabIndex = 32;
            this.bt_Add_Obj.UseVisualStyleBackColor = true;
            this.bt_Add_Obj.Click += new System.EventHandler(this.bt_Add_Obj_Click);
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(498, -17);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 483);
            this.pb_Borda_Vert_1.TabIndex = 24;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // bt_Search_Supplier
            // 
            this.bt_Search_Supplier.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_Supplier.Image")));
            this.bt_Search_Supplier.Location = new System.Drawing.Point(454, 6);
            this.bt_Search_Supplier.Name = "bt_Search_Supplier";
            this.bt_Search_Supplier.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_Supplier.TabIndex = 36;
            this.bt_Search_Supplier.UseVisualStyleBackColor = true;
            this.bt_Search_Supplier.Click += new System.EventHandler(this.bt_Search_Supplier_Click);
            // 
            // dtp_Date1
            // 
            this.dtp_Date1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date1.Location = new System.Drawing.Point(165, 97);
            this.dtp_Date1.Name = "dtp_Date1";
            this.dtp_Date1.Size = new System.Drawing.Size(136, 20);
            this.dtp_Date1.TabIndex = 37;
            // 
            // dtp_Date2
            // 
            this.dtp_Date2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date2.Location = new System.Drawing.Point(165, 134);
            this.dtp_Date2.Name = "dtp_Date2";
            this.dtp_Date2.Size = new System.Drawing.Size(136, 20);
            this.dtp_Date2.TabIndex = 38;
            // 
            // lb_Code3
            // 
            this.lb_Code3.AutoSize = true;
            this.lb_Code3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Code3.Location = new System.Drawing.Point(12, 97);
            this.lb_Code3.Name = "lb_Code3";
            this.lb_Code3.Size = new System.Drawing.Size(72, 20);
            this.lb_Code3.TabIndex = 39;
            this.lb_Code3.Text = "Codigo 3";
            // 
            // lb_Code4
            // 
            this.lb_Code4.AutoSize = true;
            this.lb_Code4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Code4.Location = new System.Drawing.Point(12, 134);
            this.lb_Code4.Name = "lb_Code4";
            this.lb_Code4.Size = new System.Drawing.Size(72, 20);
            this.lb_Code4.TabIndex = 40;
            this.lb_Code4.Text = "Codigo 4";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Cod1
            // 
            this.Cod1.HeaderText = "Code1";
            this.Cod1.Name = "Cod1";
            this.Cod1.ReadOnly = true;
            // 
            // Cod2
            // 
            this.Cod2.HeaderText = "Code2";
            this.Cod2.Name = "Cod2";
            this.Cod2.ReadOnly = true;
            // 
            // Cod3
            // 
            this.Cod3.HeaderText = "Code3";
            this.Cod3.Name = "Cod3";
            this.Cod3.ReadOnly = true;
            this.Cod3.Visible = false;
            // 
            // Cod4
            // 
            this.Cod4.HeaderText = "Code4";
            this.Cod4.Name = "Cod4";
            this.Cod4.ReadOnly = true;
            this.Cod4.Visible = false;
            // 
            // Cod5
            // 
            this.Cod5.HeaderText = "Code5";
            this.Cod5.Name = "Cod5";
            this.Cod5.ReadOnly = true;
            this.Cod5.Visible = false;
            // 
            // Additional_Product_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 347);
            this.Controls.Add(this.lb_Code4);
            this.Controls.Add(this.lb_Code3);
            this.Controls.Add(this.dtp_Date2);
            this.Controls.Add(this.dtp_Date1);
            this.Controls.Add(this.bt_Search_Supplier);
            this.Controls.Add(this.lb_Delete);
            this.Controls.Add(this.bt_Less_Obj);
            this.Controls.Add(this.lb_Add);
            this.Controls.Add(this.bt_Add_Obj);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.lb_Code2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb_Code1);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.sp_Choices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Additional_Product_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de ";
            this.Load += new System.EventHandler(this.Additional_Product_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Label lb_Code1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label lb_Code2;
        private System.Windows.Forms.Button bt_Add_Obj;
        private System.Windows.Forms.Label lb_Add;
        private System.Windows.Forms.Label lb_Delete;
        private System.Windows.Forms.Button bt_Less_Obj;
        private System.Windows.Forms.Button bt_Search_Supplier;
        private System.Windows.Forms.DateTimePicker dtp_Date1;
        private System.Windows.Forms.DateTimePicker dtp_Date2;
        private System.Windows.Forms.Label lb_Code3;
        private System.Windows.Forms.Label lb_Code4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod5;
    }
}