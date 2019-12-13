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
    public class DatosPersonalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatosPersonalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DatosPersonales
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DatosPersonales.Include(d => d.CreatedBy).Include(d => d.DeletedBy).Include(d => d.UpdatedBy);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DatosPersonales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datosPersonales = await _context.DatosPersonales
                .Include(d => d.CreatedBy)
                .Include(d => d.DeletedBy)
                .Include(d => d.UpdatedBy)
                .FirstOrDefaultAsync(m => m.IdDatosPersonales == id);
            if (datosPersonales == null)
            {
                return NotFound();
            }

            return View(datosPersonales);
        }

        // GET: DatosPersonales/Create
        public IActionResult Create()
        {
            ViewData["CreatedById"] = new SelectList(_context.Usuario, "Id", "Email");
            ViewData["DeletedById"] = new SelectList(_context.Usuario, "Id", "Email");
            ViewData["UpdatedById"] = new SelectList(_context.Usuario, "Id", "Email");
            return View();
        }

        // POST: DatosPersonales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDatosPersonales,Nombre,ApellidoPaterno,ApellidoMaterno,FechaDeNacimiento,Created,Updated,DeletedId,Deleted,CreatedById,UpdatedById,DeletedById")] DatosPersonales datosPersonales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datosPersonales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreatedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.CreatedById);
            ViewData["DeletedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.DeletedById);
            ViewData["UpdatedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.UpdatedById);
            return View(datosPersonales);
        }

        // GET: DatosPersonales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datosPersonales = await _context.DatosPersonales.FindAsync(id);
            if (datosPersonales == null)
            {
                return NotFound();
            }
            ViewData["CreatedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.CreatedById);
            ViewData["DeletedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.DeletedById);
            ViewData["UpdatedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.UpdatedById);
            return View(datosPersonales);
        }

        // POST: DatosPersonales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDatosPersonales,Nombre,ApellidoPaterno,ApellidoMaterno,FechaDeNacimiento,Created,Updated,DeletedId,Deleted,CreatedById,UpdatedById,DeletedById")] DatosPersonales datosPersonales)
        {
            if (id != datosPersonales.IdDatosPersonales)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datosPersonales);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatosPersonalesExists(datosPersonales.IdDatosPersonales))
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
            ViewData["CreatedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.CreatedById);
            ViewData["DeletedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.DeletedById);
            ViewData["UpdatedById"] = new SelectList(_context.Usuario, "Id", "Email", datosPersonales.UpdatedById);
            return View(datosPersonales);
        }

        // GET: DatosPersonales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datosPersonales = await _context.DatosPersonales
                .Include(d => d.CreatedBy)
                .Include(d => d.DeletedBy)
                .Include(d => d.UpdatedBy)
                .FirstOrDefaultAsync(m => m.IdDatosPersonales == id);
            if (datosPersonales == null)
            {
                return NotFound();
            }

            return View(datosPersonales);
        }

        // POST: DatosPersonales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datosPersonales = await _context.DatosPersonales.FindAsync(id);
            _context.DatosPersonales.Remove(datosPersonales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatosPersonalesExists(int id)
        {
            return _context.DatosPersonales.Any(e => e.IdDatosPersonales == id);
        }
    }
}
