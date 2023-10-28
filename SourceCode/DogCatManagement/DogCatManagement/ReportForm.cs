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

namespace DogCatManagement
{
    public partial class ReportForm : Form
    {
        private Report report;
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private UserSession usersession;    
        public ReportForm( Report report, UserSession userSession)
        {   
            this.report = report;
            _userRepository = new UserRepository();
            _postRepository = new PostRepository();
            this.usersession = userSession;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage form = new AdminHomePage(usersession);
            this.Hide();
            form.Show();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            User user = _userRepository.getUserByID((int)report.UserId);
            Post post = _postRepository.getPostByID((int)report.PostId);
            txtUserReport.Text = user.UserName;
            txtResonreport.Text = report.ReportReason;
            txtReportPostContent.Text = post.Content;
            txtPostReportTitle.Text = post.Title;
            dtReport.Text = report.ReportDate.ToString();
        }

        private void btnBlockPost_Click(object sender, EventArgs e)
        {
            Post post = _postRepository.getPostByID((int)report.PostId);
            post.Status = "Rejected";
            if (_postRepository.UpdatePostByAdmin(post))
            {
                MessageBox.Show("Bạn đã gỡ bài đăng này!");
            }
        }
    }
}
