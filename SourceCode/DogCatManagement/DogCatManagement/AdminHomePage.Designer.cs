namespace DogCatManagement
{
    partial class AdminHomePage
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
            gbCustomer = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbPost = new GroupBox();
            btnPostDelete = new Button();
            btnPostUpdate = new Button();
            btnPostAdd = new Button();
            gbReport = new GroupBox();
            btn = new Button();
            btnLogout = new Button();
            groupBox3 = new GroupBox();
            cbbDataAdmin = new ComboBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            txtReportSearch = new TextBox();
            txtSearchPost = new TextBox();
            txtSearchUser = new TextBox();
            label3 = new Label();
            lbWelcome = new Label();
            dgvData = new DataGridView();
            cbbFilterPost = new ComboBox();
            cbbFilterUser = new ComboBox();
            gbCustomer.SuspendLayout();
            gbPost.SuspendLayout();
            gbReport.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // gbCustomer
            // 
            gbCustomer.Controls.Add(btnDelete);
            gbCustomer.Controls.Add(btnUpdate);
            gbCustomer.Controls.Add(btnAdd);
            gbCustomer.Location = new Point(826, 250);
            gbCustomer.Margin = new Padding(3, 4, 3, 4);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Padding = new Padding(3, 4, 3, 4);
            gbCustomer.Size = new Size(144, 241);
            gbCustomer.TabIndex = 1;
            gbCustomer.TabStop = false;
            gbCustomer.Enter += gbCustomer_Enter;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 160);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 61);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Khóa/Mở Khóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 95);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 57);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 29);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbPost
            // 
            gbPost.Controls.Add(btnPostDelete);
            gbPost.Controls.Add(btnPostUpdate);
            gbPost.Controls.Add(btnPostAdd);
            gbPost.Location = new Point(826, 251);
            gbPost.Margin = new Padding(3, 4, 3, 4);
            gbPost.Name = "gbPost";
            gbPost.Padding = new Padding(3, 4, 3, 4);
            gbPost.Size = new Size(144, 240);
            gbPost.TabIndex = 4;
            gbPost.TabStop = false;
            gbPost.Visible = false;
            // 
            // btnPostDelete
            // 
            btnPostDelete.Location = new Point(6, 151);
            btnPostDelete.Margin = new Padding(3, 4, 3, 4);
            btnPostDelete.Name = "btnPostDelete";
            btnPostDelete.Size = new Size(126, 56);
            btnPostDelete.TabIndex = 2;
            btnPostDelete.Text = "Xóa";
            btnPostDelete.UseVisualStyleBackColor = true;
            btnPostDelete.Click += btnPostDelete_Click;
            // 
            // btnPostUpdate
            // 
            btnPostUpdate.Location = new Point(6, 85);
            btnPostUpdate.Margin = new Padding(3, 4, 3, 4);
            btnPostUpdate.Name = "btnPostUpdate";
            btnPostUpdate.Size = new Size(126, 58);
            btnPostUpdate.TabIndex = 1;
            btnPostUpdate.Text = "Yêu cầu";
            btnPostUpdate.UseVisualStyleBackColor = true;
            btnPostUpdate.Click += btnPostUpdate_Click;
            // 
            // btnPostAdd
            // 
            btnPostAdd.Location = new Point(6, 20);
            btnPostAdd.Margin = new Padding(3, 4, 3, 4);
            btnPostAdd.Name = "btnPostAdd";
            btnPostAdd.Size = new Size(126, 54);
            btnPostAdd.TabIndex = 0;
            btnPostAdd.Text = "Thêm";
            btnPostAdd.UseVisualStyleBackColor = true;
            btnPostAdd.Click += btnPostAdd_Click;
            // 
            // gbReport
            // 
            gbReport.Controls.Add(btn);
            gbReport.Location = new Point(826, 562);
            gbReport.Margin = new Padding(3, 4, 3, 4);
            gbReport.Name = "gbReport";
            gbReport.Padding = new Padding(3, 4, 3, 4);
            gbReport.Size = new Size(144, 157);
            gbReport.TabIndex = 5;
            gbReport.TabStop = false;
            gbReport.Visible = false;
            // 
            // btn
            // 
            btn.Location = new Point(6, 61);
            btn.Margin = new Padding(3, 4, 3, 4);
            btn.Name = "btn";
            btn.Size = new Size(132, 57);
            btn.TabIndex = 0;
            btn.Text = "Xem chi tiết";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(826, 727);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(144, 57);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbbDataAdmin);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 56);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(402, 87);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // cbbDataAdmin
            // 
            cbbDataAdmin.FormattingEnabled = true;
            cbbDataAdmin.Location = new Point(78, 37);
            cbbDataAdmin.Margin = new Padding(3, 4, 3, 4);
            cbbDataAdmin.Name = "cbbDataAdmin";
            cbbDataAdmin.Size = new Size(173, 28);
            cbbDataAdmin.TabIndex = 6;
            cbbDataAdmin.SelectedIndexChanged += cbbDataAdmin_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 41);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Dữ liệu";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtReportSearch);
            groupBox4.Controls.Add(txtSearchPost);
            groupBox4.Controls.Add(txtSearchUser);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(12, 151);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(402, 87);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // txtReportSearch
            // 
            txtReportSearch.BorderStyle = BorderStyle.FixedSingle;
            txtReportSearch.Location = new Point(83, 39);
            txtReportSearch.Margin = new Padding(3, 4, 3, 4);
            txtReportSearch.Name = "txtReportSearch";
            txtReportSearch.Size = new Size(307, 27);
            txtReportSearch.TabIndex = 3;
            txtReportSearch.Visible = false;
            txtReportSearch.TextChanged += txtReportSearch_TextChanged;
            // 
            // txtSearchPost
            // 
            txtSearchPost.Location = new Point(78, 39);
            txtSearchPost.Margin = new Padding(3, 4, 3, 4);
            txtSearchPost.Name = "txtSearchPost";
            txtSearchPost.Size = new Size(307, 27);
            txtSearchPost.TabIndex = 2;
            txtSearchPost.Visible = false;
            txtSearchPost.TextChanged += txtSearchPost_TextChanged;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(78, 39);
            txtSearchUser.Margin = new Padding(3, 4, 3, 4);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(307, 27);
            txtSearchUser.TabIndex = 1;
            txtSearchUser.TextChanged += txtSearchAdmin_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 44);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Tìm kiếm";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbWelcome.Location = new Point(7, 20);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(209, 32);
            lbWelcome.TabIndex = 4;
            lbWelcome.Text = "Welcome, Admin";
            lbWelcome.Click += label1_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(7, 261);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 25;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(811, 523);
            dgvData.TabIndex = 5;
            dgvData.CellFormatting += dgvData_CellFormatting;
            // 
            // cbbFilterPost
            // 
            cbbFilterPost.FormattingEnabled = true;
            cbbFilterPost.Location = new Point(570, 210);
            cbbFilterPost.Margin = new Padding(3, 4, 3, 4);
            cbbFilterPost.Name = "cbbFilterPost";
            cbbFilterPost.Size = new Size(186, 28);
            cbbFilterPost.TabIndex = 6;
            cbbFilterPost.SelectedIndexChanged += cbbFilterPost_SelectedIndexChanged;
            // 
            // cbbFilterUser
            // 
            cbbFilterUser.FormattingEnabled = true;
            cbbFilterUser.Location = new Point(571, 210);
            cbbFilterUser.Margin = new Padding(3, 4, 3, 4);
            cbbFilterUser.Name = "cbbFilterUser";
            cbbFilterUser.Size = new Size(186, 28);
            cbbFilterUser.TabIndex = 7;
            cbbFilterUser.SelectedIndexChanged += cbbFilterUser_SelectedIndexChanged;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 807);
            Controls.Add(cbbFilterUser);
            Controls.Add(cbbFilterPost);
            Controls.Add(groupBox4);
            Controls.Add(gbPost);
            Controls.Add(dgvData);
            Controls.Add(gbReport);
            Controls.Add(btnLogout);
            Controls.Add(lbWelcome);
            Controls.Add(groupBox3);
            Controls.Add(gbCustomer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHomePage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminHomePage";
            Load += AdminHomePage_Load;
            gbCustomer.ResumeLayout(false);
            gbPost.ResumeLayout(false);
            gbReport.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCustomer;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Button btnLogout;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbbDataAdmin;
        private Label label2;
        private TextBox txtSearchUser;
        private Label label3;
        private GroupBox gbPost;
        private Button btnPostDelete;
        private Button btnPostUpdate;
        private Button btnPostAdd;
        private GroupBox gbReport;
        private Button btn;
        private DataGridView dgvData;
        private Label lbWelcome;
        private TextBox txtSearchPost;
        private TextBox txtReportSearch;
        private ComboBox cbbFilterPost;
        private ComboBox cbbFilterUser;
    }
}