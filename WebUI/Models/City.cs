using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Description { get; set; }
        public int DistrictId { get; set; }
    }
}