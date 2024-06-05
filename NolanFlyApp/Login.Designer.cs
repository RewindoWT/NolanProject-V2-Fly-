namespace NolanFlyApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.tb_userName);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 476);
            this.panel1.TabIndex = 13;
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(259, 128);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(267, 20);
            this.tb_userName.TabIndex = 25;
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_userName.Location = new System.Drawing.Point(336, 68);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(125, 25);
            this.lb_userName.TabIndex = 26;
            this.lb_userName.Text = "User Name:";
            this.lb_userName.Click += new System.EventHandler(this.lb_userName_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_password.Location = new System.Drawing.Point(336, 163);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(112, 25);
            this.lb_password.TabIndex = 27;
            this.lb_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(259, 219);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(267, 20);
            this.tb_password.TabIndex = 28;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(446, 257);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 40);
            this.btn_clear.TabIndex = 29;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(259, 257);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 40);
            this.btn_login.TabIndex = 30;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.Location = new System.Drawing.Point(259, 321);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(267, 40);
            this.btn_register.TabIndex = 31;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.AutoSize = true;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.Location = new System.Drawing.Point(341, 499);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(107, 50);
            this.btn_admin.TabIndex = 35;
            this.btn_admin.Text = "Admin Login";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_admin;
    }
}