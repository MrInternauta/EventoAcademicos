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
    public class Evento_DocumentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Evento_DocumentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Evento_Documentos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Evento_Documento.Include(e => e.Documento).Include(e => e.Evento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Evento_Documentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento_Documento = await _context.Evento_Documento
                .Include(e => e.Documento)
                .Include(e => e.Evento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evento_Documento == null)
            {
                return NotFound();
            }

            return View(evento_Documento);
        }

        // GET: Evento_Documentos/Create
        public IActionResult Create()
        {
            ViewData["DocumentoId"] = new SelectList(_context.Documento, "Id", "NombreDocumento");
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento");
            return View();
        }

        // POST: Evento_Documentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventoId,DocumentoId")] Evento_Documento evento_Documento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento_Documento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DocumentoId"] = new SelectList(_context.Documento, "Id", "NombreDocumento", evento_Documento.DocumentoId);
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento", evento_Documento.EventoId);
            return View(evento_Documento);
        }

        // GET: Evento_Documentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento_Documento = await _context.Evento_Documento.FindAsync(id);
            if (evento_Documento == null)
            {
                return NotFound();
            }
            ViewData["DocumentoId"] = new SelectList(_context.Documento, "Id", "NombreDocumento", evento_Documento.DocumentoId);
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento", evento_Documento.EventoId);
            return View(evento_Documento);
        }

        // POST: Evento_Documentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventoId,DocumentoId")] Evento_Documento evento_Documento)
        {
            if (id != evento_Documento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evento_Documento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Evento_DocumentoExists(evento_Documento.Id))
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
            ViewData["DocumentoId"] = new SelectList(_context.Documento, "Id", "NombreDocumento", evento_Documento.DocumentoId);
            ViewData["EventoId"] = new SelectList(_context.Evento, "Id", "NombreEvento", evento_Documento.EventoId);
            return View(evento_Documento);
        }

        // GET: Evento_Documentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evento_Documento = await _context.Evento_Documento
                .Include(e => e.Documento)
                .Include(e => e.Evento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evento_Documento == null)
            {
                return NotFound();
            }

            return View(evento_Documento);
        }

        // POST: Evento_Documentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var evento_Documento = await _context.Evento_Documento.FindAsync(id);
            _context.Evento_Documento.Remove(evento_Documento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Evento_DocumentoExists(int id)
        {
            return _context.Evento_Documento.Any(e => e.Id == id);
        }
    }
}
