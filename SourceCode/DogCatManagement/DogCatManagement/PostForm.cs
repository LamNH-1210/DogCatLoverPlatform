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
    public partial class PostForm : Form
    {
        private Post post = new Post();
        private IUserRepository _userRepository;
        public PostForm(Post post)
        {       
            _userRepository = new UserRepository();
            this.post = post;
            InitializeComponent();
            Dictionary<string, string> combobox = new Dictionary<string, string>();
            combobox.Add("0", "Pending");
            combobox.Add("1", "Published");
            combobox.Add("2", "Rejected");
            cbbStatus.DataSource = new BindingSource(combobox, null);
            cbbStatus.DisplayMember = "Value";
            cbbStatus.ValueMember = "Key";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PostForm_Load(object sender, EventArgs e)
        {   
            User user1 = new User();
            user1 = _userRepository.getUserByID(post.UserId.Value);
            txtTitle.Text = post.Title.ToString();
            txtContent.Text = post.Content.ToString();
            txtUser.Text = user1.UserName.ToString();
            dtTime.Text = post.PostDate.ToString();
            cbbStatus.Text = post.Status.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Post user = new Post();
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
    }
}
