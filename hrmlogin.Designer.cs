namespace Coursework
{
    partial class hrmlogin
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
            Login = new Label();
            label1 = new Label();
            label2 = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            bt_login = new Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(329, 9);
            Login.Name = "Login";
            Login.Size = new Size(155, 65);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 153);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 234);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(242, 162);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(359, 23);
            tb_username.TabIndex = 3;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(242, 243);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(359, 23);
            tb_password.TabIndex = 4;
            // 
            // bt_login
            // 
            bt_login.Location = new Point(242, 292);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(132, 50);
            bt_login.TabIndex = 5;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += btn_login;
            // 
            // hrmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_login);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login);
            Name = "hrmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login to the app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private Label label1;
        private Label label2;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button bt_login;
    }
}