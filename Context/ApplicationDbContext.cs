using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlWeb.Models;

namespace ControlWeb.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Academico> Academico { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
