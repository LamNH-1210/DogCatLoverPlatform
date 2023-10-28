using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public int? UserId { get; set; }
        public int? PostId { get; set; }
        public string ReportReason { get; set; } = null!;
        public DateTime ReportDate { get; set; }

        public virtual Post? Post { get; set; }
        public virtual User? User { get; set; }
    }
}
