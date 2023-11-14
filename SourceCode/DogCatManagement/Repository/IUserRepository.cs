using DataAccess.DAO;
using DataAccess.DTO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        List<UserDTO> GetAllUserList();
        User checkLogin(string email, string password);
        void AddNewUser(User user);
        bool DeleteUser(UserDTO user);
        bool UpdateUser(UserDTO user);
        User getUserByID(int id);
        void UpdateUserByCustomer(User user);
    }
}
