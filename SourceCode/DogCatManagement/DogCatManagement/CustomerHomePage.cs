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
        private UserSession _userSession;
        public CustomerHomePage(UserSession userSession)
        {
            InitializeComponent();
            postRepository = new PostRepository();
            _userSession = userSession;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            dgv_Post.DataSource = postRepository.GetAllPost().Select(c => new { c.PostId, c.UserId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
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
                        dgv_Post.DataSource = postRepository.GetPosts();
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
                selectedPostId = postId;
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
                        dgv_Post.DataSource = postRepository.GetPosts();

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
                        dgv_Post.DataSource = postRepository.GetPosts();
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
            } else
            {
                MessageBox.Show("Please choose a post for reporting!");
                return;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //        dgv_CandidateList.DataSource = candidateService.GetCandidateProfiles()
            //.Where(c => c.Fullname.Contains(txt_Search.Text.Trim()) || c.ProfileShortDescription.Contains(txt_Search.Text)).
            //Select(c => new { c.CandidateId, c.Fullname, c.Birthday, c.ProfileShortDescription, c.ProfileUrl, c.PostingId, c.Posting.JobPostingTitle }).ToList();
            dgv_Post.DataSource = postRepository.GetPosts()
                .Where(c => c.Title.Contains(txt_Search.Text.Trim()))
                .Select(c => new { c.PostId, c.Title, c.Content }).ToList();    

        }
    }
}



