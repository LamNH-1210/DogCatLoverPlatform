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
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbPost = new System.Windows.Forms.GroupBox();
            this.btnPostDelete = new System.Windows.Forms.Button();
            this.btnPostUpdate = new System.Windows.Forms.Button();
            this.btnPostAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnReportDelete = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbDataAdmin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSearchAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gbCustomer.SuspendLayout();
            this.gbPost.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.btnDelete);
            this.gbCustomer.Controls.Add(this.btnUpdate);
            this.gbCustomer.Controls.Add(this.btnAdd);
            this.gbCustomer.Location = new System.Drawing.Point(674, 134);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(126, 181);
            this.gbCustomer.TabIndex = 1;
            this.gbCustomer.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 43);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbPost
            // 
            this.gbPost.Controls.Add(this.btnPostDelete);
            this.gbPost.Controls.Add(this.btnPostUpdate);
            this.gbPost.Controls.Add(this.btnPostAdd);
            this.gbPost.Location = new System.Drawing.Point(674, 180);
            this.gbPost.Name = "gbPost";
            this.gbPost.Size = new System.Drawing.Size(126, 250);
            this.gbPost.TabIndex = 4;
            this.gbPost.TabStop = false;
            this.gbPost.Visible = false;
            // 
            // btnPostDelete
            // 
            this.btnPostDelete.Location = new System.Drawing.Point(0, 113);
            this.btnPostDelete.Name = "btnPostDelete";
            this.btnPostDelete.Size = new System.Drawing.Size(126, 43);
            this.btnPostDelete.TabIndex = 2;
            this.btnPostDelete.Text = "Xóa";
            this.btnPostDelete.UseVisualStyleBackColor = true;
            this.btnPostDelete.Click += new System.EventHandler(this.btnPostDelete_Click);
            // 
            // btnPostUpdate
            // 
            this.btnPostUpdate.Location = new System.Drawing.Point(0, 64);
            this.btnPostUpdate.Name = "btnPostUpdate";
            this.btnPostUpdate.Size = new System.Drawing.Size(126, 43);
            this.btnPostUpdate.TabIndex = 1;
            this.btnPostUpdate.Text = "Yêu cầu";
            this.btnPostUpdate.UseVisualStyleBackColor = true;
            this.btnPostUpdate.Click += new System.EventHandler(this.btnPostUpdate_Click);
            // 
            // btnPostAdd
            // 
            this.btnPostAdd.Location = new System.Drawing.Point(0, 15);
            this.btnPostAdd.Name = "btnPostAdd";
            this.btnPostAdd.Size = new System.Drawing.Size(126, 43);
            this.btnPostAdd.TabIndex = 0;
            this.btnPostAdd.Text = "Thêm";
            this.btnPostAdd.UseVisualStyleBackColor = true;
            this.btnPostAdd.Click += new System.EventHandler(this.btnPostAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.btnReportDelete);
            this.gbReport.Controls.Add(this.btn);
            this.gbReport.Location = new System.Drawing.Point(674, 134);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(126, 250);
            this.gbReport.TabIndex = 5;
            this.gbReport.TabStop = false;
            this.gbReport.Visible = false;
            // 
            // btnReportDelete
            // 
            this.btnReportDelete.Location = new System.Drawing.Point(0, 64);
            this.btnReportDelete.Name = "btnReportDelete";
            this.btnReportDelete.Size = new System.Drawing.Size(126, 43);
            this.btnReportDelete.TabIndex = 2;
            this.btnReportDelete.Text = "Xóa";
            this.btnReportDelete.UseVisualStyleBackColor = true;
            this.btnReportDelete.Click += new System.EventHandler(this.btnReportDelete_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(0, 15);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(126, 43);
            this.btn.TabIndex = 0;
            this.btn.Text = "Xem chi tiết";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(674, 446);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 43);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbDataAdmin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cbbDataAdmin
            // 
            this.cbbDataAdmin.FormattingEnabled = true;
            this.cbbDataAdmin.Location = new System.Drawing.Point(56, 28);
            this.cbbDataAdmin.Name = "cbbDataAdmin";
            this.cbbDataAdmin.Size = new System.Drawing.Size(152, 23);
            this.cbbDataAdmin.TabIndex = 6;
            this.cbbDataAdmin.SelectedIndexChanged += new System.EventHandler(this.cbbDataAdmin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dữ liệu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSearchAdmin);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(316, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 65);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txtSearchAdmin
            // 
            this.txtSearchAdmin.Location = new System.Drawing.Point(77, 26);
            this.txtSearchAdmin.Name = "txtSearchAdmin";
            this.txtSearchAdmin.Size = new System.Drawing.Size(269, 23);
            this.txtSearchAdmin.TabIndex = 1;
            this.txtSearchAdmin.TextChanged += new System.EventHandler(this.txtSearchAdmin_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome, Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 134);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(656, 355);
            this.dgvData.TabIndex = 5;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.gbPost);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCustomer);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbPost.ResumeLayout(false);
            this.gbReport.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtSearchAdmin;
        private Label label3;
        private GroupBox gbPost;
        private Button btnPostDelete;
        private Button btnPostUpdate;
        private Button btnPostAdd;
        private GroupBox gbReport;
        private Button btnReportDelete;
        private Button btn;
        private DataGridView dgvData;
    }
}