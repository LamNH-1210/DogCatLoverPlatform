namespace DogCatManagement
{
    partial class MemberCreatePostForm
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
            lb_ContentWarning = new Label();
            lb_TitleWarning = new Label();
            txt_Content = new TextBox();
            label3 = new Label();
            txt_Title = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btn_Cancel = new CustomButton();
            btn_Post = new CustomButton();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_ContentWarning);
            groupBox1.Controls.Add(lb_TitleWarning);
            groupBox1.Controls.Add(txt_Content);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Title);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lb_ContentWarning
            // 
            lb_ContentWarning.AutoSize = true;
            lb_ContentWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ContentWarning.ForeColor = Color.Red;
            lb_ContentWarning.Location = new Point(86, 238);
            lb_ContentWarning.Name = "lb_ContentWarning";
            lb_ContentWarning.Size = new Size(237, 23);
            lb_ContentWarning.TabIndex = 7;
            lb_ContentWarning.Text = "*Content must not be empty*";
            // 
            // lb_TitleWarning
            // 
            lb_TitleWarning.AutoSize = true;
            lb_TitleWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TitleWarning.ForeColor = Color.Red;
            lb_TitleWarning.Location = new Point(86, 78);
            lb_TitleWarning.Name = "lb_TitleWarning";
            lb_TitleWarning.Size = new Size(207, 23);
            lb_TitleWarning.TabIndex = 6;
            lb_TitleWarning.Text = "*Title must not be empty*";
            // 
            // txt_Content
            // 
            txt_Content.BorderStyle = BorderStyle.FixedSingle;
            txt_Content.Location = new Point(86, 113);
            txt_Content.Multiline = true;
            txt_Content.Name = "txt_Content";
            txt_Content.Size = new Size(677, 122);
            txt_Content.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Content";
            // 
            // txt_Title
            // 
            txt_Title.BorderStyle = BorderStyle.FixedSingle;
            txt_Title.Location = new Point(86, 24);
            txt_Title.Multiline = true;
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(677, 50);
            txt_Title.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Cancel);
            groupBox3.Controls.Add(btn_Post);
            groupBox3.Location = new Point(7, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(781, 97);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
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
            btn_Cancel.Location = new Point(441, 26);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(115, 50);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.TextColor = Color.White;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Post
            // 
            btn_Post.BackColor = Color.MediumSlateBlue;
            btn_Post.BackgroundColor = Color.MediumSlateBlue;
            btn_Post.BorderColor = Color.PaleVioletRed;
            btn_Post.BorderRadius = 20;
            btn_Post.BorderSize = 0;
            btn_Post.FlatAppearance.BorderSize = 0;
            btn_Post.FlatStyle = FlatStyle.Flat;
            btn_Post.ForeColor = Color.White;
            btn_Post.Location = new Point(220, 26);
            btn_Post.Name = "btn_Post";
            btn_Post.Size = new Size(91, 50);
            btn_Post.TabIndex = 0;
            btn_Post.Text = "Post";
            btn_Post.TextColor = Color.White;
            btn_Post.UseVisualStyleBackColor = false;
            btn_Post.Click += btn_Post_Click;
            // 
            // MemberCreatePostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 435);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "MemberCreatePostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberCreatePostForm";
            Load += MemberCreatePostForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private ComboBox cmb_Status;
        private TextBox txt_Content;
        private TextBox txt_Title;
        private CustomButton btn_Post;
        private CustomButton btn_Cancel;
        private Label lb_ContentWarning;
        private Label lb_TitleWarning;
    }
}