namespace DogCatManagement
{
    partial class UserForm
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
            lb_EmailEmpty = new Label();
            lb_PasswordEmpty = new Label();
            lb_UserNameEmpty = new Label();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Cancel = new Button();
            btn_UpdateUserInfo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_EmailEmpty);
            groupBox1.Controls.Add(lb_PasswordEmpty);
            groupBox1.Controls.Add(lb_UserNameEmpty);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // lb_EmailEmpty
            // 
            lb_EmailEmpty.AutoSize = true;
            lb_EmailEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_EmailEmpty.ForeColor = Color.Red;
            lb_EmailEmpty.Location = new Point(161, 202);
            lb_EmailEmpty.Name = "lb_EmailEmpty";
            lb_EmailEmpty.Size = new Size(214, 20);
            lb_EmailEmpty.TabIndex = 10;
            lb_EmailEmpty.Text = "* Username must not be empty";
            // 
            // lb_PasswordEmpty
            // 
            lb_PasswordEmpty.AutoSize = true;
            lb_PasswordEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_PasswordEmpty.ForeColor = Color.Red;
            lb_PasswordEmpty.Location = new Point(161, 137);
            lb_PasswordEmpty.Name = "lb_PasswordEmpty";
            lb_PasswordEmpty.Size = new Size(209, 20);
            lb_PasswordEmpty.TabIndex = 9;
            lb_PasswordEmpty.Text = "* Password must not be empty";
            // 
            // lb_UserNameEmpty
            // 
            lb_UserNameEmpty.AutoSize = true;
            lb_UserNameEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UserNameEmpty.ForeColor = Color.Red;
            lb_UserNameEmpty.Location = new Point(161, 64);
            lb_UserNameEmpty.Name = "lb_UserNameEmpty";
            lb_UserNameEmpty.Size = new Size(214, 20);
            lb_UserNameEmpty.TabIndex = 8;
            lb_UserNameEmpty.Text = "* Username must not be empty";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(161, 172);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(261, 27);
            txt_Email.TabIndex = 7;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(161, 107);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(261, 27);
            txt_Password.TabIndex = 6;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(161, 34);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(261, 27);
            txt_Username.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 179);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Cancel);
            groupBox2.Controls.Add(btn_UpdateUserInfo);
            groupBox2.Location = new Point(8, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 89);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(300, 36);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(109, 29);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_UpdateUserInfo
            // 
            btn_UpdateUserInfo.Location = new Point(85, 36);
            btn_UpdateUserInfo.Name = "btn_UpdateUserInfo";
            btn_UpdateUserInfo.Size = new Size(107, 29);
            btn_UpdateUserInfo.TabIndex = 0;
            btn_UpdateUserInfo.Text = "Update";
            btn_UpdateUserInfo.UseVisualStyleBackColor = true;
            btn_UpdateUserInfo.Click += btn_UpdateUserInfo_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 369);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_Cancel;
        private Button btn_UpdateUserInfo;
        private Label label1;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Label label3;
        private Label label2;
        private Label lb_EmailEmpty;
        private Label lb_PasswordEmpty;
        private Label lb_UserNameEmpty;
    }
}