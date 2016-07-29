using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPlanner.Models
{
    public class Event
    {

        public int Id { set; get; }

        public string EventType { set; get; }

        public virtual ICollection<Hotel> Hotel { set; get; }

    }
}