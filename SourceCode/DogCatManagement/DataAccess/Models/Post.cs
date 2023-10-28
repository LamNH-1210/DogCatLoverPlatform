using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Post
    {
        public Post()
        {
            Reports = new HashSet<Report>();
        }

        public int PostId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime PostDate { get; set; }
        public string Status { get; set; } = null!;

        public virtual User? User { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
