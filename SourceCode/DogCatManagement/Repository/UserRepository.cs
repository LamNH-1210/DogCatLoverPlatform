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
    public class UserRepository : IUserRepository
    {
        public void AddNewUser(User user) => UserDAO.Instance.AddNewUser(user);

        public User checkLogin(string email, string password) => UserDAO.Instance.checkLogin(email, password);

        public bool DeleteUser(UserDTO user) => UserDAO.Instance.DeleteUser(user);

        public List<UserDTO> GetAllUserList() => UserDAO.Instance.GetAllUserList();

        public User getUserByID(int id) => UserDAO.Instance.getUserByID(id);

        public bool UpdateUser(UserDTO user) => UserDAO.Instance.UpdateUser(user);
    }
}
