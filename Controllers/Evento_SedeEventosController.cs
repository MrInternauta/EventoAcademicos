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
    public class Evento_SedeEventosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Evento_SedeEventosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Evento_SedeEventos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Evento_SedeEvento.Include(e => e.Evento).Include(e => e.SedeEvento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Evento_SedeEventos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento_SedeEvento = await _context.Evento_SedeEvento
                .Include(e => e.Evento)
                .Include(e => e.SedeEvento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evento_SedeEvento == null)
            {
                return NotFound();
            }

            return View(evento_SedeEvento);
        }

        // GET: Evento_SedeEventos/Create
        public IActionResult Create()
        {
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento");
            ViewData["SedeEventoId"] = new SelectList(_context.SedeEvento, "Id", "DescripcionSedeEvento");
            return View();
        }

        // POST: Evento_SedeEventos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventoId,SedeEventoId")] Evento_SedeEvento evento_SedeEvento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento_SedeEvento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento", evento_SedeEvento.EventoId);
            ViewData["SedeEventoId"] = new SelectList(_context.SedeEvento, "Id", "DescripcionSedeEvento", evento_SedeEvento.SedeEventoId);
            return View(evento_SedeEvento);
        }

        // GET: Evento_SedeEventos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento_SedeEvento = await _context.Evento_SedeEvento.FindAsync(id);
            if (evento_SedeEvento == null)
            {
                return NotFound();
            }
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento", evento_SedeEvento.EventoId);
            ViewData["SedeEventoId"] = new SelectList(_context.SedeEvento, "Id", "DescripcionSedeEvento", evento_SedeEvento.SedeEventoId);
            return View(evento_SedeEvento);
        }

        // POST: Evento_SedeEventos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventoId,SedeEventoId")] Evento_SedeEvento evento_SedeEvento)
        {
            if (id != evento_SedeEvento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evento_SedeEvento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Evento_SedeEventoExists(evento_SedeEvento.Id))
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
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento", evento_SedeEvento.EventoId);
            ViewData["SedeEventoId"] = new SelectList(_context.SedeEvento, "Id", "DescripcionSedeEvento", evento_SedeEvento.SedeEventoId);
            return View(evento_SedeEvento);
        }

        // GET: Evento_SedeEventos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento_SedeEvento = await _context.Evento_SedeEvento
                .Include(e => e.Evento)
                .Include(e => e.SedeEvento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evento_SedeEvento == null)
            {
                return NotFound();
            }

            return View(evento_SedeEvento);
        }

        // POST: Evento_SedeEventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var evento_SedeEvento = await _context.Evento_SedeEvento.FindAsync(id);
            _context.Evento_SedeEvento.Remove(evento_SedeEvento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Evento_SedeEventoExists(int id)
        {
            return _context.Evento_SedeEvento.Any(e => e.Id == id);
        }
    }
}
