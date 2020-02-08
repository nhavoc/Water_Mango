using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SQLite;
using System.Configuration;
using System.Data;
using PWM.Models;
using PWM.Data;
using System.Threading;
using System.Data.Entity;

namespace PWM.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;
        public HomeController()
        {
            db = new DataContext();
        }
        public ActionResult Index()
        {
            var plants = db.Plants.ToList();
            
            return View(plants);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WaterPlant(int id)
        {
            try
            {
                var plant = db.Plants.SingleOrDefault(p => p.Id == id);
                Thread.Sleep(10000);
                plant.LastWatered = DateTime.Now.AddSeconds(5);
                db.SaveChanges();


                return PartialView("_PartialPlants", db.Plants.ToList());
            }
            catch (Exception)
            {
                return PartialView("_PartialPlants", db.Plants.ToList());
            }
        }

        public ActionResult WaterAll(List<int> PlantIds)
        {
            try
            {
                Thread.Sleep(10000);

                foreach (var id in PlantIds)
                {
                    var plant = db.Plants.SingleOrDefault(p => p.Id == id);
                    plant.LastWatered = DateTime.Now.AddSeconds(5);
                }

                db.SaveChanges();

                return PartialView("_PartialPlants", db.Plants.ToList());

            }
            catch (Exception)
            {
                return PartialView("_PartialPlants", db.Plants.ToList());
            }
        }
    }
}