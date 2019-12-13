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
    public class SedeEventosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SedeEventosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SedeEventos
        public async Task<IActionResult> Index()
        {
            return View(await _context.SedeEvento.ToListAsync());
        }

        // GET: SedeEventos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sedeEvento = await _context.SedeEvento
                .FirstOrDefaultAsync(m => m.IdSedeEvento == id);
            if (sedeEvento == null)
            {
                return NotFound();
            }

            return View(sedeEvento);
        }

        // GET: SedeEventos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SedeEventos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSedeEvento,NombreSedeEvento,DescripcionSedeEvento")] SedeEvento sedeEvento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sedeEvento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sedeEvento);
        }

        // GET: SedeEventos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sedeEvento = await _context.SedeEvento.FindAsync(id);
            if (sedeEvento == null)
            {
                return NotFound();
            }
            return View(sedeEvento);
        }

        // POST: SedeEventos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSedeEvento,NombreSedeEvento,DescripcionSedeEvento")] SedeEvento sedeEvento)
        {
            if (id != sedeEvento.IdSedeEvento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sedeEvento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SedeEventoExists(sedeEvento.IdSedeEvento))
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
            return View(sedeEvento);
        }

        // GET: SedeEventos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sedeEvento = await _context.SedeEvento
                .FirstOrDefaultAsync(m => m.IdSedeEvento == id);
            if (sedeEvento == null)
            {
                return NotFound();
            }

            return View(sedeEvento);
        }

        // POST: SedeEventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sedeEvento = await _context.SedeEvento.FindAsync(id);
            _context.SedeEvento.Remove(sedeEvento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SedeEventoExists(int id)
        {
            return _context.SedeEvento.Any(e => e.IdSedeEvento == id);
        }
    }
}
