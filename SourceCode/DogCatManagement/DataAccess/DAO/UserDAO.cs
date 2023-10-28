using DataAccess.DTO;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        // Singlaton UserDAO
        public static UserDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        
        // Get All User 
        public List<UserDTO> GetAllUserList()
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                List<UserDTO> userlist = dbContext.Users.Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    Email = u.Email,
                    UserName = u.UserName,
                    Password = u.Password,
                    RoleId = u.RoleId
                }).ToList();
                return userlist;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Check Login
        public User checkLogin(string email , string password)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Users.FirstOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // GetUsserByID
        public User getUserByID(int id)
        {
            try
            {
                var dbContext = new DogCatLoverPlatformDBContext();
                return dbContext.Users.FirstOrDefault(m => m.UserId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Add New User
        public void AddNewUser(User user)
        {
            try
            {
                var dbContex = new DogCatLoverPlatformDBContext();
                dbContex.Add(user);
                dbContex.SaveChanges();

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Update User
        public bool UpdateUser(UserDTO user)
        {
            try
            {
                var dbContex = new DogCatLoverPlatformDBContext();
                var userupdate = dbContex.Users.FirstOrDefault(u => u.UserId == user.UserId);
                if (userupdate != null)
                {
                    userupdate.UserName = user.UserName;
                    userupdate.Password = user.Password;
                    userupdate.RoleId = user.RoleId;
                    userupdate.Email = user.Email;
                }
                dbContex.Update(userupdate);
                dbContex.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
        // Delete User 
        public bool DeleteUser(UserDTO userDTO)
        {
            try {   
                var dbContex = new DogCatLoverPlatformDBContext();
                var user = dbContex.Users.FirstOrDefault(u => u.UserId == userDTO.UserId);
                if(user != null)
                {
                    user.RoleId = 3;
                    dbContex.Update(user);
                    dbContex.SaveChanges();    
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }
    }
}
