namespace StockController
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_Enter = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.lb_User_Name = new System.Windows.Forms.Label();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Enter
            // 
            this.bt_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Enter.Location = new System.Drawing.Point(16, 110);
            this.bt_Enter.Name = "bt_Enter";
            this.bt_Enter.Size = new System.Drawing.Size(274, 27);
            this.bt_Enter.TabIndex = 49;
            this.bt_Enter.Text = "Entrar";
            this.bt_Enter.UseVisualStyleBackColor = true;
            this.bt_Enter.Click += new System.EventHandler(this.bt_Enter_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(86, 6);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(204, 26);
            this.tb_Name.TabIndex = 55;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(86, 62);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.Size = new System.Drawing.Size(204, 26);
            this.tb_Pass.TabIndex = 56;
            // 
            // lb_User_Name
            // 
            this.lb_User_Name.AutoSize = true;
            this.lb_User_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User_Name.Location = new System.Drawing.Point(12, 9);
            this.lb_User_Name.Name = "lb_User_Name";
            this.lb_User_Name.Size = new System.Drawing.Size(68, 20);
            this.lb_User_Name.TabIndex = 59;
            this.lb_User_Name.Text = "Usuário:";
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pass.Location = new System.Drawing.Point(12, 65);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(60, 20);
            this.lb_Pass.TabIndex = 60;
            this.lb_Pass.Text = "Senha:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 153);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_User_Name);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.bt_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Sistema";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Enter;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Label lb_User_Name;
        private System.Windows.Forms.Label lb_Pass;
    }
}