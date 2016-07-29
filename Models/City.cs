using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPlanner.Models
{
    public class City
    {
        public int Id { set; get; }
        public string CityName { set; get; }
        
        public virtual ICollection<Hotel> Hotels { set; get; }
    }
}