using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Configuration
    {
        public int ConfigId { get; set; }
        public string SettingName { get; set; } = null!;
        public string SettingValue { get; set; } = null!;
    }
}
