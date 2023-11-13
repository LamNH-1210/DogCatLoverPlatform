using DataAccess.DAO;
using DataAccess.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DogCatManagement
{
    public partial class UpdatePostForm : Form
    {
        private IPostRepository postRepository = null;
        private int postId;
        private Post _post;
        private CustomerHomePage _homePage;
        private UserSession _userSession;
        public UpdatePostForm(Post post)
        {
            InitializeComponent();
            postRepository = new PostRepository();
            _post = post;
            _userSession = new UserSession();
            _homePage = new CustomerHomePage(_userSession);
        }

        public UpdatePostForm(int postId, string? content, string? title)
        {

            this.postId = postId;
            txt_PostId.Text = postId.ToString();
            txt_Content.Text = content;
            txt_Title.Text = title;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            _homePage.Show();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int postId = Int32.Parse(txt_PostId.Text);
            string updateContent = txt_Content.Text.Trim();
            string updateTitle = txt_Title.Text.Trim();
            if (string.IsNullOrEmpty(updateContent) && string.IsNullOrEmpty(updateTitle))
            {

                MessageBox.Show("Please fill in all");
                return;
            }
            try
            {
                Post post_Update = postRepository.getPostByID(postId);
                if (post_Update != null)
                {
                    post_Update.PostId = postId;
                    post_Update.UserId = _userSession.UserId;
                    post_Update.Title = updateTitle;
                    post_Update.Content = updateContent;
                    postRepository.UpdatePost(post_Update);
                    MessageBox.Show("Post updated successfully!!!");
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                _homePage.Show();
            }catch (Exception ex)
            {
                MessageBox.Show("Post updated Failed!!!");
            }
        }

        private void UpdatePostForm_Load(object sender, EventArgs e)
        {
            txt_PostId.Enabled = false;
            txt_Content.Text = _post.Content;
            txt_Title.Text= _post.Title;
            txt_PostId.Text = _post.PostId.ToString();
        }
    }
}
