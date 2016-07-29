using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPlanner.Models
{
    public class Room
    {
        public int Id { set; get; }
        public string RoomType { set; get; }
        public virtual ICollection<Hotel> Hotel{ set; get; }

    }
}