using System;
using System.Linq;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal baseQuote = 50m;

            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

            if (age <= 18) baseQuote += 100;
            else if (age <= 25) baseQuote += 50;
            else baseQuote += 25;

            if (insuree.CarYear < 2000) baseQuote += 25;
            if (insuree.CarYear > 2015) baseQuote += 25;

            if (insuree.CarMake.ToLower() == "porsche") baseQuote += 25;
            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera") baseQuote += 25;

            baseQuote += insuree.SpeedingTicket * 10;

            if (insuree.DUI) baseQuote *= 1.25m;
            if (insuree.CoverageType) baseQuote *= 1.5m;

            return baseQuote;
        }
    }
}
