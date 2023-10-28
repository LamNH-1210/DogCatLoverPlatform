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

        public MemberCreatePostForm()
        {
            InitializeComponent();
            postRepository = new PostRepository();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerHomePage frm_CustomerPage = new CustomerHomePage();
            frm_CustomerPage.Show();

        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Title.Text == "" || txt_Content.Text == "")
                {
                    txt_Title.Focus();
                    txt_Content.Focus();
                    txt_Title.BackColor = Color.Teal;
                    txt_Content.BackColor = Color.Teal;
                    MessageBox.Show("Please fill in the form!");
                }
                Post new_Post = new Post();
                new_Post.Title = txt_Title.Text;
                new_Post.Content = txt_Content.Text;
                new_Post.Status = cmb_Status.SelectedItem.ToString();
                new_Post.PostDate = DateTime.Now;
                //new_Post.UserId= _userSession.UserId;
                postRepository.createPostByMemeber(new_Post);
                MessageBox.Show("Post successful!");
                this.Close();
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
            // cmb_Status.ValueMember = "PostId";
        }
    }
}
