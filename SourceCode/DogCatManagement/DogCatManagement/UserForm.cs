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
    public partial class UserForm : Form
    {
        private UserSession _userSession;
        private CustomerHomePage _customerHomePage;
        private IUserRepository _userRepository;
        private User _user;
        public UserForm(UserSession userSession)
        {
            InitializeComponent();
            _userSession = userSession;
            _customerHomePage = new CustomerHomePage(_userSession);
            _userRepository = new UserRepository();
            _user = _userRepository.getUserByID(_userSession.UserId);
            lb_UserNameEmpty.Visible = false;
            lb_PasswordEmpty.Visible = false;
            lb_EmailEmpty.Visible = false;
        }
        public UserForm(string userName, string password, string email)
        {
            txt_Username.Text = userName;
            txt_Password.Text = password;
            txt_Email.Text = email;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _customerHomePage.Show();
        }

        private void btn_UpdateUserInfo_Click(object sender, EventArgs e)
        {
            string updateUsername = txt_Username.Text.Trim();
            string updatePassword = txt_Password.Text.Trim();
            string updateEmail = txt_Email.Text.Trim();
            if (string.IsNullOrEmpty(updateUsername) && string.IsNullOrEmpty(updateEmail) && string.IsNullOrEmpty(updatePassword))
            {
                lb_UserNameEmpty.Visible = true;
                lb_PasswordEmpty.Visible = true;
                lb_EmailEmpty.Visible = true;
                return;
            }
            try
            {
                User user_Update = _userRepository.getUserByID(_userSession.UserId);
                if (user_Update != null)
                {
                    user_Update.UserId = _userSession.UserId;
                    user_Update.Password = updatePassword;
                    user_Update.UserName = updateUsername;
                    user_Update.Email = updateEmail;
                    _userRepository.UpdateUserByCustomer(user_Update);
                    MessageBox.Show("Post updated successfully!!!");
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                _customerHomePage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("User updated Failed!!!");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            txt_Email.Text = _user.Email;
            txt_Password.Text = _user.Password;
            txt_Username.Text = _user.UserName;
        }
    }
}
