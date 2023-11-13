namespace DogCatManagement
{
    partial class UpdatePostForm
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
            txt_Content = new TextBox();
            txt_Title = new TextBox();
            txt_PostId = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Cancel = new CustomButton();
            btn_Update = new CustomButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Content);
            groupBox1.Controls.Add(txt_Title);
            groupBox1.Controls.Add(txt_PostId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txt_Content
            // 
            txt_Content.Location = new Point(104, 82);
            txt_Content.Multiline = true;
            txt_Content.Name = "txt_Content";
            txt_Content.Size = new Size(290, 110);
            txt_Content.TabIndex = 7;
            // 
            // txt_Title
            // 
            txt_Title.Location = new Point(499, 26);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(263, 27);
            txt_Title.TabIndex = 6;
            // 
            // txt_PostId
            // 
            txt_PostId.Location = new Point(104, 26);
            txt_PostId.Name = "txt_PostId";
            txt_PostId.Size = new Size(290, 27);
            txt_PostId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 92);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Content";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 33);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "PostId";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Cancel);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Location = new Point(8, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 74);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.MediumSlateBlue;
            btn_Cancel.BackgroundColor = Color.MediumSlateBlue;
            btn_Cancel.BorderColor = Color.PaleVioletRed;
            btn_Cancel.BorderRadius = 20;
            btn_Cancel.BorderSize = 0;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(421, 25);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(98, 42);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.TextColor = Color.White;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.MediumSlateBlue;
            btn_Update.BackgroundColor = Color.MediumSlateBlue;
            btn_Update.BorderColor = Color.PaleVioletRed;
            btn_Update.BorderRadius = 20;
            btn_Update.BorderSize = 0;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(196, 26);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(107, 41);
            btn_Update.TabIndex = 0;
            btn_Update.Text = "Update";
            btn_Update.TextColor = Color.White;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // UpdatePostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 344);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UpdatePostForm";
            Text = "UpdatePostForm";
            Load += UpdatePostForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Content;
        private TextBox txt_Title;
        private TextBox txt_PostId;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private CustomButton btn_Cancel;
        private CustomButton btn_Update;
    }
}