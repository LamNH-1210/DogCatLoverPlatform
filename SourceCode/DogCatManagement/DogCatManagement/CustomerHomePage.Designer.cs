namespace DogCatManagement
{
    partial class CustomerHomePage
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
            btn_Logout = new Button();
            btn_User = new Button();
            label1 = new Label();
            btn_Search = new Button();
            txt_Search = new TextBox();
            groupBox2 = new GroupBox();
            btn_Report = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Close = new Button();
            btn_CreateNewPost = new Button();
            gb_PostsList = new GroupBox();
            dgv_Post = new DataGridView();
            groupBox4 = new GroupBox();
            btn_YourPost = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gb_PostsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Post).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Logout);
            groupBox1.Controls.Add(btn_User);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Location = new Point(6, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(947, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(853, 19);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(76, 29);
            btn_Logout.TabIndex = 3;
            btn_Logout.Text = "Log-out";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_User
            // 
            btn_User.Location = new Point(6, 15);
            btn_User.Name = "btn_User";
            btn_User.Size = new Size(80, 32);
            btn_User.TabIndex = 2;
            btn_User.Text = "User";
            btn_User.UseVisualStyleBackColor = true;
            btn_User.Click += btn_User_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(255, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 22);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMER HOME PAGE";
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(784, 17);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(61, 31);
            btn_Search.TabIndex = 0;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.BorderStyle = BorderStyle.FixedSingle;
            txt_Search.Location = new Point(559, 21);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(219, 27);
            txt_Search.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Report);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(btn_Delete);
            groupBox2.Controls.Add(btn_Close);
            groupBox2.Controls.Add(btn_CreateNewPost);
            groupBox2.Location = new Point(6, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(86, 555);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btn_Report
            // 
            btn_Report.Location = new Point(11, 183);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(66, 31);
            btn_Report.TabIndex = 4;
            btn_Report.Text = "Report";
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(10, 127);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(67, 37);
            btn_Update.TabIndex = 3;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(10, 79);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(66, 32);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(10, 516);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(66, 33);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_CreateNewPost
            // 
            btn_CreateNewPost.Location = new Point(10, 27);
            btn_CreateNewPost.Name = "btn_CreateNewPost";
            btn_CreateNewPost.Size = new Size(66, 35);
            btn_CreateNewPost.TabIndex = 0;
            btn_CreateNewPost.Text = "Create";
            btn_CreateNewPost.UseVisualStyleBackColor = true;
            btn_CreateNewPost.Click += btn_CreateNewPost_Click;
            // 
            // gb_PostsList
            // 
            gb_PostsList.Controls.Add(dgv_Post);
            gb_PostsList.Location = new Point(103, 127);
            gb_PostsList.Name = "gb_PostsList";
            gb_PostsList.Size = new Size(850, 483);
            gb_PostsList.TabIndex = 1;
            gb_PostsList.TabStop = false;
            gb_PostsList.Text = "Post List";
            // 
            // dgv_Post
            // 
            dgv_Post.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Post.Location = new Point(21, 27);
            dgv_Post.Name = "dgv_Post";
            dgv_Post.RowHeadersWidth = 51;
            dgv_Post.RowTemplate.Height = 29;
            dgv_Post.Size = new Size(811, 437);
            dgv_Post.TabIndex = 0;
            dgv_Post.CellClick += dgv_Post_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_YourPost);
            groupBox4.Location = new Point(103, 53);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(850, 68);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // btn_YourPost
            // 
            btn_YourPost.Location = new Point(21, 26);
            btn_YourPost.Name = "btn_YourPost";
            btn_YourPost.Size = new Size(94, 29);
            btn_YourPost.TabIndex = 0;
            btn_YourPost.Text = "Your Post";
            btn_YourPost.UseVisualStyleBackColor = true;
            btn_YourPost.Click += btn_YourPost_Click;
            // 
            // CustomerHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 621);
            Controls.Add(groupBox4);
            Controls.Add(gb_PostsList);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerHomePage";
            Load += CustomerHomePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            gb_PostsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Post).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_User;
        private Label label1;
        private Button btn_Search;
        private TextBox txt_Search;
        private GroupBox groupBox2;
        private GroupBox gb_PostsList;
        private DataGridView dgv_Post;
        private Button btn_Delete;
        private Button btn_Close;
        private Button btn_CreateNewPost;
        private Button btn_Update;
        private CustomButton btn_Sale;
        private CustomButton btn_Equipment;
        private CustomButton btn_Free;
        private CustomButton btn_Dog;
        private CustomButton btn_Cat;
        private CustomButton btn_CusPost;
        private CustomButton btn_Exchanged;
        private Button btn_Report;
        private Button btn_Logout;
        private GroupBox groupBox4;
        private Button btn_YourPost;
    }
}