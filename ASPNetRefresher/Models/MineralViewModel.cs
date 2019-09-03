using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetRefresher.Models
{
    public class MineralViewModel
    {
        public string sample_name { get; set; }
        public string lat_max { get; set; }
        public string long_max { get; set; }
        public string rock_name { get; set; }
        public string mineral { get; set; }
        public string tectonic_setting { get; set; }
    }
}