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
    public class Role_UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Role_UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Role_Usuario
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Role_Usuario.Include(r => r.Role).Include(r => r.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Role_Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role_Usuario = await _context.Role_Usuario
                .Include(r => r.Role)
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (role_Usuario == null)
            {
                return NotFound();
            }

            return View(role_Usuario);
        }

        // GET: Role_Usuario/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre");
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email");
            return View();
        }

        // POST: Role_Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleId,UsuarioId")] Role_Usuario role_Usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(role_Usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre", role_Usuario.RoleId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email", role_Usuario.UsuarioId);
            return View(role_Usuario);
        }

        // GET: Role_Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role_Usuario = await _context.Role_Usuario.FindAsync(id);
            if (role_Usuario == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre", role_Usuario.RoleId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email", role_Usuario.UsuarioId);
            return View(role_Usuario);
        }

        // POST: Role_Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleId,UsuarioId")] Role_Usuario role_Usuario)
        {
            if (id != role_Usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(role_Usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Role_UsuarioExists(role_Usuario.Id))
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
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre", role_Usuario.RoleId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Email", role_Usuario.UsuarioId);
            return View(role_Usuario);
        }

        // GET: Role_Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role_Usuario = await _context.Role_Usuario
                .Include(r => r.Role)
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (role_Usuario == null)
            {
                return NotFound();
            }

            return View(role_Usuario);
        }

        // POST: Role_Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role_Usuario = await _context.Role_Usuario.FindAsync(id);
            _context.Role_Usuario.Remove(role_Usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Role_UsuarioExists(int id)
        {
            return _context.Role_Usuario.Any(e => e.Id == id);
        }
    }
}
