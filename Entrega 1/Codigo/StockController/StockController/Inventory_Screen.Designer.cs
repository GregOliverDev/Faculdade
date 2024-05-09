namespace StockController
{
    partial class Inventory_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Screen));
            this.bt_Save = new System.Windows.Forms.Button();
            this.tb_Viewer_Produto = new System.Windows.Forms.TextBox();
            this.bt_Search_Product = new System.Windows.Forms.Button();
            this.tb_Product = new System.Windows.Forms.TextBox();
            this.lb_Product = new System.Windows.Forms.Label();
            this.tb_Stock_Current = new System.Windows.Forms.TextBox();
            this.tb_New_Stock = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.lb_Quant_Current = new System.Windows.Forms.Label();
            this.lb_New_Quant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.Enabled = false;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(497, 85);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(138, 27);
            this.bt_Save.TabIndex = 34;
            this.bt_Save.Text = "Gravar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // tb_Viewer_Produto
            // 
            this.tb_Viewer_Produto.Enabled = false;
            this.tb_Viewer_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Viewer_Produto.Location = new System.Drawing.Point(209, 42);
            this.tb_Viewer_Produto.Name = "tb_Viewer_Produto";
            this.tb_Viewer_Produto.Size = new System.Drawing.Size(249, 26);
            this.tb_Viewer_Produto.TabIndex = 38;
            // 
            // bt_Search_Product
            // 
            this.bt_Search_Product.Image = ((System.Drawing.Image)(resources.GetObject("bt_Search_Product.Image")));
            this.bt_Search_Product.Location = new System.Drawing.Point(178, 42);
            this.bt_Search_Product.Name = "bt_Search_Product";
            this.bt_Search_Product.Size = new System.Drawing.Size(28, 28);
            this.bt_Search_Product.TabIndex = 37;
            this.bt_Search_Product.UseVisualStyleBackColor = true;
            this.bt_Search_Product.Click += new System.EventHandler(this.bt_Search_Product_Click);
            // 
            // tb_Product
            // 
            this.tb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product.Location = new System.Drawing.Point(82, 42);
            this.tb_Product.Name = "tb_Product";
            this.tb_Product.Size = new System.Drawing.Size(94, 26);
            this.tb_Product.TabIndex = 36;
            this.tb_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPress);
            this.tb_Product.Leave += new System.EventHandler(this.tb_Product_Leave);
            // 
            // lb_Product
            // 
            this.lb_Product.AutoSize = true;
            this.lb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Product.Location = new System.Drawing.Point(12, 45);
            this.lb_Product.Name = "lb_Product";
            this.lb_Product.Size = new System.Drawing.Size(73, 20);
            this.lb_Product.TabIndex = 35;
            this.lb_Product.Text = "Produto: ";
            // 
            // tb_Stock_Current
            // 
            this.tb_Stock_Current.Enabled = false;
            this.tb_Stock_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_Current.Location = new System.Drawing.Point(464, 42);
            this.tb_Stock_Current.Name = "tb_Stock_Current";
            this.tb_Stock_Current.Size = new System.Drawing.Size(153, 26);
            this.tb_Stock_Current.TabIndex = 39;
            this.tb_Stock_Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_New_Stock
            // 
            this.tb_New_Stock.Enabled = false;
            this.tb_New_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock.Location = new System.Drawing.Point(623, 42);
            this.tb_New_Stock.Name = "tb_New_Stock";
            this.tb_New_Stock.Size = new System.Drawing.Size(165, 26);
            this.tb_New_Stock.TabIndex = 40;
            this.tb_New_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_New_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ts_Search_Code_KeyPressFloat);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Enabled = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(650, 85);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(138, 27);
            this.bt_Cancel.TabIndex = 41;
            this.bt_Cancel.Text = "Cancelar";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_Quant_Current
            // 
            this.lb_Quant_Current.AutoSize = true;
            this.lb_Quant_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quant_Current.Location = new System.Drawing.Point(460, 19);
            this.lb_Quant_Current.Name = "lb_Quant_Current";
            this.lb_Quant_Current.Size = new System.Drawing.Size(133, 20);
            this.lb_Quant_Current.TabIndex = 42;
            this.lb_Quant_Current.Text = "Quantidade Atual";
            // 
            // lb_New_Quant
            // 
            this.lb_New_Quant.AutoSize = true;
            this.lb_New_Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_New_Quant.Location = new System.Drawing.Point(619, 19);
            this.lb_New_Quant.Name = "lb_New_Quant";
            this.lb_New_Quant.Size = new System.Drawing.Size(132, 20);
            this.lb_New_Quant.TabIndex = 43;
            this.lb_New_Quant.Text = "Nova Quantidade";
            // 
            // Inventory_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 137);
            this.Controls.Add(this.lb_New_Quant);
            this.Controls.Add(this.lb_Quant_Current);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.tb_New_Stock);
            this.Controls.Add(this.tb_Stock_Current);
            this.Controls.Add(this.tb_Viewer_Produto);
            this.Controls.Add(this.bt_Search_Product);
            this.Controls.Add(this.tb_Product);
            this.Controls.Add(this.lb_Product);
            this.Controls.Add(this.bt_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_Viewer_Produto;
        private System.Windows.Forms.Button bt_Search_Product;
        private System.Windows.Forms.TextBox tb_Product;
        private System.Windows.Forms.Label lb_Product;
        private System.Windows.Forms.TextBox tb_Stock_Current;
        private System.Windows.Forms.TextBox tb_New_Stock;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label lb_Quant_Current;
        private System.Windows.Forms.Label lb_New_Quant;
    }
}