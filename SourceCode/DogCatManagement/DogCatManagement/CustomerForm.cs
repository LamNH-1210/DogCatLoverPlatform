using DataAccess.DAO;
using DataAccess.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DogCatManagement
{
    public partial class CustomerForm : Form
    {   
        private UserDTO user;
        private IUserRepository _userRepository;
        private UserSession userSession;
        public CustomerForm(UserDTO user, UserSession userSession)
        {
            InitializeComponent();
            this.user = user;
            this.userSession = userSession;
            _userRepository = new UserRepository();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtEmailCustomer.Text = "";
            txtPasswordCustomer.Text = "";
            txtFullNameCustomer.Text = "";
            cbbRoleCustomer.Text = "";
        }

        private void btnBackCustomer_Click(object sender, EventArgs e)
        {
            AdminHomePage page = new AdminHomePage(userSession);
            this.Hide();
            page.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            txtEmailCustomer.Text = user.Email;
            txtFullNameCustomer.Text = user.UserName;
            txtPasswordCustomer.Text = user.Password;
            var userList = _userRepository.GetAllUserList();
            var uniqueList = userList.Select(u => u.RoleId).Distinct().ToList();
            cbbRoleCustomer.DataSource = uniqueList;
            cbbRoleCustomer.DisplayMember = "RoleId";
            cbbRoleCustomer.SelectedItem = uniqueList.FirstOrDefault(c => c == user.RoleId);
        }
        // Add User
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (txtEmailCustomer.Text == "" || txtFullNameCustomer.Text == "" || txtPasswordCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin trước khi thêm khách hàng");

            }
            else
            {
                     user = GetUserFromForm();          
                    _userRepository.AddNewUser(user);
                    MessageBox.Show("Bạn đã thêm thành công người dùng", "Thông báo", MessageBoxButtons.OK); 
            }
        }

        // Get Object 
        private User GetUserFromForm()
        {
            User user = new User();
            user.UserName = txtFullNameCustomer.Text;
            user.Email = txtEmailCustomer.Text.Trim();
            user.Password = txtPasswordCustomer.Text.Trim();
            if (cbbRoleCustomer.SelectedValue != null && int.TryParse(cbbRoleCustomer.SelectedValue.ToString(), out int roleId))
            {
                user.RoleId = roleId;
            }

            return user;
        }
        // Get DTO User 
        private UserDTO GetUserDTOFromForm()
        {
            UserDTO newuser = new UserDTO();
            newuser.UserId = user.UserId; 
            newuser.UserName = txtFullNameCustomer.Text;
            newuser.Email = txtEmailCustomer.Text.Trim();
            newuser.Password = txtPasswordCustomer.Text.Trim();
            newuser.RoleId = Int32.Parse(cbbRoleCustomer.Text.Trim());
            return newuser;
        }

        // Update User
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {   

          
            if (checkNullEmplty())
            {
                UserDTO newuser = GetUserDTOFromForm();
                if (newuser.UserId != 0)
                {
                    if (_userRepository.UpdateUser(newuser))
                    {
                        MessageBox.Show("Bạn đã cập nhật thành công user rồi nhé !", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy user để cập nhật");
                    }
                }
                else
                {
                    MessageBox.Show("Hiện tại không thể tìm thấy được id của người dùng, vui lồng kiểm tra lại!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ trước khi update");
            }
            
        }


        // check null
        private bool checkNullEmplty()
        {
            if (string.IsNullOrEmpty(txtEmailCustomer.Text)||string.IsNullOrEmpty(txtFullNameCustomer.Text)|| string.IsNullOrEmpty(txtPasswordCustomer.Text))
            {
                return false;
            }
            return true;
        }

        // check id 
        private bool checkDuplicateID(int id)
        {
            User user = null;
            user = _userRepository.getUserByID(id);
            if (user != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
