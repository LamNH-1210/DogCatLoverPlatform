using DataAccess.DTO;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class PostDAO
    {
        private static PostDAO instance = null;

        // Singlaton UserDAO
        public static PostDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PostDAO();
                }
                return instance;
            }
        }


        // Get All User 
        public List<Post> GetAllPost()
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Posts.Include(u => u.User).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CreatePostByAdmin(Post post)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                dbContext.Add(post);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdatePostByAdmin(Post post)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                var postupdate = dbContext.Posts.FirstOrDefault(u => u.PostId == post.PostId);
                if (postupdate != null)
                {
                    postupdate.Content = post.Content;
                    postupdate.Title = post.Title;
                    postupdate.PostDate = post.PostDate;
                    postupdate.Status = post.Status;
                }
                dbContext.Update(postupdate);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }


        public bool DeletePostByAdmin(Post post)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                var postupdate = dbContext.Posts.FirstOrDefault(u => u.PostId == post.PostId);
                if (postupdate != null)
                {
                    dbContext.Remove(postupdate);
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        // GetPostByID
        public Post getPostByID(int postid)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Posts.FirstOrDefault(m => m.PostId == postid);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CreatePostByMemeber(Post post)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                dbContext.Add(post);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Post> GetPosts()
        {

            try
            {
                var dbContent = new DogCatLoverPlatformDBContext();
                return dbContent.Posts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletePost(int postid)
        {
            try
            {
                var dbContent = new DogCatLoverPlatformDBContext();
                Post postInfo = getPostByID(postid);
                if(postInfo != null)
                {
                    dbContent.Posts.Remove(postInfo);
                    dbContent.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdatePost(Post post)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                var postupdate = dbContext.Posts.FirstOrDefault(u => u.PostId == post.PostId);
                if (postupdate != null)
                {
                    postupdate.Content = post.Content;
                    postupdate.Title = post.Title;
                    postupdate.PostDate = post.PostDate;
                    postupdate.Status = post.Status;
                }
                dbContext.Update(postupdate);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Post> GetPostsByUserId(int userId)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Posts.Where(p => p.UserId == userId).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }

}
