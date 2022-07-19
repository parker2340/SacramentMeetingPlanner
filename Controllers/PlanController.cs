using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;
using SacramentMeetingPlanner.Data;


namespace SacramentMeetingPlanner.Controllers
{
    public class PlanController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public PlanController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Plan
        public async Task<IActionResult> Index()
        {
              return _context.Plan != null ? 
                          View(await _context.Plan.ToListAsync()) :
                          Problem("Entity set 'SacramentMeetingPlannerContext.Plan'  is null.");
        }

        // GET: Plan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Plan == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan
                .FirstOrDefaultAsync(m => m.ID == id);
            
            if (plan == null)
            {
                return NotFound();
            }

            ViewData["Hymn"] = new SelectList(_context.Hymn, "Id", "HymnTitle");


            return View(plan);
        }

        // GET: Plan/Create
        public IActionResult Create()
        {
            ViewData["Hymn"] = new SelectList(_context.Hymn, "Id", "HymnTitle");
            return View();
        }

        // POST: Plan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Date,Presiding,Conducting,Pianist,Chorister,OP,CP,Opening,Intermediate,Closing,SpeakerOne, SpeakerOneSubject,SpeakerTwo, SpeakerTwoSubject,SpeakerThree,SpeakerThreeSubject ")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(plan);
        }

        // GET: Plan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Plan == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan.FindAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            ViewData["Hymn"] = new SelectList(_context.Hymn, "Id", "HymnTitle");

            return View(plan);
            
        }

        // POST: Plan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,Presiding,Conducting,Pianist,Chorister,OP,CP,Opening,Intermediate,Closing,SpeakerOne, SpeakerOneSubject,SpeakerTwo, SpeakerTwoSubject,SpeakerThree,SpeakerThreeSubject")] Plan plan)
        {
            if (id != plan.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanExists(plan.ID))
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
            return View(plan);
        }

        // GET: Plan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Plan == null)
            {
                return NotFound();
            }

            var plan = await _context.Plan
                .FirstOrDefaultAsync(m => m.ID == id);
            if (plan == null)
            {
                return NotFound();
            }

            return View(plan);
        }

        // POST: Plan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Plan == null)
            {
                return Problem("Entity set 'SacramentMeetingPlannerContext.Plan'  is null.");
            }
            var plan = await _context.Plan.FindAsync(id);
            if (plan != null)
            {
                _context.Plan.Remove(plan);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanExists(int id)
        {
          return (_context.Plan?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
