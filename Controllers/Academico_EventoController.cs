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
    public class Academico_EventoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Academico_EventoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Academico_Evento
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Academico_Evento.Include(a => a.Academico).Include(a => a.Evento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Academico_Evento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico_Evento = await _context.Academico_Evento
                .Include(a => a.Academico)
                .Include(a => a.Evento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academico_Evento == null)
            {
                return NotFound();
            }

            return View(academico_Evento);
        }

        // GET: Academico_Evento/Create
        public IActionResult Create()
        {
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "IdAcademico", "NoControl");
            ViewData["EventoId"] = new SelectList(_context.Evento, "IdEvento", "NombreEvento");
            return View();
        }

        // POST: Academico_Evento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AcademicoId,EventoId")] Academico_Evento academico_Evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(academico_Evento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "IdAcademico", "NoControl", academico_Evento.AcademicoId);
            ViewData["EventoId"] = new SelectList(_context.Evento, "IdEvento", "NombreEvento", academico_Evento.EventoId);
            return View(academico_Evento);
        }

        // GET: Academico_Evento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico_Evento = await _context.Academico_Evento.FindAsync(id);
            if (academico_Evento == null)
            {
                return NotFound();
            }
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "IdAcademico", "NoControl", academico_Evento.AcademicoId);
            ViewData["EventoId"] = new SelectList(_context.Evento, "IdEvento", "NombreEvento", academico_Evento.EventoId);
            return View(academico_Evento);
        }

        // POST: Academico_Evento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AcademicoId,EventoId")] Academico_Evento academico_Evento)
        {
            if (id != academico_Evento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academico_Evento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Academico_EventoExists(academico_Evento.Id))
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
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "IdAcademico", "NoControl", academico_Evento.AcademicoId);
            ViewData["EventoId"] = new SelectList(_context.Evento, "IdEvento", "NombreEvento", academico_Evento.EventoId);
            return View(academico_Evento);
        }

        // GET: Academico_Evento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico_Evento = await _context.Academico_Evento
                .Include(a => a.Academico)
                .Include(a => a.Evento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academico_Evento == null)
            {
                return NotFound();
            }

            return View(academico_Evento);
        }

        // POST: Academico_Evento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var academico_Evento = await _context.Academico_Evento.FindAsync(id);
            _context.Academico_Evento.Remove(academico_Evento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Academico_EventoExists(int id)
        {
            return _context.Academico_Evento.Any(e => e.Id == id);
        }
    }
}
