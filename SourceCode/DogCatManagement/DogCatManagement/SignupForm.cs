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
    public partial class SignupForm : Form
    {
        private IUserRepository _userRepository;
        public SignupForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string re_password = txtRePassword.Text.Trim();
            string fullname = txtFullName.Text;

            // Check empty for email, password and repassword (Duplicate)
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(re_password) || string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trước khi đăng kí", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {   
                // Check duplicate password and repassword
                if (!password.Equals(re_password))
                {
                    MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    User user = new User
                    {
                        UserName = fullname,
                        Email = email,
                        Password = password,
                        RoleId = 0
                    };
                   // Add new user
                   _userRepository.AddNewUser(user);
                    MessageBox.Show("Bạn đã đăng kí thành công","Thông báo",MessageBoxButtons.OK);
                    Thread.Sleep(1000);
                    LoginForm form = new LoginForm()
;                   form.Show();
                    this.Hide();
                }
           
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
