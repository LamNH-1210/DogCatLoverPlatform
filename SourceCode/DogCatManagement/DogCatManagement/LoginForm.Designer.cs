namespace DogCatManagement
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            linkSignup = new LinkLabel();
            label3 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCancle = new Button();
            btnLogin = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkSignup);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 112);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(579, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // linkSignup
            // 
            linkSignup.AutoSize = true;
            linkSignup.Location = new Point(257, 187);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(100, 20);
            linkSignup.TabIndex = 5;
            linkSignup.TabStop = true;
            linkSignup.Text = "Đăng kí ngay ";
            linkSignup.LinkClicked += linkSignup_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 187);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 4;
            label3.Text = "Bạn chưa có tài khoản?";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 124);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(458, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "@1234";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 57);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(458, 27);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "user1@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 121);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 60);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancle);
            groupBox2.Controls.Add(btnLogin);
            groupBox2.Location = new Point(14, 379);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(579, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(257, 29);
            btnCancle.Margin = new Padding(3, 4, 3, 4);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(126, 55);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "Hủy bỏ";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(114, 29);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(128, 59);
            label4.Name = "label4";
            label4.Size = new Size(190, 46);
            label4.TabIndex = 2;
            label4.Text = "Đăng Nhập";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 523);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkSignup;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnCancle;
        private Button btnLogin;
        private Label label4;
    }
}