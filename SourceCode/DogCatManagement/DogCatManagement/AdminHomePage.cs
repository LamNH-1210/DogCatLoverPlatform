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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DogCatManagement
{
    public partial class AdminHomePage : Form
    {
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private IReportRepository _reportRepository;
        private UserSession _userSession;
        public AdminHomePage(UserSession userSession)
        {
            InitializeComponent();
            // Khai bao Service
            _userRepository = new UserRepository();
            _postRepository = new PostRepository();
            _userSession = userSession;
            _reportRepository = new ReportRepository();
            // Add Value into combobox 
            Dictionary<string, string> combobox = new Dictionary<string, string>();
            combobox.Add("customer", "Khách hàng");
            combobox.Add("post", "Bài đăng");
            combobox.Add("report", "Báo cáo");
            cbbDataAdmin.DataSource = new BindingSource(combobox, null);
            cbbDataAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDataAdmin.DisplayMember = "Value";
            cbbDataAdmin.ValueMember = "Key";

            // ComboBox User 
            Dictionary<int, string> userStatus = new Dictionary<int, string>();
            userStatus.Add(10, "Tất cả");
            userStatus.Add(0, "Khách hàng");
            userStatus.Add(1, "Nhân Viên");
            userStatus.Add(2, "Admin");
            userStatus.Add(3, "Bị Khóa");
            cbbFilterUser.DataSource = new BindingSource(userStatus, null);
            cbbFilterUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFilterUser.DisplayMember = "Value";
            cbbFilterUser.ValueMember = "Key";

            // ComboBox Post
            Dictionary<string, string> postStatus = new Dictionary<String, string>();
            postStatus.Add("All", "Tất cả");
            postStatus.Add("Rejected", "Từ chối");
            postStatus.Add("Pending", "Đang chờ được duyệt");
            postStatus.Add("Published", "Đã được duyệt");
            cbbFilterPost.DataSource = new BindingSource(postStatus, null);
            cbbFilterPost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFilterPost.DisplayMember = "Value";
            cbbFilterPost.ValueMember = "Key";

            // Combox Post
            cbbDataAdmin.DataSource = new BindingSource(combobox, null);
            cbbDataAdmin.DisplayMember = "Value";
            cbbDataAdmin.ValueMember = "Key";
            LoadCustomerData();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // ADmin Form Load
        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            int id = _userSession.UserId;
            string name = _userRepository.getUserByID(id).UserName;
            lbWelcome.Text = "Welcome  " + name;
        }
        // Logout Click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm form = new LoginForm();
                form.Show();
                this.Close();
            }
        }
        // Load Customer Data
        public void LoadCustomerData()
        {
            dgvData.DataSource = _userRepository.GetAllUserList();
        }
        // Chooose area to show in admin
        private void cbbDataAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedcbb = cbbDataAdmin.SelectedValue.ToString();
            switch (selectedcbb)
            {
                case "post":
                    dgvData.DataSource = dgvData.DataSource = _postRepository.GetAllPost().Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
                    gbPost.Visible = true;
                    txtSearchPost.Visible = true;
                    txtReportSearch.Visible = false;
                    txtSearchUser.Visible = false;
                    gbCustomer.Visible = false;
                    gbReport.Visible = false;
                    cbbFilterPost.Visible = true;
                    cbbFilterUser.Visible = false;
                    break;
                case "customer":
                    dgvData.DataSource = _userRepository.GetAllUserList();
                    gbCustomer.Visible = true;
                    gbPost.Visible = false;
                    gbReport.Visible = false;
                    txtSearchPost.Visible = false;
                    txtReportSearch.Visible = false;
                    txtSearchUser.Visible = true;
                    cbbFilterPost.Visible = false;
                    cbbFilterUser.Visible = true;
                    break;
                case "report":
                    dgvData.DataSource = _reportRepository.GetAllReportList().Where(m => m.Post.Status.Equals("Published")).Select(c => new { c.ReportId, c.UserId, c.PostId, c.ReportDate, c.ReportReason, c.User.UserName, c.Post.Title }).ToList();
                    gbCustomer.Visible = false;
                    gbPost.Visible = false;
                    gbReport.Visible = true;
                    txtSearchPost.Visible = false;
                    txtReportSearch.Visible = true;
                    txtSearchUser.Visible = false;
                    cbbFilterPost.Visible = false;
                    cbbFilterUser.Visible = false;
                    break;
            }
        }
        // Post Area
        // Get Empty Post 
        private Post getEmptyPost()
        {
            Post post = new Post();

            post.Title = "Nhập tiêu đề ở đây...";
            post.Status = "Pending";
            post.Content = "Nhập nội dung ở đây...";
            post.PostDate = DateTime.Now;
            post.UserId = _userSession.UserId;
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
            if (dgvData.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hiện tại không ghi nhận bất cứ một bài đăng nào");
            }
            else
            {
                Post updatepost = new Post();
                updatepost = getPostFromDataGirdView();
                if (updatepost != null)
                {
                    if (updatepost.Status.Equals("Rejected"))
                    {
                        MessageBox.Show("This post has been rejected!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Hide();
                        PostForm postform = new PostForm(updatepost, _userSession.UserId);
                        postform.Show();
                    }
                }
            }
        }
        // Add Post
        private void btnPostAdd_Click(object sender, EventArgs e)
        {
            Post emptyPost = getEmptyPost();
            PostForm postForm = new PostForm(emptyPost, _userSession.UserId);
            this.Hide();
            postForm.Show();
        }
        // Search Post
        private void txtSearchPost_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchPost.Text.ToUpper();
            dgvData.DataSource = _postRepository.GetAllPost().Where(m => m.User.UserName.ToUpper().Contains(keyword)).Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
        }
        // PostDelete   
        private void btnPostDelete_Click(object sender, EventArgs e)
        {

        }
        // Report Area
        // Get Report From Form
        private Report getReportFromDataGirdView()
        {
            Report report = new Report();

            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvData.SelectedRows[0];
                report.ReportId = Int32.Parse(selectedRow.Cells["ReportId"].Value.ToString());
                report.UserId = Int32.Parse(selectedRow.Cells["UserId"].Value.ToString());
                report.PostId = Int32.Parse(selectedRow.Cells["PostId"].Value.ToString());
                report.ReportReason = selectedRow.Cells["ReportReason"].Value.ToString();
                report.ReportDate = DateTime.Parse(selectedRow.Cells["ReportDate"].Value.ToString());
            }
            return report;
        }
        // View Detail Report
        private void btn_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hiện tại không ghi nhận bất cứ phản hồi nào");
            }
            else if (dgvData.SelectedRows.Count > 0)
            {
                Report report = new Report();
                report = getReportFromDataGirdView();
                if (report != null)
                {
                    ReportForm form = new ReportForm(report, _userSession);
                    this.Hide();
                    form.Show();
                }
            }
        }
        private void btnReportDelete_Click(object sender, EventArgs e)
        {

        }

        // Search User 
        private void txtSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchUser.Text.ToUpper();
            dgvData.DataSource = _userRepository.GetAllUserList().Where(k => k.Email.ToUpper().Contains(keyword)).ToList();
        }
        // Customer Area
        // Button Add User
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDTO user = getEmptyUser();
            CustomerForm frm = new CustomerForm(user, _userSession);
            this.Hide();
            frm.Show();
        }
        // Button Update User
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserDTO user = getUserFromDataGirdView();
            CustomerForm frm = new CustomerForm(user, _userSession);
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
                user.RoleId = Int32.Parse(selectedRow.Cells["RoleId"].Value.ToString());
                if (user.RoleId == 3)
                {
                    MessageBox.Show("Hiện tại người dùng đã bị khóa, bạn có thể vào phần chỉnh sửa để chỉnh sửa giới hạn truy cập của user này!!");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn khóa người dùng " + user.UserName + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        _userRepository.DeleteUser(user);
                        MessageBox.Show("Bạn đã khóa thành công người dùng này");
                        dgvData.DataSource = _userRepository.GetAllUserList();
                    }
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
        //
        private void txtReportSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "Password")
            {
                if (e.Value != null)
                {
                    string password = e.Value.ToString();
                    e.Value = new string('*', password.Length);
                }
            }
        }

        private void gbCustomer_Enter(object sender, EventArgs e)
        {

        }

        // Filter User By Role ID
        private void cbbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = ((KeyValuePair<int, string>)cbbFilterUser.SelectedItem).Key;
            switch (value)
            {
                default:
                    dgvData.DataSource = _userRepository.GetAllUserList();
                    break;
                case 0:
                    dgvData.DataSource = _userRepository.GetAllUserList().Where(m => m.RoleId == 0).ToList();
                    break;
                case 1:
                    dgvData.DataSource = _userRepository.GetAllUserList().Where(m => m.RoleId == 1).ToList();
                    break;
                case 2:
                    dgvData.DataSource = _userRepository.GetAllUserList().Where(m => m.RoleId == 2).ToList();
                    break;
                case 3:
                    dgvData.DataSource = _userRepository.GetAllUserList().Where(m => m.RoleId == 3).ToList();
                    break;
            }
        }
        // Filter Post By Status
        private void cbbFilterPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbbFilterPost.SelectedValue.ToString();
            switch (value)
            {
                case "All":
                    dgvData.DataSource = dgvData.DataSource = _postRepository.GetAllPost().Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
                    break;
                case "Rejected":
                    dgvData.DataSource = dgvData.DataSource = _postRepository.GetAllPost().Where(p => p.Status.Equals("Rejected")).Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
                    break;
                case "Pending":
                    dgvData.DataSource = dgvData.DataSource = _postRepository.GetAllPost().Where(p => p.Status.Equals("Pending")).Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
                    break;
                case "Published":
                    dgvData.DataSource = dgvData.DataSource = _postRepository.GetAllPost().Where(p => p.Status.Equals("Published")).Select(c => new { c.UserId, c.PostId, c.Title, c.Content, c.PostDate, c.Status, c.User.UserName }).ToList();
                    break;
            }
        }
    }
}
