using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class algo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Usuario_UsuarioId",
                table: "Academico");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Usuario_UsuarioId",
                table: "Estudiante");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_Usuario_UsuarioIdUsuario",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_UsuarioIdUsuario",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_UsuarioId",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_Academico_UsuarioId",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdRole",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "clave",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Academico");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Role",
                newName: "Nombre");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Usuario",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AcademicoIdAcademico",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDatosPersonales",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuario",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstudianteIdEstudiante",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAcademico",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEstudiante",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuario",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Role",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRol",
                table: "Role",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Role",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacultadIdFacultad",
                table: "Estudiante",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacultad",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Estudiante",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FacultadIdFacultad",
                table: "Academico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacultad",
                table: "Academico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NoControl",
                table: "Academico",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rfc",
                table: "Academico",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "IdRol");

            migrationBuilder.CreateTable(
                name: "Academia",
                columns: table => new
                {
                    IdAcademia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAcademia = table.Column<string>(maxLength: 15, nullable: false),
                    DescripcionAcademia = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academia", x => x.IdAcademia);
                });

            migrationBuilder.CreateTable(
                name: "DatosPersonales",
                columns: table => new
                {
                    IdDatosPersonales = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 45, nullable: false),
                    ApellidoPaterno = table.Column<string>(maxLength: 45, nullable: false),
                    ApellidoMaterno = table.Column<string>(maxLength: 45, nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonales", x => x.IdDatosPersonales);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    IdDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDocumento = table.Column<string>(maxLength: 50, nullable: false),
                    DescripcionDocumento = table.Column<string>(maxLength: 100, nullable: false),
                    TipoDocumento = table.Column<string>(maxLength: 50, nullable: false),
                    FormatoDocumento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.IdDocumento);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEvento = table.Column<string>(maxLength: 15, nullable: false),
                    FechaEvento = table.Column<DateTime>(nullable: false),
                    DescripcionEvento = table.Column<string>(maxLength: 45, nullable: true),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    HoraInicio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                });

            migrationBuilder.CreateTable(
                name: "Facultad",
                columns: table => new
                {
                    IdFacultad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 45, nullable: false),
                    Clave = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.IdFacultad);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clave = table.Column<string>(maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.IdPermiso);
                });

            migrationBuilder.CreateTable(
                name: "SedeEvento",
                columns: table => new
                {
                    IdSedeEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSedeEvento = table.Column<string>(maxLength: 50, nullable: false),
                    DescripcionSedeEvento = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SedeEvento", x => x.IdSedeEvento);
                });

            migrationBuilder.CreateTable(
                name: "TipoOrganizador",
                columns: table => new
                {
                    IdTipoOrganizador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOrganizador", x => x.IdTipoOrganizador);
                });

            migrationBuilder.CreateTable(
                name: "Organizador",
                columns: table => new
                {
                    IdOrganizador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoOrganizador = table.Column<int>(nullable: false),
                    TipoOrganizadorIdTipoOrganizador = table.Column<int>(nullable: true),
                    IdEvento = table.Column<int>(nullable: false),
                    EventoIdEvento = table.Column<int>(nullable: true),
                    IdAcademico = table.Column<int>(nullable: false),
                    AcademicoIdAcademico = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizador", x => x.IdOrganizador);
                    table.ForeignKey(
                        name: "FK_Organizador_Academico_AcademicoIdAcademico",
                        column: x => x.AcademicoIdAcademico,
                        principalTable: "Academico",
                        principalColumn: "IdAcademico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizador_Evento_EventoIdEvento",
                        column: x => x.EventoIdEvento,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizador_TipoOrganizador_TipoOrganizadorIdTipoOrganizador",
                        column: x => x.TipoOrganizadorIdTipoOrganizador,
                        principalTable: "TipoOrganizador",
                        principalColumn: "IdTipoOrganizador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcademicoIdAcademico",
                table: "Usuario",
                column: "AcademicoIdAcademico");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdDatosPersonales",
                table: "Usuario",
                column: "IdDatosPersonales");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstudianteIdEstudiante",
                table: "Usuario",
                column: "EstudianteIdEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_FacultadIdFacultad",
                table: "Estudiante",
                column: "FacultadIdFacultad");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_FacultadIdFacultad",
                table: "Academico",
                column: "FacultadIdFacultad");

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_AcademicoIdAcademico",
                table: "Organizador",
                column: "AcademicoIdAcademico");

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_EventoIdEvento",
                table: "Organizador",
                column: "EventoIdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_TipoOrganizadorIdTipoOrganizador",
                table: "Organizador",
                column: "TipoOrganizadorIdTipoOrganizador");

            migrationBuilder.AddForeignKey(
                name: "FK_Academico_Facultad_FacultadIdFacultad",
                table: "Academico",
                column: "FacultadIdFacultad",
                principalTable: "Facultad",
                principalColumn: "IdFacultad",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Facultad_FacultadIdFacultad",
                table: "Estudiante",
                column: "FacultadIdFacultad",
                principalTable: "Facultad",
                principalColumn: "IdFacultad",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Academico_AcademicoIdAcademico",
                table: "Usuario",
                column: "AcademicoIdAcademico",
                principalTable: "Academico",
                principalColumn: "IdAcademico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_DatosPersonales_IdDatosPersonales",
                table: "Usuario",
                column: "IdDatosPersonales",
                principalTable: "DatosPersonales",
                principalColumn: "IdDatosPersonales",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteIdEstudiante",
                table: "Usuario",
                column: "EstudianteIdEstudiante",
                principalTable: "Estudiante",
                principalColumn: "IdEstudiante",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Facultad_FacultadIdFacultad",
                table: "Academico");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Facultad_FacultadIdFacultad",
                table: "Estudiante");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Academico_AcademicoIdAcademico",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_DatosPersonales_IdDatosPersonales",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteIdEstudiante",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Academia");

            migrationBuilder.DropTable(
                name: "DatosPersonales");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropTable(
                name: "Organizador");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "SedeEvento");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "TipoOrganizador");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_AcademicoIdAcademico",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_IdDatosPersonales",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_EstudianteIdEstudiante",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_FacultadIdFacultad",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_Academico_FacultadIdFacultad",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "AcademicoIdAcademico",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdDatosPersonales",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "EstudianteIdEstudiante",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdAcademico",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdEstudiante",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "FacultadIdFacultad",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "IdFacultad",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "FacultadIdFacultad",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "IdFacultad",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "NoControl",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "Rfc",
                table: "Academico");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Role",
                newName: "nombre");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "IdRole",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "clave",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Estudiante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Academico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UsuarioIdUsuario",
                table: "Role",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_UsuarioId",
                table: "Estudiante",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_UsuarioId",
                table: "Academico",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Academico_Usuario_UsuarioId",
                table: "Academico",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Usuario_UsuarioId",
                table: "Estudiante",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Usuario_UsuarioIdUsuario",
                table: "Role",
                column: "UsuarioIdUsuario",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
