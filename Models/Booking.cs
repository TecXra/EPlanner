using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace EPlanner.Models
{
    public class Booking
    {
        public int Id { set; get; }
        public int RoomId { set; get; }

        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        public int UserId { set; get; }

        [ForeignKey("UserId")]
        public virtual SiteUser SiteUser  { get; set; }

        public string BookingDate { set; get; }
        public string CheckInDate { set; get; }
        public string CheckOutDate { set; get; }

    }
}