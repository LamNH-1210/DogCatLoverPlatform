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

        private int currentUserId = 1;
        public CustomerHomePage()
        {
            InitializeComponent();
            postRepository = new PostRepository();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            dgv_Post.DataSource = postRepository.GetAllPost().Select(c => new { c.PostId, c.UserId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName, c.Reports }).ToList();
            this.dgv_Post.Columns["UserId"].Visible = false;
        }

        private void btn_CreateNewPost_Click(object sender, EventArgs e)
        {
            MemberCreatePostForm frm_Post = new MemberCreatePostForm();
            frm_Post.Show();
            this.Hide();
            dgv_Post.DataSource = postRepository.GetPosts();
        }

        private void dgv_Post_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_CreateNewPost.Enabled = false;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Post.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgv_Post.SelectedRows[0].Index;
                    Post selectedPost = (Post)dgv_Post.Rows[selectedRowIndex].DataBoundItem;
                    int postId = int.Parse(dgv_Post.SelectedRows[0].Cells[0].Value.ToString());
                    //Check if the user is authorized to delete this post
                    if (selectedPost.UserId == currentUserId)
                    {
                        try
                        {
                            postRepository.DeletePostByCustomer(postId);
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
                        MessageBox.Show("There are some errors here!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}



