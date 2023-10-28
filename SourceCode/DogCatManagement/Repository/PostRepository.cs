﻿using DataAccess.DAO;
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

        public bool DeletePostByAdmin(Post post) => PostDAO.Instance.DeletePostByAdmin(post);

        public List<Post> GetAllPost() => PostDAO.Instance.GetAllPost();

        public bool UpdatePostByAdmin(Post post) => PostDAO.Instance.UpdatePostByAdmin(post);
    }
}
