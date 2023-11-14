using DataAccess.DAO;
using DataAccess.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogCatManagement
{
    public partial class CustomerHomePage : Form
    {
        private IPostRepository postRepository = null;
        private IReportRepository reportRepository = null;
        private UserSession _userSession;
        public CustomerHomePage(UserSession userSession)
        {
            InitializeComponent();
            postRepository = new PostRepository();
            reportRepository = new ReportRepository();
            _userSession = userSession;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            dgv_Post.DataSource = postRepository.GetAllPost().Where(p => p.Status != "Pending").Select(c => new { c.PostId, c.UserId, c.Title, c.Content, c.PostDate, c.User.UserName }).ToList();

            this.dgv_Post.Columns["UserId"].Visible = false;

        }

        private void btn_CreateNewPost_Click(object sender, EventArgs e)
        {
            MemberCreatePostForm frm_Post = new MemberCreatePostForm(_userSession);
            frm_Post.Show();
            this.Hide();
            dgv_Post.DataSource = postRepository.GetPosts();
        }


        private int selectedPostId = -1;
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedPostId != -1)
            {
                Post selectedPost = postRepository.getPostByID(selectedPostId);
                if (selectedPost != null && selectedPost.UserId == _userSession.UserId)
                {
                    try
                    {
                        postRepository.DeletePostByCustomer(selectedPostId);
                        MessageBox.Show("Delete post successfully");
                        CustomerHomePage_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete the post: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You are not authorized to delete this post.");
                }
            }
            else
            {
                MessageBox.Show("Please choose a post for deleting!");
                return;
            }
        }

        private void dgv_Post_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_CreateNewPost.Enabled = false;
            if (e.RowIndex >= 0)
            {
                int postId = int.Parse(dgv_Post.Rows[e.RowIndex].Cells["PostId"].Value.ToString());
                string content = dgv_Post.Rows[e.RowIndex].Cells["Content"].Value.ToString();
                string title = dgv_Post.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                if (selectedPostId != postId)
                {
                    selectedPostId = postId;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedPostId != -1)
            {
                Post selectedPost = postRepository.getPostByID(selectedPostId);
                if (selectedPost != null && selectedPost.UserId == _userSession.UserId)
                {
                    try
                    {
                        UpdatePostForm frm_Update = new UpdatePostForm(selectedPost);
                        frm_Update.Show();
                        this.Hide();
                        CustomerHomePage_Load(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update the post: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You are not authorized to update this post.");
                }
            }
            else
            {
                MessageBox.Show("Please choose a post for updating!");
                return;
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

            if (selectedPostId != -1)
            {
                Post selectedPost = postRepository.getPostByID(selectedPostId);
                if (selectedPost != null && selectedPost.UserId != _userSession.UserId)
                {
                    try
                    {
                        UserReportForm frm_Report = new UserReportForm(_userSession, selectedPost);
                        frm_Report.Show();
                        this.Hide();
                        CustomerHomePage_Load(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to report the post: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot report your post.");
                }
            }
            else
            {
                MessageBox.Show("Please choose a post for reporting!");
                return;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Post.DataSource = postRepository.GetPosts()
                .Where(c => c.Title.Contains(txt_Search.Text.Trim()))
                .Select(c => new { c.PostId, c.Title, c.Content }).ToList();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm form = new LoginForm();
                form.Show();
                this.Close();
            }
        }

        private void btn_YourPost_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the user's posts based on their UserId
                List<Post> userPosts = postRepository.GetPostsByUserId(_userSession.UserId);

                // Display the user's posts in the DataGridView
                dgv_Post.DataSource = userPosts
                    .Select(c => new { c.PostId, c.UserId, c.Title, c.Content, c.PostDate })
                    .ToList();
                this.dgv_Post.Columns["UserId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching user posts: " + ex.Message);
            }
        }
        private void btn_YourReports_Click(object sender, EventArgs e)
        {
            try
            {
                List<Report> userReports = reportRepository.GetReportsByUserID(_userSession.UserId);

                // Display the user's posts in the DataGridView
                dgv_Post.DataSource = userReports
                    .Select(c => new { c.ReportId, c.PostId, c.ReportReason, c.ReportDate })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching user posts: " + ex.Message);
            }
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            
            UserForm frm_User = new UserForm(_userSession);
            frm_User.Show();
            this.Hide();
            CustomerHomePage_Load(sender, e);
        }
    }
}



