using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using EPlanner.Models;

namespace EPlanner.Controllers
{
    public class EplannerController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: Eplanner
        public ActionResult Index()
        {

          //  var city = db.DbCity.ToList<City>();
            ViewBag.Area = new SelectList(db.DbCity, "Id", "CityName");

            return View();
        }

        public ActionResult HotelDetail()
        {
            
          
            return View();
        }

        public ActionResult About()
        {
           
            return View();
        }
        
        public ActionResult Confirmation()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Hotels()
        {
            return View();
        }

        public ActionResult Reservation()
        {
            return View();
        }


 
        public JsonResult Rooms()
        {
            var rooms = db.DbRoom.Where(x => x.RoomTypeId == 2).ToList();
            
            return Json(rooms, JsonRequestBehavior.AllowGet);
        }


         


    }
}