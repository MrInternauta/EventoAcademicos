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
    public class TipoOrganizadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoOrganizadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoOrganizadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoOrganizador.ToListAsync());
        }

        // GET: TipoOrganizadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoOrganizador = await _context.TipoOrganizador
                .FirstOrDefaultAsync(m => m.IdTipoOrganizador == id);
            if (tipoOrganizador == null)
            {
                return NotFound();
            }

            return View(tipoOrganizador);
        }

        // GET: TipoOrganizadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoOrganizadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoOrganizador,Nombre,Descripcion")] TipoOrganizador tipoOrganizador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoOrganizador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoOrganizador);
        }

        // GET: TipoOrganizadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoOrganizador = await _context.TipoOrganizador.FindAsync(id);
            if (tipoOrganizador == null)
            {
                return NotFound();
            }
            return View(tipoOrganizador);
        }

        // POST: TipoOrganizadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoOrganizador,Nombre,Descripcion")] TipoOrganizador tipoOrganizador)
        {
            if (id != tipoOrganizador.IdTipoOrganizador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoOrganizador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoOrganizadorExists(tipoOrganizador.IdTipoOrganizador))
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
            return View(tipoOrganizador);
        }

        // GET: TipoOrganizadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoOrganizador = await _context.TipoOrganizador
                .FirstOrDefaultAsync(m => m.IdTipoOrganizador == id);
            if (tipoOrganizador == null)
            {
                return NotFound();
            }

            return View(tipoOrganizador);
        }

        // POST: TipoOrganizadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoOrganizador = await _context.TipoOrganizador.FindAsync(id);
            _context.TipoOrganizador.Remove(tipoOrganizador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoOrganizadorExists(int id)
        {
            return _context.TipoOrganizador.Any(e => e.IdTipoOrganizador == id);
        }
    }
}
