using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace EPlanner.Models
{
    public class Room
    {
        public int Id { set; get; }
        public int RoomTypeId { set; get; }

        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }



        public virtual ICollection<Hotel> Hotel{ set; get; }

    }
}