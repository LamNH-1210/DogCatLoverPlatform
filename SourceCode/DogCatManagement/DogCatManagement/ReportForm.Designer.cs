namespace DogCatManagement
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReportPostContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostReportTitle = new System.Windows.Forms.TextBox();
            this.txtResonreport = new System.Windows.Forms.TextBox();
            this.txtUserReport = new System.Windows.Forms.TextBox();
            this.dtReport = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBlockPost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí Tố Cáo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReportPostContent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPostReportTitle);
            this.groupBox1.Controls.Add(this.txtResonreport);
            this.groupBox1.Controls.Add(this.txtUserReport);
            this.groupBox1.Controls.Add(this.dtReport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtReportPostContent
            // 
            this.txtReportPostContent.Location = new System.Drawing.Point(380, 61);
            this.txtReportPostContent.Multiline = true;
            this.txtReportPostContent.Name = "txtReportPostContent";
            this.txtReportPostContent.Size = new System.Drawing.Size(219, 181);
            this.txtReportPostContent.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(380, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nội dung";
            // 
            // txtPostReportTitle
            // 
            this.txtPostReportTitle.Location = new System.Drawing.Point(134, 219);
            this.txtPostReportTitle.Name = "txtPostReportTitle";
            this.txtPostReportTitle.Size = new System.Drawing.Size(228, 23);
            this.txtPostReportTitle.TabIndex = 7;
            // 
            // txtResonreport
            // 
            this.txtResonreport.Location = new System.Drawing.Point(134, 61);
            this.txtResonreport.Multiline = true;
            this.txtResonreport.Name = "txtResonreport";
            this.txtResonreport.Size = new System.Drawing.Size(228, 95);
            this.txtResonreport.TabIndex = 6;
            // 
            // txtUserReport
            // 
            this.txtUserReport.Location = new System.Drawing.Point(134, 22);
            this.txtUserReport.Name = "txtUserReport";
            this.txtUserReport.Size = new System.Drawing.Size(228, 23);
            this.txtUserReport.TabIndex = 5;
            // 
            // dtReport
            // 
            this.dtReport.Location = new System.Drawing.Point(134, 174);
            this.dtReport.Name = "dtReport";
            this.dtReport.Size = new System.Drawing.Size(228, 23);
            this.dtReport.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời gian report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiêu đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lí do report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnBlockPost);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(146, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở về ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBlockPost
            // 
            this.btnBlockPost.Location = new System.Drawing.Point(6, 39);
            this.btnBlockPost.Name = "btnBlockPost";
            this.btnBlockPost.Size = new System.Drawing.Size(109, 42);
            this.btnBlockPost.TabIndex = 0;
            this.btnBlockPost.Text = "Khóa Post";
            this.btnBlockPost.UseVisualStyleBackColor = true;
            this.btnBlockPost.Click += new System.EventHandler(this.btnBlockPost_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtReport;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBack;
        private Button btnBlockPost;
        private TextBox txtUserReport;
        private TextBox txtReportPostContent;
        private Label label6;
        private TextBox txtPostReportTitle;
        private TextBox txtResonreport;
    }
}