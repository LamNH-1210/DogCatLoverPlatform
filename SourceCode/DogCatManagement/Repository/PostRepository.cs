using DataAccess.DAO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PostRepository : IPostRepository
    {
        public void CreatePostByAdmin(Post post) => PostDAO.Instance.CreatePostByAdmin(post);

        public void CreatePostByMemeber(Post post) => PostDAO.Instance.CreatePostByMemeber(post);
        public bool DeletePostByAdmin(Post post) => PostDAO.Instance.DeletePostByAdmin(post);

        public void DeletePostByCustomer(int postid) => PostDAO.Instance.DeletePost(postid);

        public List<Post> GetAllPost() => PostDAO.Instance.GetAllPost();

        public Post getPostByID(int postid) =>PostDAO.Instance.getPostByID(postid);

        public List<Post> GetPosts() => PostDAO.Instance.GetPosts();

        public void UpdatePost(Post post) => PostDAO.Instance.UpdatePost(post);

        public bool UpdatePostByAdmin(Post post) => PostDAO.Instance.UpdatePostByAdmin(post);
        public List<Post> GetPostsByUserId(int userId) => PostDAO.Instance.GetPostsByUserId(userId);


    }
}
