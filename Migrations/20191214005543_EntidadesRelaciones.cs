using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class EntidadesRelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAcademia = table.Column<string>(maxLength: 50, nullable: false),
                    DescripcionAcademia = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDocumento = table.Column<string>(maxLength: 50, nullable: false),
                    DescripcionDocumento = table.Column<string>(maxLength: 100, nullable: true),
                    TipoDocumento = table.Column<string>(maxLength: 100, nullable: true),
                    FormatoDocumento = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEvento = table.Column<string>(maxLength: 50, nullable: false),
                    FechaEvento = table.Column<DateTime>(nullable: false),
                    DescripcionEvento = table.Column<string>(maxLength: 100, nullable: true),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facultad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 45, nullable: false),
                    Clave = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clave = table.Column<string>(maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SedeEvento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSedeEvento = table.Column<string>(maxLength: 45, nullable: false),
                    DescripcionSedeEvento = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SedeEvento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoOrganizador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 55, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOrganizador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evento_Documento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventoId = table.Column<int>(nullable: false),
                    DocumentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento_Documento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_Documento_Documento_DocumentoId",
                        column: x => x.DocumentoId,
                        principalTable: "Documento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_Documento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Academico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFacultad = table.Column<int>(nullable: false),
                    FacultadId = table.Column<int>(nullable: true),
                    NoControl = table.Column<string>(maxLength: 10, nullable: true),
                    Rfc = table.Column<string>(maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academico_Facultad_FacultadId",
                        column: x => x.FacultadId,
                        principalTable: "Facultad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFacultad = table.Column<int>(nullable: false),
                    FacultadId = table.Column<int>(nullable: true),
                    Matricula = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudiante_Facultad_FacultadId",
                        column: x => x.FacultadId,
                        principalTable: "Facultad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role_Permiso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    PermisoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_Permiso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Permiso_Permiso_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permiso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_Permiso_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evento_SedeEvento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventoId = table.Column<int>(maxLength: 55, nullable: false),
                    SedeEventoId = table.Column<int>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento_SedeEvento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_SedeEvento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_SedeEvento_SedeEvento_SedeEventoId",
                        column: x => x.SedeEventoId,
                        principalTable: "SedeEvento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Academico_Academia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicoId = table.Column<int>(nullable: false),
                    AcademiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academico_Academia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academico_Academia_Academia_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Academico_Academia_Academico_AcademicoId",
                        column: x => x.AcademicoId,
                        principalTable: "Academico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Academico_Evento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicoId = table.Column<int>(nullable: false),
                    EventoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academico_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academico_Evento_Academico_AcademicoId",
                        column: x => x.AcademicoId,
                        principalTable: "Academico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Academico_Evento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoOrganizador = table.Column<int>(nullable: false),
                    TipoOrganizadorId = table.Column<int>(nullable: true),
                    IdEvento = table.Column<int>(nullable: false),
                    EventoId = table.Column<int>(nullable: true),
                    AcademicoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizador_Academico_AcademicoId",
                        column: x => x.AcademicoId,
                        principalTable: "Academico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organizador_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizador_TipoOrganizador_TipoOrganizadorId",
                        column: x => x.TipoOrganizadorId,
                        principalTable: "TipoOrganizador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatosPersonalesId = table.Column<int>(nullable: false),
                    AcademicoId = table.Column<int>(nullable: false),
                    EstudianteId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 45, nullable: false),
                    Password = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Academico_AcademicoId",
                        column: x => x.AcademicoId,
                        principalTable: "Academico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Estudiante_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatosPersonales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 45, nullable: false),
                    ApellidoPaterno = table.Column<string>(maxLength: 45, nullable: false),
                    ApellidoMaterno = table.Column<string>(maxLength: 45, nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: false),
                    DeletedById = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Usuario_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Usuario_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Usuario_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role_Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Usuario_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_Usuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academico_FacultadId",
                table: "Academico",
                column: "FacultadId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Academia_AcademiaId",
                table: "Academico_Academia",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Academia_AcademicoId",
                table: "Academico_Academia",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Evento_AcademicoId",
                table: "Academico_Evento",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Evento_EventoId",
                table: "Academico_Evento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_CreatedById",
                table: "DatosPersonales",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_DeletedById",
                table: "DatosPersonales",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_UpdatedById",
                table: "DatosPersonales",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_FacultadId",
                table: "Estudiante",
                column: "FacultadId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Documento_DocumentoId",
                table: "Evento_Documento",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Documento_EventoId",
                table: "Evento_Documento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_SedeEvento_EventoId",
                table: "Evento_SedeEvento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_SedeEvento_SedeEventoId",
                table: "Evento_SedeEvento",
                column: "SedeEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_AcademicoId",
                table: "Organizador",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_EventoId",
                table: "Organizador",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_TipoOrganizadorId",
                table: "Organizador",
                column: "TipoOrganizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Permiso_PermisoId",
                table: "Role_Permiso",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Permiso_RoleId",
                table: "Role_Permiso",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Usuario_RoleId",
                table: "Role_Usuario",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Usuario_UsuarioId",
                table: "Role_Usuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DatosPersonalesId",
                table: "Usuario",
                column: "DatosPersonalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario",
                column: "EstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_DatosPersonales_DatosPersonalesId",
                table: "Usuario",
                column: "DatosPersonalesId",
                principalTable: "DatosPersonales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Facultad_FacultadId",
                table: "Academico");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Facultad_FacultadId",
                table: "Estudiante");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Academico_AcademicoId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_CreatedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales");

            migrationBuilder.DropTable(
                name: "Academico_Academia");

            migrationBuilder.DropTable(
                name: "Academico_Evento");

            migrationBuilder.DropTable(
                name: "Evento_Documento");

            migrationBuilder.DropTable(
                name: "Evento_SedeEvento");

            migrationBuilder.DropTable(
                name: "Organizador");

            migrationBuilder.DropTable(
                name: "Role_Permiso");

            migrationBuilder.DropTable(
                name: "Role_Usuario");

            migrationBuilder.DropTable(
                name: "Academia");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "SedeEvento");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "TipoOrganizador");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropTable(
                name: "Academico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "DatosPersonales");

            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
