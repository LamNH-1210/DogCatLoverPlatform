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
using User = DataAccess.Models.User;

namespace DogCatManagement
{
    public partial class PostForm : Form
    {
        private Post post;
        int id;
        private IUserRepository _userRepository;
        private IPostRepository _postRepository;
        private UserSession _userSession;
        public PostForm(Post post, int userid)
        {       
            _userRepository = new UserRepository();
            _postRepository = new PostRepository();
            _userSession = new UserSession();
            this.post = post;
            this.id= userid;
            InitializeComponent();
            Dictionary<string, string> combobox = new Dictionary<string, string>();
            combobox.Add("Pending", "Pending");
            combobox.Add("Published", "Published");
            combobox.Add("Rejected", "Rejected");
            cbbStatus.DataSource = new BindingSource(combobox, null);
            cbbStatus.DisplayMember = "Value";
            cbbStatus.ValueMember = "Key";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            DataAccess.Models.User user1 = new DataAccess.Models.User();
            user1 = _userRepository.getUserByID(id);
            txtTitle.Text = post.Title.ToString();
            txtContent.Text = post.Content.ToString();
            txtUser.Text = user1.UserName.ToString();
            dtTime.Text = post.PostDate.ToString();
            cbbStatus.Text = post.Status.ToString();
        }

        // Get Post ID
        private Post GetPostFromForm()
        {
            Post postadd = new Post();
            postadd.PostDate = DateTime.Now;
            postadd.Title = txtTitle.Text;
            postadd.Status = cbbStatus.SelectedValue.ToString();
            postadd.Content = txtContent.Text;
            postadd.UserId = id;
            postadd.PostId = post.PostId;
            return postadd;
        }
        // Add CLick
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Post postafter = new Post();
            if (txtTitle.Text == "" || txtContent.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin trước khi tạo post");

            }
            else
            {
                postafter = GetPostFromForm();
                _postRepository.CreatePostByAdmin(postafter);
                MessageBox.Show("Bạn đã thêm thành công người dùng", "Thông báo", MessageBoxButtons.OK);
            }
        }
        // Chấp nhận , từ chối
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Post postupdate = new Post();
            postupdate = GetPostFromForm();
            _postRepository.UpdatePostByAdmin(postupdate);
            MessageBox.Show("Đã duyệt bài đăng");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Post postupdate = new Post();
            postupdate = GetPostFromForm();
            _postRepository.UpdatePostByAdmin(postupdate);
            MessageBox.Show("Đã từ chối bài đăng");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _userSession.UserId = id;
            User userPost = _userRepository.getUserByID(id);
            AdminHomePage form = new AdminHomePage(_userSession);
            this.Hide();
            form.Show();
        }
    }
}