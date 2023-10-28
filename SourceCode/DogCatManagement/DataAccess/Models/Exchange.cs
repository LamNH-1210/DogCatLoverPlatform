using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Exchange
    {
        public int ExchangeId { get; set; }
        public int? UserId1 { get; set; }
        public int? UserId2 { get; set; }
        public string ItemType { get; set; } = null!;
        public DateTime ExchangeDate { get; set; }

        public virtual User? UserId1Navigation { get; set; }
        public virtual User? UserId2Navigation { get; set; }
    }
}
