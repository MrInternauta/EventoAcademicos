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
    public class AcademicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AcademicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Academicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Academico.ToListAsync());
        }

        // GET: Academicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico = await _context.Academico
                .FirstOrDefaultAsync(m => m.IdAcademico == id);
            if (academico == null)
            {
                return NotFound();
            }

            return View(academico);
        }

        // GET: Academicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Academicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAcademico,IdFacultad,IdOrganizador,NoControl,Rfc")] Academico academico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(academico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(academico);
        }

        // GET: Academicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico = await _context.Academico.FindAsync(id);
            if (academico == null)
            {
                return NotFound();
            }
            return View(academico);
        }

        // POST: Academicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAcademico,IdFacultad,IdOrganizador,NoControl,Rfc")] Academico academico)
        {
            if (id != academico.IdAcademico)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcademicoExists(academico.IdAcademico))
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
            return View(academico);
        }

        // GET: Academicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academico = await _context.Academico
                .FirstOrDefaultAsync(m => m.IdAcademico == id);
            if (academico == null)
            {
                return NotFound();
            }

            return View(academico);
        }

        // POST: Academicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var academico = await _context.Academico.FindAsync(id);
            _context.Academico.Remove(academico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcademicoExists(int id)
        {
            return _context.Academico.Any(e => e.IdAcademico == id);
        }
    }
}
