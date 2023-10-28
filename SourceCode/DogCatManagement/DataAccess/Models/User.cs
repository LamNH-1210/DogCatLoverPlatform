using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            ExchangeUserId1Navigations = new HashSet<Exchange>();
            ExchangeUserId2Navigations = new HashSet<Exchange>();
            Items = new HashSet<Item>();
            Posts = new HashSet<Post>();
            Reports = new HashSet<Report>();
        }

        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual ICollection<Exchange> ExchangeUserId1Navigations { get; set; }
        public virtual ICollection<Exchange> ExchangeUserId2Navigations { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
