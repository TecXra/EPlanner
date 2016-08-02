namespace EPlanner.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
     using EPlanner.Models;
    using System.Collections.Generic;



    internal sealed class Configuration : DbMigrationsConfiguration<EPlanner.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EPlanner.Models.MyDbContext context)
        {

            var city = new List<City>
              {
              
               new City { CityName="Lahore" },
               new City {CityName=" Islamabad" },
               new City {CityName="Karachi" },
               new City { CityName="Multan" },
               new City { CityName="Faisalabad" },

              };
            city.ForEach(d => context.DbCity.Add(d));
            context.SaveChanges();




            var RoomType = new List<RoomType>
              {

               new RoomType { RoomName="Single Room" },
               new RoomType { RoomName="Double Room" },
               new RoomType { RoomName="Deluxe Room" },
               new RoomType { RoomName="Club Room" },
               new RoomType { RoomName="Executive Suite Room" },
                new RoomType { RoomName="Studio Room" },


              };
            RoomType.ForEach(d => context.DbRoomType.Add(d));
            context.SaveChanges();



            var Room = new List<Room>
               {
                new Room {RoomTypeId=1},
                new Room {RoomTypeId=2},
                new Room {RoomTypeId=2},
                new Room {RoomTypeId=3},
                new Room {RoomTypeId=4},
                new Room {RoomTypeId=2},
                new Room {RoomTypeId=4},
                new Room {RoomTypeId=5},
                new Room {RoomTypeId=5},
                new Room {RoomTypeId=6},
 
            };
            Room.ForEach(d => context.DbRoom.Add(d));
            context.SaveChanges();




        var Hotel = new List<Hotel>
               {
                new Hotel {HotelName="Pearl Continental Hotel",CityId=1},
                new Hotel {HotelName="Smart Hotel Lahore",CityId=2},
                new Hotel {HotelName=">Hotel Sunfort Lahore",CityId=1},
                new Hotel {HotelName="Hotel Crown Plaza Lahore",CityId=3},
                new Hotel {HotelName="Ambassador Hotel Lahore",CityId=4},
                 new Hotel {HotelName="Serai Boutique Hotel",CityId=1},
                  new Hotel {HotelName="Grand Regency Hotel",CityId=2},

            };
        Hotel.ForEach(d => context.DbHotel.Add(d));










    }
    }
}
