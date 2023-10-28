﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPostRepository
    {
        List<Post> GetAllPost();
        bool UpdatePostByAdmin(Post post);
        bool DeletePostByAdmin(Post post);
        void CreatePostByAdmin(Post post);
    }
}