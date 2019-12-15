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
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            //modelBuilder.Entity<DatosPersonales>()
            //    .HasOne(X => X.CreatedBy)
            //    .WithMany()
            //    .IsRequired(false);
            //.IsRequired(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.DatosPersonalesCList)
                .WithOne(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.DatosPersonalesUList)
                .WithOne(e => e.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.DatosPersonalesDList)
                .WithOne(e => e.DeletedBy)
                //.HasForeignKey(Z => Z.DeletedById)
                .OnDelete(DeleteBehavior.NoAction);


            //modelBuilder.Entity<Academico>()
            //    .HasOne<Usuario>(s => s.Usuario)
            //    .WithOne(a => a.Academico)
            //    .HasForeignKey<Usuario>(z => z.AcademicoId)
            //    .IsRequired(false);

            //modelBuilder.Entity<Estudiante>()
            //    .HasOne<Usuario>(s => s.Usuario)
            //    .WithOne(a => a.Estudiante)
            //    .HasForeignKey<Usuario>(z => z.EstudianteId)
            //    .IsRequired(false);
            //modelBuilder.Entity<Usuario>(entity =>
            //{
            //    entity.HasOne(p => p.DatosPersonales)
            //         .WithOne(a => a.CreatedBy)
            //         .HasForeignKey<DatosPersonales>(a => a.CreatedById);
            //});

            //modelBuilder.Entity<Usuario>(entity =>
            //{
            //    entity.HasOne(p => p.DatosPersonales)
            //         .WithOne(a => a)
            //         .HasForeignKey<DatosPersonales>(a => a.CreatedById);
            //});



            //modelBuilder.Entity<DatosPersonales>()
            //    .HasOne(X => X.UpdatedBy)
            //    .WithMany()
            //    .IsRequired(false);
            ////.HasForeignKey(x => x.UpdatedById)
            ////.IsRequired(false);



            //modelBuilder.Entity<DatosPersonales>()
            //    .HasOne(X => X.DeletedBy)
            //    .WithMany()
            //    .IsRequired(false);
            //.HasForeignKey(x => x.DeletedById)
            //.OnDelete(DeleteBehavior.NoAction);
            //.IsRequired(false);

            //modelBuilder.Entity<DatosPersonales>()
            //.HasData(new DatosPersonales
            //{
            //    IdDatosPersonales = 1,
            //    Nombre = "Admin",
            //    ApellidoPaterno = "AdminPaterno",
            //    ApellidoMaterno = "AdminMaterno",
            //    FechaDeNacimiento = DateTime.Now
            //}); 
            modelBuilder.Entity<Usuario>()
                .HasData(new Usuario
                {
                    Id = 1,
                    Email = "admin@admin",
                    Password = "admin"
                });

            modelBuilder.Entity<Permiso>()
                .HasData(new Permiso
                {
                    Id = 1,
                    Clave = "Ver",
                    Descripcion = "Ver items"
                });

            modelBuilder.Entity<Permiso>()
                .HasData(new Permiso
                {
                    Id = 2,
                    Clave = "Modificar",
                    Descripcion = "Modificar items"
                });

            modelBuilder.Entity<Permiso>()
                .HasData(new Permiso
                {
                    Id = 3,
                    Clave = "Eliminar",
                    Descripcion = "Eliminar items"
                });




            modelBuilder.Entity<Role>()
                .HasData(new Role
                {
                    Id = 1,
                    Nombre = "User",
                    Descripcion = "User"
                });

            modelBuilder.Entity<Role>()
                .HasData(new Role
                {
                    Id = 2,
                    Nombre = "admin",
                    Descripcion = "admin"
                });

            modelBuilder.Entity<Role>()
                .HasData(new Role
                {
                    Id = 3,
                    Nombre = "Super",
                    Descripcion = "super"
                });


            modelBuilder.Entity<Role_Permiso>()
                .HasData(new Role_Permiso
                {
                    Id = 1,
                    PermisoId = 1,
                    RoleId = 1,

                });

            modelBuilder.Entity<Role_Permiso>()
                .HasData(new Role_Permiso
                {
                    Id = 2,
                    PermisoId = 2,
                    RoleId = 2,

                });
            modelBuilder.Entity<Role_Permiso>()
                .HasData(new Role_Permiso
                {
                    Id = 3,
                    PermisoId = 3,
                    RoleId = 3,

                });

            modelBuilder.Entity<Role_Usuario>()
                .HasData(new Role_Usuario
                {
                    Id = 1,
                    UsuarioId = 1,
                    RoleId = 1,

                });


            modelBuilder.Entity<Role_Usuario>()
                .HasData(new Role_Usuario
                {
                    Id = 2,
                    UsuarioId = 1,
                    RoleId = 2,

                });

            modelBuilder.Entity<Role_Usuario>()
                .HasData(new Role_Usuario
                {
                    Id = 3,
                    UsuarioId = 1,
                    RoleId = 3,

                });







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
