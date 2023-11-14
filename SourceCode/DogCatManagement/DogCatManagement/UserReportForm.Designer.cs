namespace DogCatManagement
{
    partial class UserReportForm
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
            lb_OtherEmpty = new Label();
            txt_OtherReason = new TextBox();
            cmb_Reasons = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Cancel = new Button();
            btn_SendReport = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_OtherEmpty);
            groupBox1.Controls.Add(txt_OtherReason);
            groupBox1.Controls.Add(cmb_Reasons);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lb_OtherEmpty
            // 
            lb_OtherEmpty.AutoSize = true;
            lb_OtherEmpty.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_OtherEmpty.ForeColor = Color.Red;
            lb_OtherEmpty.Location = new Point(87, 229);
            lb_OtherEmpty.Name = "lb_OtherEmpty";
            lb_OtherEmpty.Size = new Size(194, 23);
            lb_OtherEmpty.TabIndex = 4;
            lb_OtherEmpty.Text = "Please enter the reason!";
            // 
            // txt_OtherReason
            // 
            txt_OtherReason.BorderStyle = BorderStyle.FixedSingle;
            txt_OtherReason.Location = new Point(87, 93);
            txt_OtherReason.Multiline = true;
            txt_OtherReason.Name = "txt_OtherReason";
            txt_OtherReason.Size = new Size(406, 133);
            txt_OtherReason.TabIndex = 3;
            // 
            // cmb_Reasons
            // 
            cmb_Reasons.FormattingEnabled = true;
            cmb_Reasons.Location = new Point(87, 31);
            cmb_Reasons.Name = "cmb_Reasons";
            cmb_Reasons.Size = new Size(406, 28);
            cmb_Reasons.TabIndex = 2;
            cmb_Reasons.SelectedIndexChanged += cmb_Reasons_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Other";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Reason";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Cancel);
            groupBox2.Controls.Add(btn_SendReport);
            groupBox2.Location = new Point(10, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 88);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(351, 36);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_SendReport
            // 
            btn_SendReport.Location = new Point(96, 36);
            btn_SendReport.Name = "btn_SendReport";
            btn_SendReport.Size = new Size(94, 29);
            btn_SendReport.TabIndex = 0;
            btn_SendReport.Text = "Send";
            btn_SendReport.UseVisualStyleBackColor = true;
            btn_SendReport.Click += btn_SendReport_Click;
            // 
            // UserReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 381);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UserReportForm";
            Text = "UserReportForm";
            Load += UserReportForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_OtherEmpty;
        private TextBox txt_OtherReason;
        private ComboBox cmb_Reasons;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_Cancel;
        private Button btn_SendReport;
    }
}