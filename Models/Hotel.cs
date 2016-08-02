using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EPlanner.Models
{
    public class Hotel
    {
        public int Id { set; get; }

        public int CityId { set; get; }

        public string HotelName { set; get; }

        public string PhoneNumber { set; get; }

        public string Address { set; get; }

        [ForeignKey("CityId")]
        public virtual City city { get; set; }
        
        public virtual ICollection<Event> Event { set; get; }

        public virtual ICollection<Room> Room { set; get; }




    }
}