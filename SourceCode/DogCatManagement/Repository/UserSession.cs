using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class UserSession
    {
        private static UserSession _instance;
        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        public int UserId { get; set; } // Thêm thuộc tính UserId

        public UserSession()
        {
        }
    }
}
