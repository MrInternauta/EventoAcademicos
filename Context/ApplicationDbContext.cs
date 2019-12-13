using Microsoft.EntityFrameworkCore;
using ControlWeb.Models;
using System;

namespace ControlWeb.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder   )
        {

            modelBuilder.Entity<DatosPersonales>()
            .Property(f => f.IdDatosPersonales)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<DatosPersonales>()
                .HasOne(X => X.CreatedBy)
                .WithMany()
                //.HasForeignKey(x => x.CreatedById)
                //.OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);


            modelBuilder.Entity<DatosPersonales>()
                .HasOne(X => X.UpdatedBy)
                .WithMany()
                //.HasForeignKey(x => x.UpdatedById)
                //.OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);



            modelBuilder.Entity<DatosPersonales>()
                .HasOne(X => X.DeletedBy)
                .WithMany()
                //.HasForeignKey(x => x.DeletedById)
                //.OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);

            //modelBuilder.Entity<DatosPersonales>()
            //.HasData(new DatosPersonales
            //{
            //    IdDatosPersonales = 1,
            //    Nombre = "Admin",
            //    ApellidoPaterno = "AdminPaterno",
            //    ApellidoMaterno = "AdminMaterno",
            //    FechaDeNacimiento = DateTime.Now
            //}); 

            //modelBuilder.Entity<Usuario>()
            //    .HasData(new Usuario
            //    {
            //        Id = 1,
            //        Email = "admin@admin",
            //        Password = "admin"
            //    });


        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Academico> Academico { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Academia> Academia { get; set; }
        public DbSet<DatosPersonales> DatosPersonales { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Facultad> Facultad { get; set; }
        public DbSet<Organizador> Organizador { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<SedeEvento> SedeEvento { get; set; }
        public DbSet<TipoOrganizador> TipoOrganizador { get; set; }

        /// <summary>
        /// Relaciones Intermedias entre las tablas
        /// </summary>
        public DbSet<Role_Usuario> Role_Usuario { get; set; }
        public DbSet<Role_Permiso> Role_Permiso { get; set; }

        public DbSet<Academico_Academia> Academico_Academia { get; set; }
        public DbSet<Academico_Evento> Academico_Evento { get; set; }
        public DbSet<Evento_Documento> Evento_Documento { get; set; }

        public DbSet<Evento_SedeEvento> Evento_SedeEvento { get; set; }




    }

}
