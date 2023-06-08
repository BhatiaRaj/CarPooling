using CarPooling.Data;
using CarPooling.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarPooling.Controllers
{
    public class ApplyRequectController : Controller
    {
        private readonly CarpoolingDbContext applyRequectDb;

        public ApplyRequectController(CarpoolingDbContext applyRequectDb)
        {
            this.applyRequectDb = applyRequectDb;
        }

        [HttpGet]
        public IActionResult ApplyRequect()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApplyRequest(ApplyRequect addApplyRequect)
        {
            var ApplyRequect = new ApplyRequect()
            {
                UserName = addApplyRequect.UserName,
                PsNo = addApplyRequect.PsNo,
                PickUpPoint = addApplyRequect.PickUpPoint,
                Mobile = addApplyRequect.Mobile,
                Time = addApplyRequect.Time
            };

            await applyRequectDb.ApplyRequests.AddAsync(ApplyRequect);
            await applyRequectDb.SaveChangesAsync();

            // Optionally, you can return a success message or redirect to a success page
            return Json(new { success = true, message = "Apply request submitted successfully." });
        }
    }
}