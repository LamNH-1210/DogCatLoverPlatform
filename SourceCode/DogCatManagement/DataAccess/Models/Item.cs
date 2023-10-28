using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int? OwnerId { get; set; }

        public virtual User? Owner { get; set; }
    }
}
