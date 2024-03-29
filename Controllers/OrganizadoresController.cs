﻿using System;
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
    public class OrganizadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrganizadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Organizadores
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Organizador.Include(o => o.Academico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Organizadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizador = await _context.Organizador
                .Include(o => o.Academico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organizador == null)
            {
                return NotFound();
            }

            return View(organizador);
        }

        // GET: Organizadores/Create
        public IActionResult Create()
        {
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id");
            return View();
        }

        // POST: Organizadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdTipoOrganizador,IdEvento,AcademicoId")] Organizador organizador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organizador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id", organizador.AcademicoId);
            return View(organizador);
        }

        // GET: Organizadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizador = await _context.Organizador.FindAsync(id);
            if (organizador == null)
            {
                return NotFound();
            }
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id", organizador.AcademicoId);
            return View(organizador);
        }

        // POST: Organizadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdTipoOrganizador,IdEvento,AcademicoId")] Organizador organizador)
        {
            if (id != organizador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organizador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizadorExists(organizador.Id))
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
            ViewData["AcademicoId"] = new SelectList(_context.Academico, "Id", "Id", organizador.AcademicoId);
            return View(organizador);
        }

        // GET: Organizadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizador = await _context.Organizador
                .Include(o => o.Academico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organizador == null)
            {
                return NotFound();
            }

            return View(organizador);
        }

        // POST: Organizadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var organizador = await _context.Organizador.FindAsync(id);
            _context.Organizador.Remove(organizador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizadorExists(int id)
        {
            return _context.Organizador.Any(e => e.Id == id);
        }
    }
}
