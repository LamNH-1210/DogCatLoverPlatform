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
    public partial class LoginForm : Form
    {
        private IUserRepository _userRepository;
        private UserSession _userSession;
        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _userSession = new UserSession();
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            this.Hide();
            signupForm.Show();
        }
        // Button Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Check empty for email and password
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                User user = _userRepository.checkLogin(email, password);
                if (user != null)
                {
                    int role = user.RoleId;
                    switch (role)
                    {
                        case 0:
                            this.Hide();
                            CustomerHomePage customerpage = new CustomerHomePage();
                            customerpage.Show();
                            _userSession.UserId = user.UserId;
                            break;
                        case 1:
                            this.Hide();
                            break;
                        // for staff manager
                        case 2:
                            this.Hide();
                            _userSession.UserId = user.UserId;
                            AdminHomePage adminpage = new AdminHomePage(_userSession);
                            adminpage.Show();
                            break;
                        default:
                            MessageBox.Show("Hiện tại tài khoản của bạn đang bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Close Button
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
