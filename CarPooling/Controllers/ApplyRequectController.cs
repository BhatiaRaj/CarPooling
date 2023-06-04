using CarPooling.Data;
using CarPooling.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarPooling.Controllers
{
    public class ApplyRequectController : Controller
    {
        //private readonly CarpoolingDbContext applyRequectDb;

        //public ApplyRequectController(CarpoolingDbContext applyRequectDb)
        //{
        //    this.applyRequectDb = applyRequectDb;
        //}

        [HttpGet]
        public IActionResult ApplyRequect()
        {
            return View();
        }

        //// Async Method
        //[HttpPost]
        //public async Task<IActionResult> ApplyRequect(ApplyRequect addApplyRequect)
        //{
        //    var ApplyRequect = new ApplyRequect()
        //    {
        //        UserName = addApplyRequect.UserName,
        //        PsNo = addApplyRequect.PsNo,
        //        PickUpPoint = addApplyRequect.PickUpPoint,
        //        Mobile = addApplyRequect.Mobile,
        //        Time = addApplyRequect.Time

        //    };

        //    await applyRequectDb.ApplyRequests.AddAsync(ApplyRequect);
        //    await applyRequectDb.SaveChangesAsync();
        //    return RedirectToAction("ApplyRequect");
        //}
    }
}
