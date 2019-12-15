using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControlWeb.Context;
using ControlWeb.Models;

namespace ControlWeb.Controllers
{
    public class AcademiasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AcademiasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Academias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Academia.ToListAsync());
        }

        // GET: Academias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academia = await _context.Academia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academia == null)
            {
                return NotFound();
            }

            return View(academia);
        }

        // GET: Academias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Academias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreAcademia,DescripcionAcademia")] Academia academia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(academia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(academia);
        }

        // GET: Academias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academia = await _context.Academia.FindAsync(id);
            if (academia == null)
            {
                return NotFound();
            }
            return View(academia);
        }

        // POST: Academias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreAcademia,DescripcionAcademia")] Academia academia)
        {
            if (id != academia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcademiaExists(academia.Id))
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
            return View(academia);
        }

        // GET: Academias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academia = await _context.Academia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academia == null)
            {
                return NotFound();
            }

            return View(academia);
        }

        // POST: Academias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var academia = await _context.Academia.FindAsync(id);
            _context.Academia.Remove(academia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcademiaExists(int id)
        {
            return _context.Academia.Any(e => e.Id == id);
        }
    }
}
