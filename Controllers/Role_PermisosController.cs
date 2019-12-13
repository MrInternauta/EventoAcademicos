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
    public class Role_PermisosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Role_PermisosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Role_Permisos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Role_Permiso.Include(r => r.Permiso).Include(r => r.Role);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Role_Permisos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role_Permiso = await _context.Role_Permiso
                .Include(r => r.Permiso)
                .Include(r => r.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (role_Permiso == null)
            {
                return NotFound();
            }

            return View(role_Permiso);
        }

        // GET: Role_Permisos/Create
        public IActionResult Create()
        {
            ViewData["PermisoId"] = new SelectList(_context.Permiso, "IdPermiso", "Clave");
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre");
            return View();
        }

        // POST: Role_Permisos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleId,PermisoId")] Role_Permiso role_Permiso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(role_Permiso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PermisoId"] = new SelectList(_context.Permiso, "IdPermiso", "Clave", role_Permiso.PermisoId);
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre", role_Permiso.RoleId);
            return View(role_Permiso);
        }

        // GET: Role_Permisos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role_Permiso = await _context.Role_Permiso.FindAsync(id);
            if (role_Permiso == null)
            {
                return NotFound();
            }
            ViewData["PermisoId"] = new SelectList(_context.Permiso, "IdPermiso", "Clave", role_Permiso.PermisoId);
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre", role_Permiso.RoleId);
            return View(role_Permiso);
        }

        // POST: Role_Permisos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleId,PermisoId")] Role_Permiso role_Permiso)
        {
            if (id != role_Permiso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(role_Permiso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Role_PermisoExists(role_Permiso.Id))
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
            ViewData["PermisoId"] = new SelectList(_context.Permiso, "IdPermiso", "Clave", role_Permiso.PermisoId);
            ViewData["RoleId"] = new SelectList(_context.Role, "IdRol", "Nombre", role_Permiso.RoleId);
            return View(role_Permiso);
        }

        // GET: Role_Permisos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role_Permiso = await _context.Role_Permiso
                .Include(r => r.Permiso)
                .Include(r => r.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (role_Permiso == null)
            {
                return NotFound();
            }

            return View(role_Permiso);
        }

        // POST: Role_Permisos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role_Permiso = await _context.Role_Permiso.FindAsync(id);
            _context.Role_Permiso.Remove(role_Permiso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Role_PermisoExists(int id)
        {
            return _context.Role_Permiso.Any(e => e.Id == id);
        }
    }
}
