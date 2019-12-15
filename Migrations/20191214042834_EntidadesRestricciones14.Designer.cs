﻿// <auto-generated />
using System;
using ControlWeb.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191214042834_EntidadesRestricciones14")]
    partial class EntidadesRestricciones14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControlWeb.Models.Academia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionAcademia")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NombreAcademia")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Academia");
                });

            modelBuilder.Entity("ControlWeb.Models.Academico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FacultadId")
                        .HasColumnType("int");

                    b.Property<int>("IdFacultad")
                        .HasColumnType("int");

                    b.Property<string>("NoControl")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Rfc")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.HasKey("Id");

                    b.HasIndex("FacultadId");

                    b.ToTable("Academico");
                });

            modelBuilder.Entity("ControlWeb.Models.Academico_Academia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademiaId")
                        .HasColumnType("int");

                    b.Property<int>("AcademicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcademiaId");

                    b.HasIndex("AcademicoId");

                    b.ToTable("Academico_Academia");
                });

            modelBuilder.Entity("ControlWeb.Models.Academico_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicoId")
                        .HasColumnType("int");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcademicoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Academico_Evento");
                });

            modelBuilder.Entity("ControlWeb.Models.DatosPersonales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeletedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DeletedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("DatosPersonales");
                });

            modelBuilder.Entity("ControlWeb.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionDocumento")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FormatoDocumento")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NombreDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("ControlWeb.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultadId")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("FacultadId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("ControlWeb.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionEvento")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("FechaEvento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEvento")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("ControlWeb.Models.Evento_Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentoId")
                        .HasColumnType("int");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Evento_Documento");
                });

            modelBuilder.Entity("ControlWeb.Models.Evento_SedeEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventoId")
                        .HasColumnType("int")
                        .HasMaxLength(55);

                    b.Property<int>("SedeEventoId")
                        .HasColumnType("int")
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("SedeEventoId");

                    b.ToTable("Evento_SedeEvento");
                });

            modelBuilder.Entity("ControlWeb.Models.Facultad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.ToTable("Facultad");
                });

            modelBuilder.Entity("ControlWeb.Models.Organizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicoId")
                        .HasColumnType("int");

                    b.Property<int?>("EventoId")
                        .HasColumnType("int");

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoOrganizador")
                        .HasColumnType("int");

                    b.Property<int?>("TipoOrganizadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AcademicoId");

                    b.HasIndex("EventoId");

                    b.HasIndex("TipoOrganizadorId");

                    b.ToTable("Organizador");
                });

            modelBuilder.Entity("ControlWeb.Models.Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("ControlWeb.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ControlWeb.Models.Role_Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermisoId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermisoId");

                    b.HasIndex("RoleId");

                    b.ToTable("Role_Permiso");
                });

            modelBuilder.Entity("ControlWeb.Models.Role_Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Role_Usuario");
                });

            modelBuilder.Entity("ControlWeb.Models.SedeEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionSedeEvento")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("NombreSedeEvento")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.ToTable("SedeEvento");
                });

            modelBuilder.Entity("ControlWeb.Models.TipoOrganizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("TipoOrganizador");
                });

            modelBuilder.Entity("ControlWeb.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicoId")
                        .HasColumnType("int");

                    b.Property<int>("DatosPersonalesId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AcademicoId")
                        .IsUnique();

                    b.HasIndex("DatosPersonalesId");

                    b.HasIndex("EstudianteId")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ControlWeb.Models.Academico", b =>
                {
                    b.HasOne("ControlWeb.Models.Facultad", "Facultad")
                        .WithMany()
                        .HasForeignKey("FacultadId");
                });

            modelBuilder.Entity("ControlWeb.Models.Academico_Academia", b =>
                {
                    b.HasOne("ControlWeb.Models.Academia", "Academia")
                        .WithMany("Academico_Academias")
                        .HasForeignKey("AcademiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Academico", "Academico")
                        .WithMany("Academico_Academias")
                        .HasForeignKey("AcademicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Academico_Evento", b =>
                {
                    b.HasOne("ControlWeb.Models.Academico", "Academico")
                        .WithMany("Academico_Eventos")
                        .HasForeignKey("AcademicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Evento", "Evento")
                        .WithMany("Academico_Eventos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.DatosPersonales", b =>
                {
                    b.HasOne("ControlWeb.Models.Usuario", "CreatedBy")
                        .WithMany("DatosPersonalesCList")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Usuario", "DeletedBy")
                        .WithMany("DatosPersonalesDList")
                        .HasForeignKey("DeletedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Usuario", "UpdatedBy")
                        .WithMany("DatosPersonalesUList")
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Estudiante", b =>
                {
                    b.HasOne("ControlWeb.Models.Facultad", "Facultad")
                        .WithMany()
                        .HasForeignKey("FacultadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Evento_Documento", b =>
                {
                    b.HasOne("ControlWeb.Models.Documento", "Documento")
                        .WithMany("Evento_Documentos")
                        .HasForeignKey("DocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Evento", "Evento")
                        .WithMany("Evento_Documentos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Evento_SedeEvento", b =>
                {
                    b.HasOne("ControlWeb.Models.Evento", "Evento")
                        .WithMany("Evento_SedeEventos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.SedeEvento", "SedeEvento")
                        .WithMany("Evento_SedeEventos")
                        .HasForeignKey("SedeEventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Organizador", b =>
                {
                    b.HasOne("ControlWeb.Models.Academico", "Academico")
                        .WithMany()
                        .HasForeignKey("AcademicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId");

                    b.HasOne("ControlWeb.Models.TipoOrganizador", "TipoOrganizador")
                        .WithMany()
                        .HasForeignKey("TipoOrganizadorId");
                });

            modelBuilder.Entity("ControlWeb.Models.Role_Permiso", b =>
                {
                    b.HasOne("ControlWeb.Models.Permiso", "Permiso")
                        .WithMany("Role_Permiso")
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Role", "Role")
                        .WithMany("Role_Permiso")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Role_Usuario", b =>
                {
                    b.HasOne("ControlWeb.Models.Role", "Role")
                        .WithMany("Role_Usuarios")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Usuario", "Usuario")
                        .WithMany("Role_Usuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlWeb.Models.Usuario", b =>
                {
                    b.HasOne("ControlWeb.Models.Academico", "Academico")
                        .WithOne("Usuario")
                        .HasForeignKey("ControlWeb.Models.Usuario", "AcademicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.DatosPersonales", "DatosPersonales")
                        .WithMany()
                        .HasForeignKey("DatosPersonalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlWeb.Models.Estudiante", "Estudiante")
                        .WithOne("Usuario")
                        .HasForeignKey("ControlWeb.Models.Usuario", "EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
