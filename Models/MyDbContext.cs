using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EPlanner.Models
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() : base("name=MyDbContext")   //connection string name
        {

        }

        public DbSet<City> DbCity { get; set; }
        public DbSet<Hotel> DbHotel { get; set; }
        public DbSet<Room> DbRoom { get; set; }
        public DbSet<Event> DbEvent { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Hotel>()
                        .HasMany<Room>(s => s.Room)
                        .WithMany(c => c.Hotel)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("HotelId");
                            cs.MapRightKey("RoomId");
                            cs.ToTable("HotelRoom");
                        });

            modelBuilder.Entity<Hotel>()
                        .HasMany<Event>(s => s.Event)
                        .WithMany(c => c.Hotel)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("HotelId");
                            cs.MapRightKey("EventId");
                            cs.ToTable("HotelEvent");
                        });

            


        }










    }
}