using DataAccess.DAO;
using DataAccess.DTO;
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
    public partial class AdminHomePage : Form
    {
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private UserSession _userSession;
        public AdminHomePage(UserSession userSession)
        {   
            InitializeComponent();
            _userRepository = new UserRepository();
            _postRepository = new PostRepository();
            _userSession = userSession;
            // Add Value into combobox 
            Dictionary<string, string> combobox = new Dictionary<string, string>();
            combobox.Add("customer", "Khách hàng");
            combobox.Add("post", "Bài đăng");
            combobox.Add("report", "Báo cáo");
            cbbDataAdmin.DataSource = new BindingSource(combobox,null);
            cbbDataAdmin.DisplayMember = "Value";
            cbbDataAdmin.ValueMember = "Key";
            LoadCustomerData();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Logout Click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        // Load Customer Data
        public void LoadCustomerData()
        {
            dgvData.DataSource = _userRepository.GetAllUserList();
        }



        private void cbbDataAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedcbb = cbbDataAdmin.SelectedValue.ToString();
            switch (selectedcbb)
            {
                case "post":
                    dgvData.DataSource = dgvData.DataSource = _postRepository.GetAllPost().Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
                    gbPost.Visible = true;
                    gbCustomer.Visible = false;
                    gbReport.Visible = false;
                    break;
                case "customer":
                    dgvData.DataSource = _userRepository.GetAllUserList();
                    gbCustomer.Visible = true;
                    gbPost.Visible = false;
                    gbReport.Visible = false;
                    break;
                case "report":
                    dgvData.DataSource = "Hello";
                    gbCustomer.Visible=false;
                    gbPost.Visible = false;
                    gbReport.Visible = true;
                    break;
            }
        }

        // Post Area
        // Get Empty Post 
        private Post getEmptyPost()
        {
            Post post = new Post();
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                post.Content = "";
                post.Status = "";
                post.Content = "";
                post.PostDate = DateTime.Now;
                post.UserId = _userSession.UserId;
            }
            return post;
        }
        // Get Post From Data
        private Post getPostFromDataGirdView()
        {
            Post post = new Post();
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                post.PostId = Int32.Parse(selectedRow.Cells["PostId"].Value.ToString());
                post.UserId = Int32.Parse(selectedRow.Cells["UserId"].Value.ToString());
                post.Title = selectedRow.Cells["Title"].Value.ToString();
                post.Content = selectedRow.Cells["Content"].Value.ToString();
                post.PostDate = DateTime.Parse(selectedRow.Cells["PostDate"].Value.ToString());
                post.Status = selectedRow.Cells["Status"].Value.ToString();
            }
            return post;
        }
        // Yêu cầu Post
        private void btnPostUpdate_Click(object sender, EventArgs e)
        {
            Post updatepost = new Post();
            updatepost = getPostFromDataGirdView();
            this.Hide();
            PostForm postform = new PostForm(updatepost);
            postform.Show();
        }

        private void btnPostAdd_Click(object sender, EventArgs e)
        {
            Post post = getEmptyPost();
            PostForm postForm = new PostForm(post);
            this.Hide();
            postForm.Show();
        }

        private void btnPostDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnReportDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            int id = _userSession.UserId;
            txtSearchAdmin.Text = id.ToString();
        }
        // Customer Area
        // Button Add User
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDTO user = getEmptyUser(); 
            CustomerForm frm = new CustomerForm(user);
            this.Hide();
            frm.Show();  
        }
        // Button Update User
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserDTO user = getUserFromDataGirdView();
            CustomerForm frm = new CustomerForm(user);
            this.Hide();
            frm.Show();
        }
        // Button Delete User
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                UserDTO user = new UserDTO();
                user.UserId = Int32.Parse(selectedRow.Cells["UserId"].Value.ToString());
                user.Email = selectedRow.Cells["Email"].Value.ToString();
                user.UserName = selectedRow.Cells["Username"].Value.ToString();
                user.Password = selectedRow.Cells["Password"].Value.ToString();
                user.RoleId =  Int32.Parse(selectedRow.Cells["RoleId"].Value.ToString());
                if (MessageBox.Show("Bạn có chắc muốn khóa người dùng " + user.UserName + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _userRepository.DeleteUser(user);
                    MessageBox.Show("Bạn đã khóa thành công người dùng này");
                    dgvData.DataSource = _userRepository.GetAllUserList();
                }
            }
        }
        // Get Empty User 
        private UserDTO getEmptyUser()
        {
            UserDTO user = new UserDTO();
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                user.Email = "";
                user.UserName = "";
                user.Password = "";
                user.RoleId = 0;
            }
            return user;
        }
        // Select User from DataGridView
        private UserDTO getUserFromDataGirdView()
        {
            UserDTO user = new UserDTO();
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                user.UserId = Int32.Parse(selectedRow.Cells["UserId"].Value.ToString());
                user.Email = selectedRow.Cells["Email"].Value.ToString();
                user.UserName = selectedRow.Cells["Username"].Value.ToString();
                user.Password = selectedRow.Cells["Password"].Value.ToString();
                user.RoleId = Int32.Parse(selectedRow.Cells["RoleId"].Value.ToString());
            }
            return user;
        }
    }
}
