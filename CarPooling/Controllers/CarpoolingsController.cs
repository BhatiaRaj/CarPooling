using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarPooling.Data;
using CarPooling.Models;

namespace CarPooling.Controllers
{
    public class CarpoolingsController : Controller
    {
        private readonly CarpoolingDbContext _context;

        public CarpoolingsController(CarpoolingDbContext context)
        {
            _context = context;
        }

        // GET: Carpoolings
        public async Task<IActionResult> Index()
        {
              return _context.OppernigCarpooling != null ? 
                          View(await _context.OppernigCarpooling.ToListAsync()) :
                          Problem("Entity set 'CarpoolingDbContext.OppernigCarpooling'  is null.");
        }

        // GET: Carpoolings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OppernigCarpooling == null)
            {
                return NotFound();
            }

            var carpooling = await _context.OppernigCarpooling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carpooling == null)
            {
                return NotFound();
            }

            return View(carpooling);
        }

        // GET: Carpoolings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carpoolings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PsNo,EmployeeName,EmailId,Dept,Address,Mobile,Wheeler,BPoint,Route,LTime,ATime,Person,Cost")] Carpooling carpooling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carpooling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carpooling);
        }

        // GET: Carpoolings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OppernigCarpooling == null)
            {
                return NotFound();
            }

            var carpooling = await _context.OppernigCarpooling.FindAsync(id);
            if (carpooling == null)
            {
                return NotFound();
            }
            return View(carpooling);
        }

        // POST: Carpoolings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PsNo,EmployeeName,EmailId,Dept,Address,Mobile,Wheeler,BPoint,Route,LTime,ATime,Person,Cost")] Carpooling carpooling)
        {
            if (id != carpooling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carpooling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarpoolingExists(carpooling.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carpooling);
        }

        // GET: Carpoolings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OppernigCarpooling == null)
            {
                return NotFound();
            }

            var carpooling = await _context.OppernigCarpooling
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carpooling == null)
            {
                return NotFound();
            }

            return View(carpooling);
        }

        // POST: Carpoolings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OppernigCarpooling == null)
            {
                return Problem("Entity set 'CarpoolingDbContext.OppernigCarpooling'  is null.");
            }
            var carpooling = await _context.OppernigCarpooling.FindAsync(id);
            if (carpooling != null)
            {
                _context.OppernigCarpooling.Remove(carpooling);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarpoolingExists(int id)
        {
          return (_context.OppernigCarpooling?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
