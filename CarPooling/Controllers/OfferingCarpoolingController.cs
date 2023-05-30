using CarPooling.Data;
using CarPooling.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarPooling.Controllers
{
    public class OfferingCarpoolingController : Controller
    {
        private readonly CarpoolingDbContext carpoolingDb;

        public OfferingCarpoolingController(CarpoolingDbContext carpoolingDb)
        {
            this.carpoolingDb = carpoolingDb;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var CarPooling = await carpoolingDb.OppernigCarpooling.ToListAsync();
            return View(CarPooling);
        }


        [HttpGet]
        public IActionResult OfferingCarpooling()
        {
            return View();
        }

        // Async Method
        [HttpPost]
        public async Task<IActionResult> OfferingCarpooling(Carpooling addcarpooling)
        {
            var carpooling = new Carpooling()
            {
                PsNo = addcarpooling.PsNo,
                EmployeeName = addcarpooling.EmployeeName,
                EmailId = addcarpooling.EmailId,
                Dept = addcarpooling.Dept,
                Address = addcarpooling.Address,
                Mobile = addcarpooling.Mobile,
                Wheeler = addcarpooling.Wheeler,
                BPoint = addcarpooling.BPoint,
                Route = addcarpooling.Route,
                LTime = addcarpooling.LTime,
                ATime  = addcarpooling.ATime,
                Person = addcarpooling.Person,
                Cost = addcarpooling.Cost
            };

            await carpoolingDb.OppernigCarpooling.AddAsync(carpooling);
            await carpoolingDb.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
