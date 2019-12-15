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
    public class Academico_AcademiasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Academico_AcademiasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Academico_Academias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Academico_Academia.Include(a => a.Academia).Include(a => a.Academico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Academico_Academias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico_Academia = await _context.Academico_Academia
                .Include(a => a.Academia)
                .Include(a => a.Academico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academico_Academia == null)
            {
                return NotFound();
            }

            return View(academico_Academia);
        }

        // GET: Academico_Academias/Create
        public IActionResult Create()
        {
            ViewData["AcademiaId"] = new SelectList(_context.Academia, "Id", "NombreAcademia");
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id");
            return View();
        }

        // POST: Academico_Academias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AcademicoId,AcademiaId")] Academico_Academia academico_Academia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(academico_Academia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademiaId"] = new SelectList(_context.Academia, "Id", "NombreAcademia", academico_Academia.AcademiaId);
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id", academico_Academia.AcademicoId);
            return View(academico_Academia);
        }

        // GET: Academico_Academias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico_Academia = await _context.Academico_Academia.FindAsync(id);
            if (academico_Academia == null)
            {
                return NotFound();
            }
            ViewData["AcademiaId"] = new SelectList(_context.Academia, "Id", "NombreAcademia", academico_Academia.AcademiaId);
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id", academico_Academia.AcademicoId);
            return View(academico_Academia);
        }

        // POST: Academico_Academias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AcademicoId,AcademiaId")] Academico_Academia academico_Academia)
        {
            if (id != academico_Academia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academico_Academia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Academico_AcademiaExists(academico_Academia.Id))
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
            ViewData["AcademiaId"] = new SelectList(_context.Academia, "Id", "NombreAcademia", academico_Academia.AcademiaId);
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id", academico_Academia.AcademicoId);
            return View(academico_Academia);
        }

        // GET: Academico_Academias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico_Academia = await _context.Academico_Academia
                .Include(a => a.Academia)
                .Include(a => a.Academico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academico_Academia == null)
            {
                return NotFound();
            }

            return View(academico_Academia);
        }

        // POST: Academico_Academias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var academico_Academia = await _context.Academico_Academia.FindAsync(id);
            _context.Academico_Academia.Remove(academico_Academia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Academico_AcademiaExists(int id)
        {
            return _context.Academico_Academia.Any(e => e.Id == id);
        }
    }
}
