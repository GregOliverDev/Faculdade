namespace StockController
{
    partial class Product_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Screen));
            this.lb_Name_Product = new System.Windows.Forms.Label();
            this.menu_Product = new System.Windows.Forms.MenuStrip();
            this.ts_Search_Code = new System.Windows.Forms.ToolStripTextBox();
            this.tb_Name_Product = new System.Windows.Forms.TextBox();
            this.tb_Category_Product = new System.Windows.Forms.TextBox();
            this.lb_Category_Product = new System.Windows.Forms.Label();
            this.tb_Value_Product = new System.Windows.Forms.TextBox();
            this.lb_Value_Product = new System.Windows.Forms.Label();
            this.lb_Cost_Product = new System.Windows.Forms.Label();
            this.tb_Cost_Product = new System.Windows.Forms.TextBox();
            this.tb_Descri_Product = new System.Windows.Forms.TextBox();
            this.lb_Descri_Product = new System.Windows.Forms.Label();
            this.lb_Status_Product = new System.Windows.Forms.Label();
            this.sp_Choices = new System.Windows.Forms.Splitter();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.tb_Brand_Product = new System.Windows.Forms.TextBox();
            this.lb_Brand_Product = new System.Windows.Forms.Label();
            this.tb_Viewer_Brand = new System.Windows.Forms.TextBox();
            this.tb_Viewer_Category = new System.Windows.Forms.TextBox();
            this.bt_Batches = new System.Windows.Forms.Button();
            this.bt_Supplier_Codes = new System.Windows.Forms.Button();
            this.lb_Use_Batch = new System.Windows.Forms.Label();
            this.cbx_Use_Batch = new System.Windows.Forms.CheckBox();
            this.bt_Barcode = new System.Windows.Forms.Button();
            this.cbx_Inactive = new System.Windows.Forms.CheckBox();
            this.cbx_Active = new System.Windows.Forms.CheckBox();
            this.pb_Cube_Transparent = new System.Windows.Forms.PictureBox();
            this.bt_Search_Brand = new System.Windows.Forms.Button();
            this.pb_Borda_Vert_1 = new System.Windows.Forms.PictureBox();
            this.pb_Borda_Hori_2 = new System.Windows.Forms.PictureBox();
            this.bt_New_Product = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Search_Category = new System.Windows.Forms.Button();
            this.pb_Borda_Hori_1 = new System.Windows.Forms.PictureBox();
            this.tb_Viewer_UnitM = new System.Windows.Forms.TextBox();
            this.bt_Search_UnitM = new System.Windows.Forms.Button();
            this.lb_UnitM = new System.Windows.Forms.Label();
            this.tb_UnitM_Product = new System.Windows.Forms.TextBox();
            this.menu_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cube_Transparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Name_Product
            // 
            this.lb_Name_Product.AutoSize = true;
            this.lb_Name_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name_Product.Location = new System.Drawing.Point(12, 41);
            this.lb_Name_Product.Name = "lb_Name_Product";
            this.lb_Name_Product.Size = new System.Drawing.Size(55, 20);
            this.lb_Name_Product.TabIndex = 0;
            this.lb_Name_Product.Text = "Nome:";
            // 
            // menu_Product
            // 
            this.menu_Product.BackColor = System.Drawing.Color.White;
            this.menu_Product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Search_Code});
            this.menu_Product.Location = new System.Drawing.Point(0, 0);
            this.menu_Product.Name = "menu_Product";
            this.menu_Product.Size = new System.Drawing.Size(672, 27);
            this.menu_Product.TabIndex = 2;
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
            // tb_Name_Product
            // 
            this.tb_Name_Product.Enabled = false;
            this.tb_Name_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name_Product.Location = new System.Drawing.Point(73, 38);
            this.tb_Name_Product.Name = "tb_Name_Product";
            this.tb_Name_Product.Size = new System.Drawing.Size(412, 26);
            this.tb_Name_Product.TabIndex = 5;
            // 
            // tb_Category_Product
            // 
            this.tb_Category_Product.Enabled = false;
            this.tb_Category_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Product.Location = new System.Drawing.Point(104, 81);
            this.tb_Category_Product.Name = "tb_Category_Product";
            this.tb_Category_Product.Size = new System.Drawing.Size(94, 26);
            this.tb_Category_Product.TabIndex = 7;
            this.tb_Category_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Category_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            this.tb_Category_Product.Leave += new System.EventHandler(this.tb_Category_Product_Leave);
            // 
            // lb_Category_Product
            // 
            this.lb_Category_Product.AutoSize = true;
            this.lb_Category_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Category_Product.Location = new System.Drawing.Point(12, 84);
            this.lb_Category_Product.Name = "lb_Category_Product";
            this.lb_Category_Product.Size = new System.Drawing.Size(86, 20);
            this.lb_Category_Product.TabIndex = 6;
            this.lb_Category_Product.Text = "Categoria: ";
            // 
            // tb_Value_Product
            // 
            this.tb_Value_Product.Enabled = false;
            this.tb_Value_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Value_Product.Location = new System.Drawing.Point(119, 186);
            this.tb_Value_Product.Name = "tb_Value_Product";
            this.tb_Value_Product.Size = new System.Drawing.Size(107, 26);
            this.tb_Value_Product.TabIndex = 11;
            this.tb_Value_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_Value_Product
            // 
            this.lb_Value_Product.AutoSize = true;
            this.lb_Value_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Value_Product.Location = new System.Drawing.Point(12, 189);
            this.lb_Value_Product.Name = "lb_Value_Product";
            this.lb_Value_Product.Size = new System.Drawing.Size(101, 20);
            this.lb_Value_Product.TabIndex = 10;
            this.lb_Value_Product.Text = "Valor Venda:";
            // 
            // lb_Cost_Product
            // 
            this.lb_Cost_Product.AutoSize = true;
            this.lb_Cost_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cost_Product.Location = new System.Drawing.Point(232, 189);
            this.lb_Cost_Product.Name = "lb_Cost_Product";
            this.lb_Cost_Product.Size = new System.Drawing.Size(135, 20);
            this.lb_Cost_Product.TabIndex = 12;
            this.lb_Cost_Product.Text = "Custo Reposição:";
            // 
            // tb_Cost_Product
            // 
            this.tb_Cost_Product.Enabled = false;
            this.tb_Cost_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cost_Product.Location = new System.Drawing.Point(368, 186);
            this.tb_Cost_Product.Name = "tb_Cost_Product";
            this.tb_Cost_Product.Size = new System.Drawing.Size(117, 26);
            this.tb_Cost_Product.TabIndex = 13;
            this.tb_Cost_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Descri_Product
            // 
            this.tb_Descri_Product.Enabled = false;
            this.tb_Descri_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descri_Product.Location = new System.Drawing.Point(16, 270);
            this.tb_Descri_Product.Multiline = true;
            this.tb_Descri_Product.Name = "tb_Descri_Product";
            this.tb_Descri_Product.Size = new System.Drawing.Size(469, 129);
            this.tb_Descri_Product.TabIndex = 15;
            // 
            // lb_Descri_Product
            // 
            this.lb_Descri_Product.AutoSize = true;
            this.lb_Descri_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Descri_Product.Location = new System.Drawing.Point(12, 247);
            this.lb_Descri_Product.Name = "lb_Descri_Product";
            this.lb_Descri_Product.Size = new System.Drawing.Size(84, 20);
            this.lb_Descri_Product.TabIndex = 14;
            this.lb_Descri_Product.Text = "Descrição:";
            // 
            // lb_Status_Product
            // 
            this.lb_Status_Product.AutoSize = true;
            this.lb_Status_Product.BackColor = System.Drawing.Color.White;
            this.lb_Status_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status_Product.Location = new System.Drawing.Point(518, 41);
            this.lb_Status_Product.Name = "lb_Status_Product";
            this.lb_Status_Product.Size = new System.Drawing.Size(56, 20);
            this.lb_Status_Product.TabIndex = 17;
            this.lb_Status_Product.Text = "Status";
            // 
            // sp_Choices
            // 
            this.sp_Choices.BackColor = System.Drawing.Color.White;
            this.sp_Choices.Dock = System.Windows.Forms.DockStyle.Right;
            this.sp_Choices.Location = new System.Drawing.Point(498, 27);
            this.sp_Choices.Name = "sp_Choices";
            this.sp_Choices.Size = new System.Drawing.Size(174, 384);
            this.sp_Choices.TabIndex = 18;
            this.sp_Choices.TabStop = false;
            // 
            // bt_Save
            // 
            this.bt_Save.Enabled = false;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(522, 298);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 21;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(522, 331);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 22;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(522, 364);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(138, 27);
            this.bt_Delete.TabIndex = 23;
            this.bt_Delete.Text = "Excluir";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // tb_Brand_Product
            // 
            this.tb_Brand_Product.Enabled = false;
            this.tb_Brand_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_Product.Location = new System.Drawing.Point(73, 113);
            this.tb_Brand_Product.Name = "tb_Brand_Product";
            this.tb_Brand_Product.Size = new System.Drawing.Size(125, 26);
            this.tb_Brand_Product.TabIndex = 25;
            this.tb_Brand_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Brand_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            this.tb_Brand_Product.Leave += new System.EventHandler(this.tb_Brand_Product_Leave);
            // 
            // lb_Brand_Product
            // 
            this.lb_Brand_Product.AutoSize = true;
            this.lb_Brand_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Brand_Product.Location = new System.Drawing.Point(12, 116);
            this.lb_Brand_Product.Name = "lb_Brand_Product";
            this.lb_Brand_Product.Size = new System.Drawing.Size(61, 20);
            this.lb_Brand_Product.TabIndex = 24;
            this.lb_Brand_Product.Text = "Marca: ";
            // 
            // tb_Viewer_Brand
            // 
            this.tb_Viewer_Brand.Enabled = false;
            this.tb_Viewer_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Viewer_Brand.Location = new System.Drawing.Point(236, 113);
            this.tb_Viewer_Brand.Name = "tb_Viewer_Brand";
            this.tb_Viewer_Brand.Size = new System.Drawing.Size(249, 26);
            this.tb_Viewer_Brand.TabIndex = 27;
            // 
            // tb_Viewer_Category
            // 
            this.tb_Viewer_Category.Enabled = false;
            this.tb_Viewer_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Viewer_Category.Location = new System.Drawing.Point(236, 80);
            this.tb_Viewer_Category.Name = "tb_Viewer_Category";
            this.tb_Viewer_Category.Size = new System.Drawing.Size(249, 26);
            this.tb_Viewer_Category.TabIndex = 28;
            // 
            // bt_Batches
            // 
            this.bt_Batches.Enabled = false;
            this.bt_Batches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Batches.Location = new System.Drawing.Point(522, 137);
            this.bt_Batches.Name = "bt_Batches";
            this.bt_Batches.Size = new System.Drawing.Size(138, 27);
            this.bt_Batches.TabIndex = 30;
            this.bt_Batches.Text = "Lotes";
            this.bt_Batches.UseVisualStyleBackColor = true;
            this.bt_Batches.Visible = false;
            this.bt_Batches.Click += new System.EventHandler(this.bt_Batches_Click);
            // 
            // bt_Supplier_Codes
            // 
            this.bt_Supplier_Codes.Enabled = false;
            this.bt_Supplier_Codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Supplier_Codes.Location = new System.Drawing.Point(522, 170);
            this.bt_Supplier_Codes.Name = "bt_Supplier_Codes";
            this.bt_Supplier_Codes.Size = new System.Drawing.Size(138, 59);
            this.bt_Supplier_Codes.TabIndex = 31;
            this.bt_Supplier_Codes.Text = "Codigos Fornecedor";
            this.bt_Supplier_Codes.UseVisualStyleBackColor = true;
            this.bt_Supplier_Codes.Click += new System.EventHandler(this.bt_Supplier_Codes_Click);
            // 
            // lb_Use_Batch
            // 
            this.lb_Use_Batch.AutoSize = true;
            this.lb_Use_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Use_Batch.Location = new System.Drawing.Point(12, 218);
            this.lb_Use_Batch.Name = "lb_Use_Batch";
            this.lb_Use_Batch.Size = new System.Drawing.Size(78, 20);
            this.lb_Use_Batch.TabIndex = 29;
            this.lb_Use_Batch.Text = "Usa Lote:";
            // 
            // cbx_Use_Batch
            // 
            this.cbx_Use_Batch.AutoSize = true;
            this.cbx_Use_Batch.Enabled = false;
            this.cbx_Use_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Use_Batch.Location = new System.Drawing.Point(96, 218);
            this.cbx_Use_Batch.Name = "cbx_Use_Batch";
            this.cbx_Use_Batch.Size = new System.Drawing.Size(55, 24);
            this.cbx_Use_Batch.TabIndex = 32;
            this.cbx_Use_Batch.Text = "Sim";
            this.cbx_Use_Batch.UseVisualStyleBackColor = true;
            this.cbx_Use_Batch.CheckedChanged += new System.EventHandler(this.cbx_Use_Batch_CheckedChanged);
            // 
            // bt_Barcode
            // 
            this.bt_Barcode.Enabled = false;
            this.bt_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Barcode.Location = new System.Drawing.Point(522, 235);
            this.bt_Barcode.Name = "bt_Barcode";
            this.bt_Barcode.Size = new System.Drawing.Size(138, 32);
            this.bt_Barcode.TabIndex = 33;
            this.bt_Barcode.Text = "Codigo de Barra";
            this.bt_Barcode.UseVisualStyleBackColor = true;
            this.bt_Barcode.Click += new System.EventHandler(this.bt_Barcode_Click);
            // 
            // cbx_Inactive
            // 
            this.cbx_Inactive.AutoSize = true;
            this.cbx_Inactive.Enabled = false;
            this.cbx_Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Inactive.Location = new System.Drawing.Point(526, 94);
            this.cbx_Inactive.Name = "cbx_Inactive";
            this.cbx_Inactive.Size = new System.Drawing.Size(75, 24);
            this.cbx_Inactive.TabIndex = 42;
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
            this.cbx_Active.TabIndex = 41;
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
            this.pb_Cube_Transparent.TabIndex = 40;
            this.pb_Cube_Transparent.TabStop = false;
            // 
            // bt_Search_Brand
            // 
            this.bt_Search_Brand.Enabled = false;
            this.bt_Search_Brand.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_Brand.Image")));
            this.bt_Search_Brand.Location = new System.Drawing.Point(198, 112);
            this.bt_Search_Brand.Name = "bt_Search_Brand";
            this.bt_Search_Brand.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_Brand.TabIndex = 26;
            this.bt_Search_Brand.UseVisualStyleBackColor = true;
            this.bt_Search_Brand.Click += new System.EventHandler(this.bt_Search_Brand_Click);
            // 
            // pb_Borda_Vert_1
            // 
            this.pb_Borda_Vert_1.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Vert_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_Borda_Vert_1.Image")));
            this.pb_Borda_Vert_1.Location = new System.Drawing.Point(491, 29);
            this.pb_Borda_Vert_1.Name = "pb_Borda_Vert_1";
            this.pb_Borda_Vert_1.Size = new System.Drawing.Size(13, 384);
            this.pb_Borda_Vert_1.TabIndex = 20;
            this.pb_Borda_Vert_1.TabStop = false;
            // 
            // pb_Borda_Hori_2
            // 
            this.pb_Borda_Hori_2.BackColor = System.Drawing.Color.White;
            this.pb_Borda_Hori_2.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_2.Location = new System.Drawing.Point(498, 9);
            this.pb_Borda_Hori_2.Name = "pb_Borda_Hori_2";
            this.pb_Borda_Hori_2.Size = new System.Drawing.Size(174, 25);
            this.pb_Borda_Hori_2.TabIndex = 19;
            this.pb_Borda_Hori_2.TabStop = false;
            // 
            // bt_New_Product
            // 
            this.bt_New_Product.Image = global::StockController.Properties.Resources.addIcon;
            this.bt_New_Product.Location = new System.Drawing.Point(142, 1);
            this.bt_New_Product.Name = "bt_New_Product";
            this.bt_New_Product.Size = new System.Drawing.Size(27, 26);
            this.bt_New_Product.TabIndex = 4;
            this.bt_New_Product.UseVisualStyleBackColor = true;
            this.bt_New_Product.Click += new System.EventHandler(this.bt_New_Product_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search.Image")));
            this.bt_Search.Location = new System.Drawing.Point(109, 1);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(27, 26);
            this.bt_Search.TabIndex = 3;
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Search_Category
            // 
            this.bt_Search_Category.Enabled = false;
            this.bt_Search_Category.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_Category.Image")));
            this.bt_Search_Category.Location = new System.Drawing.Point(198, 80);
            this.bt_Search_Category.Name = "bt_Search_Category";
            this.bt_Search_Category.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_Category.TabIndex = 8;
            this.bt_Search_Category.UseVisualStyleBackColor = true;
            this.bt_Search_Category.Click += new System.EventHandler(this.bt_Search_Category_Click);
            // 
            // pb_Borda_Hori_1
            // 
            this.pb_Borda_Hori_1.Image = global::StockController.Properties.Resources.BordaHori1;
            this.pb_Borda_Hori_1.Location = new System.Drawing.Point(0, 9);
            this.pb_Borda_Hori_1.Name = "pb_Borda_Hori_1";
            this.pb_Borda_Hori_1.Size = new System.Drawing.Size(804, 25);
            this.pb_Borda_Hori_1.TabIndex = 9;
            this.pb_Borda_Hori_1.TabStop = false;
            // 
            // tb_Viewer_UnitM
            // 
            this.tb_Viewer_UnitM.Enabled = false;
            this.tb_Viewer_UnitM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Viewer_UnitM.Location = new System.Drawing.Point(236, 146);
            this.tb_Viewer_UnitM.Name = "tb_Viewer_UnitM";
            this.tb_Viewer_UnitM.Size = new System.Drawing.Size(249, 26);
            this.tb_Viewer_UnitM.TabIndex = 46;
            // 
            // bt_Search_UnitM
            // 
            this.bt_Search_UnitM.Enabled = false;
            this.bt_Search_UnitM.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_UnitM.Image")));
            this.bt_Search_UnitM.Location = new System.Drawing.Point(198, 144);
            this.bt_Search_UnitM.Name = "bt_Search_UnitM";
            this.bt_Search_UnitM.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_UnitM.TabIndex = 45;
            this.bt_Search_UnitM.UseVisualStyleBackColor = true;
            this.bt_Search_UnitM.Click += new System.EventHandler(this.bt_Search_UnitM_Click);
            // 
            // lb_UnitM
            // 
            this.lb_UnitM.AutoSize = true;
            this.lb_UnitM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UnitM.Location = new System.Drawing.Point(12, 148);
            this.lb_UnitM.Name = "lb_UnitM";
            this.lb_UnitM.Size = new System.Drawing.Size(73, 20);
            this.lb_UnitM.TabIndex = 43;
            this.lb_UnitM.Text = "Unidade:";
            // 
            // tb_UnitM_Product
            // 
            this.tb_UnitM_Product.Enabled = false;
            this.tb_UnitM_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UnitM_Product.Location = new System.Drawing.Point(104, 145);
            this.tb_UnitM_Product.Name = "tb_UnitM_Product";
            this.tb_UnitM_Product.Size = new System.Drawing.Size(94, 26);
            this.tb_UnitM_Product.TabIndex = 47;
            this.tb_UnitM_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_UnitM_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            this.tb_UnitM_Product.Leave += new System.EventHandler(this.tb_UnitM_Product_Leave);
            // 
            // Product_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 411);
            this.Controls.Add(this.tb_UnitM_Product);
            this.Controls.Add(this.tb_Viewer_UnitM);
            this.Controls.Add(this.bt_Search_UnitM);
            this.Controls.Add(this.lb_UnitM);
            this.Controls.Add(this.cbx_Inactive);
            this.Controls.Add(this.cbx_Active);
            this.Controls.Add(this.pb_Cube_Transparent);
            this.Controls.Add(this.bt_Barcode);
            this.Controls.Add(this.cbx_Use_Batch);
            this.Controls.Add(this.bt_Supplier_Codes);
            this.Controls.Add(this.bt_Batches);
            this.Controls.Add(this.lb_Use_Batch);
            this.Controls.Add(this.tb_Viewer_Category);
            this.Controls.Add(this.tb_Viewer_Brand);
            this.Controls.Add(this.bt_Search_Brand);
            this.Controls.Add(this.tb_Brand_Product);
            this.Controls.Add(this.lb_Brand_Product);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.pb_Borda_Vert_1);
            this.Controls.Add(this.pb_Borda_Hori_2);
            this.Controls.Add(this.bt_New_Product);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.lb_Status_Product);
            this.Controls.Add(this.tb_Descri_Product);
            this.Controls.Add(this.lb_Descri_Product);
            this.Controls.Add(this.tb_Cost_Product);
            this.Controls.Add(this.lb_Cost_Product);
            this.Controls.Add(this.tb_Value_Product);
            this.Controls.Add(this.lb_Value_Product);
            this.Controls.Add(this.bt_Search_Category);
            this.Controls.Add(this.tb_Category_Product);
            this.Controls.Add(this.lb_Category_Product);
            this.Controls.Add(this.tb_Name_Product);
            this.Controls.Add(this.lb_Name_Product);
            this.Controls.Add(this.sp_Choices);
            this.Controls.Add(this.menu_Product);
            this.Controls.Add(this.pb_Borda_Hori_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Product;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Produto";
            this.menu_Product.ResumeLayout(false);
            this.menu_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cube_Transparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Vert_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Borda_Hori_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name_Product;
        private System.Windows.Forms.MenuStrip menu_Product;
        private System.Windows.Forms.ToolStripTextBox ts_Search_Code;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_New_Product;
        private System.Windows.Forms.TextBox tb_Name_Product;
        private System.Windows.Forms.TextBox tb_Category_Product;
        private System.Windows.Forms.Label lb_Category_Product;
        private System.Windows.Forms.Button bt_Search_Category;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_1;
        private System.Windows.Forms.TextBox tb_Value_Product;
        private System.Windows.Forms.Label lb_Value_Product;
        private System.Windows.Forms.Label lb_Cost_Product;
        private System.Windows.Forms.TextBox tb_Cost_Product;
        private System.Windows.Forms.TextBox tb_Descri_Product;
        private System.Windows.Forms.Label lb_Descri_Product;
        private System.Windows.Forms.Label lb_Status_Product;
        private System.Windows.Forms.Splitter sp_Choices;
        private System.Windows.Forms.PictureBox pb_Borda_Hori_2;
        private System.Windows.Forms.PictureBox pb_Borda_Vert_1;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Search_Brand;
        private System.Windows.Forms.TextBox tb_Brand_Product;
        private System.Windows.Forms.Label lb_Brand_Product;
        private System.Windows.Forms.TextBox tb_Viewer_Brand;
        private System.Windows.Forms.TextBox tb_Viewer_Category;
        private System.Windows.Forms.Button bt_Batches;
        private System.Windows.Forms.Button bt_Supplier_Codes;
        private System.Windows.Forms.Label lb_Use_Batch;
        private System.Windows.Forms.CheckBox cbx_Use_Batch;
        private System.Windows.Forms.Button bt_Barcode;
        private System.Windows.Forms.CheckBox cbx_Inactive;
        private System.Windows.Forms.CheckBox cbx_Active;
        private System.Windows.Forms.PictureBox pb_Cube_Transparent;
        private System.Windows.Forms.TextBox tb_Viewer_UnitM;
        private System.Windows.Forms.Button bt_Search_UnitM;
        private System.Windows.Forms.Label lb_UnitM;
        private System.Windows.Forms.TextBox tb_UnitM_Product;
    }
}