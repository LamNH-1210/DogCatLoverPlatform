using DataAccess.DAO;
using DataAccess.Models;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace DogCatManagement
{
    public partial class MemberCreatePostForm : Form
    {
        private IPostRepository postRepository = null;
        private UserSession _userSession;


        public MemberCreatePostForm(UserSession userSession)
        {
            InitializeComponent();
            postRepository = new PostRepository();
            _userSession = userSession;
            lb_TitleWarning.Visible = false;
            lb_ContentWarning.Visible = false;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerHomePage frm_CustomerPage = new CustomerHomePage(_userSession);
            frm_CustomerPage.Show();

        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            LoginForm frmLogin = new LoginForm();

            try
            {
                if (txt_Title.Text == "" || txt_Content.Text == "")
                {
                    lb_TitleWarning.Show();
                    lb_ContentWarning.Show();
                    return;
                }

                Post new_Post = new Post();
                new_Post.UserId = _userSession.UserId;
                new_Post.Title = txt_Title.Text;
                new_Post.Content = txt_Content.Text;
                new_Post.Status = cmb_Status.SelectedItem.ToString();
                new_Post.PostDate = DateTime.Now;
                postRepository.CreatePostByMemeber(new_Post);
                MessageBox.Show("Post successful!");
                this.Hide();
                CustomerHomePage customerHomePage = new CustomerHomePage(_userSession);
                customerHomePage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Post failed. Please Try Again! " + ex.Message);
            }
        }

        private void MemberCreatePostForm_Load(object sender, EventArgs e)
        {

            cmb_Status.DataSource = postRepository.GetPosts().Select(m => m.Status).Distinct().ToList();
            cmb_Status.DisplayMember = "Status";
        }
    }
}
