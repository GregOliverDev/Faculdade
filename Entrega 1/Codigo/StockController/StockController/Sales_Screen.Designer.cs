namespace StockController
{
    partial class Sales_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Screen));
            this.lb_txt1 = new System.Windows.Forms.Label();
            this.tb_txt1 = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.lb_Quant = new System.Windows.Forms.Label();
            this.tb_Quant = new System.Windows.Forms.TextBox();
            this.tb_Viewer_Produto = new System.Windows.Forms.TextBox();
            this.bt_Search_Product = new System.Windows.Forms.Button();
            this.tb_Product = new System.Windows.Forms.TextBox();
            this.lb_Product = new System.Windows.Forms.Label();
            this.lb_Add = new System.Windows.Forms.Label();
            this.bt_Add_Obj = new System.Windows.Forms.Button();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.bt_Less_Obj = new System.Windows.Forms.Button();
            this.lb_Tot = new System.Windows.Forms.Label();
            this.tb_Tot_Value = new System.Windows.Forms.TextBox();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnitM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplacementCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Search_Supplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_txt1
            // 
            this.lb_txt1.AutoSize = true;
            this.lb_txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt1.Location = new System.Drawing.Point(12, 12);
            this.lb_txt1.Name = "lb_txt1";
            this.lb_txt1.Size = new System.Drawing.Size(62, 20);
            this.lb_txt1.TabIndex = 43;
            this.lb_txt1.Text = "Cliente:";
            // 
            // tb_txt1
            // 
            this.tb_txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_txt1.Location = new System.Drawing.Point(104, 9);
            this.tb_txt1.Name = "tb_txt1";
            this.tb_txt1.Size = new System.Drawing.Size(197, 26);
            this.tb_txt1.TabIndex = 44;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(652, 411);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 46;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(652, 378);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 45;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(631, 0);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(169, 450);
            this.sp_Choices.TabIndex = 47;
            this.sp_Choices.TabStop = false;
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(631, 0);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 528);
            this.pb_Borda_Vert_1.TabIndex = 48;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // lb_Quant
            // 
            this.lb_Quant.AutoSize = true;
            this.lb_Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quant.Location = new System.Drawing.Point(454, 34);
            this.lb_Quant.Name = "lb_Quant";
            this.lb_Quant.Size = new System.Drawing.Size(96, 20);
            this.lb_Quant.TabIndex = 54;
            this.lb_Quant.Text = "Quantidade:";
            // 
            // tb_Quant
            // 
            this.tb_Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quant.Location = new System.Drawing.Point(458, 57);
            this.tb_Quant.Name = "tb_Quant";
            this.tb_Quant.Size = new System.Drawing.Size(153, 26);
            this.tb_Quant.TabIndex = 53;
            this.tb_Quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Quant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPressFloat);
            // 
            // tb_Viewer_Produto
            // 
            this.tb_Viewer_Produto.Enabled = false;
            this.tb_Viewer_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Viewer_Produto.Location = new System.Drawing.Point(208, 57);
            this.tb_Viewer_Produto.Name = "tb_Viewer_Produto";
            this.tb_Viewer_Produto.Size = new System.Drawing.Size(244, 26);
            this.tb_Viewer_Produto.TabIndex = 52;
            this.tb_Viewer_Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_Search_Product
            // 
            this.bt_Search_Product.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_Product.Image")));
            this.bt_Search_Product.Location = new System.Drawing.Point(178, 57);
            this.bt_Search_Product.Name = "bt_Search_Product";
            this.bt_Search_Product.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_Product.TabIndex = 51;
            this.bt_Search_Product.UseVisualStyleBackColor = true;
            this.bt_Search_Product.Click += new System.EventHandler(this.bt_Search_Product_Click);
            // 
            // tb_Product
            // 
            this.tb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product.Location = new System.Drawing.Point(104, 57);
            this.tb_Product.Name = "tb_Product";
            this.tb_Product.Size = new System.Drawing.Size(72, 26);
            this.tb_Product.TabIndex = 50;
            this.tb_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Product.Leave += new System.EventHandler(this.tb_Product_Leave);
            // 
            // lb_Product
            // 
            this.lb_Product.AutoSize = true;
            this.lb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Product.Location = new System.Drawing.Point(12, 60);
            this.lb_Product.Name = "lb_Product";
            this.lb_Product.Size = new System.Drawing.Size(73, 20);
            this.lb_Product.TabIndex = 49;
            this.lb_Product.Text = "Produto: ";
            // 
            // lb_Add
            // 
            this.lb_Add.AutoSize = true;
            this.lb_Add.BackColor = System.Drawing.Color.Transparent;
            this.lb_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add.Location = new System.Drawing.Point(677, 57);
            this.lb_Add.Name = "lb_Add";
            this.lb_Add.Size = new System.Drawing.Size(111, 20);
            this.lb_Add.TabIndex = 56;
            this.lb_Add.Text = "Adicionar Item";
            // 
            // bt_Add_Obj
            // 
            this.bt_Add_Obj.Image = global::StockController.Properties.Resources.addIcon;
            this.bt_Add_Obj.Location = new System.Drawing.Point(650, 54);
            this.bt_Add_Obj.Name = "bt_Add_Obj";
            this.bt_Add_Obj.Size = new System.Drawing.Size(27, 26);
            this.bt_Add_Obj.TabIndex = 55;
            this.bt_Add_Obj.UseVisualStyleBackColor = true;
            this.bt_Add_Obj.Click += new System.EventHandler(this.bt_Add_Obj_Click);
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.BackColor = System.Drawing.Color.Transparent;
            this.lb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Delete.Location = new System.Drawing.Point(677, 85);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(97, 20);
            this.lb_Delete.TabIndex = 59;
            this.lb_Delete.Text = "Deletar Item";
            // 
            // bt_Less_Obj
            // 
            this.bt_Less_Obj.Image = global::StockController.Properties.Resources.lessIcon;
            this.bt_Less_Obj.Location = new System.Drawing.Point(650, 82);
            this.bt_Less_Obj.Name = "bt_Less_Obj";
            this.bt_Less_Obj.Size = new System.Drawing.Size(27, 26);
            this.bt_Less_Obj.TabIndex = 58;
            this.bt_Less_Obj.UseVisualStyleBackColor = true;
            this.bt_Less_Obj.Click += new System.EventHandler(this.bt_Less_Obj_Click);
            // 
            // lb_Tot
            // 
            this.lb_Tot.AutoSize = true;
            this.lb_Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tot.Location = new System.Drawing.Point(369, 414);
            this.lb_Tot.Name = "lb_Tot";
            this.lb_Tot.Size = new System.Drawing.Size(89, 20);
            this.lb_Tot.TabIndex = 60;
            this.lb_Tot.Text = "Valor Total:";
            // 
            // tb_Tot_Value
            // 
            this.tb_Tot_Value.Enabled = false;
            this.tb_Tot_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tot_Value.Location = new System.Drawing.Point(464, 411);
            this.tb_Tot_Value.Name = "tb_Tot_Value";
            this.tb_Tot_Value.Size = new System.Drawing.Size(161, 26);
            this.tb_Tot_Value.TabIndex = 61;
            this.tb_Tot_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.IdCategory,
            this.IdBrand,
            this.idUnitM,
            this.Code,
            this.Description,
            this.NameProduct,
            this.ReplacementCost,
            this.Status,
            this.Value});
            this.dgv_Search.Location = new System.Drawing.Point(16, 114);
            this.dgv_Search.MultiSelect = false;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.ReadOnly = true;
            this.dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Search.Size = new System.Drawing.Size(609, 291);
            this.dgv_Search.TabIndex = 62;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdCategory
            // 
            this.IdCategory.HeaderText = "Categoria";
            this.IdCategory.Name = "IdCategory";
            this.IdCategory.ReadOnly = true;
            this.IdCategory.Visible = false;
            // 
            // IdBrand
            // 
            this.IdBrand.HeaderText = "Marca";
            this.IdBrand.Name = "IdBrand";
            this.IdBrand.ReadOnly = true;
            this.IdBrand.Visible = false;
            // 
            // idUnitM
            // 
            this.idUnitM.HeaderText = "Unitm";
            this.idUnitM.Name = "idUnitM";
            this.idUnitM.ReadOnly = true;
            this.idUnitM.Visible = false;
            // 
            // Code
            // 
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descrição";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Nome";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // ReplacementCost
            // 
            this.ReplacementCost.HeaderText = "Custo Reposição";
            this.ReplacementCost.Name = "ReplacementCost";
            this.ReplacementCost.ReadOnly = true;
            this.ReplacementCost.Visible = false;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Value
            // 
            this.Value.HeaderText = "Valor";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // bt_Search_Supplier
            // 
            this.bt_Search_Supplier.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_Supplier.Image")));
            this.bt_Search_Supplier.Location = new System.Drawing.Point(307, 9);
            this.bt_Search_Supplier.Name = "bt_Search_Supplier";
            this.bt_Search_Supplier.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_Supplier.TabIndex = 63;
            this.bt_Search_Supplier.UseVisualStyleBackColor = true;
            this.bt_Search_Supplier.Click += new System.EventHandler(this.bt_Search_Supplier_Click);
            // 
            // Sales_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Search_Supplier);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.tb_Tot_Value);
            this.Controls.Add(this.lb_Tot);
            this.Controls.Add(this.lb_Delete);
            this.Controls.Add(this.bt_Less_Obj);
            this.Controls.Add(this.lb_Add);
            this.Controls.Add(this.bt_Add_Obj);
            this.Controls.Add(this.lb_Quant);
            this.Controls.Add(this.tb_Quant);
            this.Controls.Add(this.tb_Viewer_Produto);
            this.Controls.Add(this.bt_Search_Product);
            this.Controls.Add(this.tb_Product);
            this.Controls.Add(this.lb_Product);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.tb_txt1);
            this.Controls.Add(this.lb_txt1);
            this.Controls.Add(this.sp_Choices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sales_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_Screen_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_txt1;
        private System.Windows.Forms.TextBox tb_txt1;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.Label lb_Quant;
        private System.Windows.Forms.TextBox tb_Quant;
        private System.Windows.Forms.TextBox tb_Viewer_Produto;
        private System.Windows.Forms.Button bt_Search_Product;
        private System.Windows.Forms.TextBox tb_Product;
        private System.Windows.Forms.Label lb_Product;
        private System.Windows.Forms.Label lb_Add;
        private System.Windows.Forms.Button bt_Add_Obj;
        private System.Windows.Forms.Label lb_Delete;
        private System.Windows.Forms.Button bt_Less_Obj;
        private System.Windows.Forms.Label lb_Tot;
        private System.Windows.Forms.TextBox tb_Tot_Value;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Button bt_Search_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnitM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplacementCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}