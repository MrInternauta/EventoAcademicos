using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class manytoMany_Role_User_Permiso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizador_Academico_AcademicoIdAcademico",
                table: "Organizador");

            migrationBuilder.DropIndex(
                name: "IX_Organizador_AcademicoIdAcademico",
                table: "Organizador");

            migrationBuilder.DropColumn(
                name: "AcademicoIdAcademico",
                table: "Organizador");

            migrationBuilder.DropColumn(
                name: "IdAcademico",
                table: "Organizador");

            migrationBuilder.AddColumn<int>(
                name: "IdOrganizador",
                table: "Academico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizadorIdOrganizador",
                table: "Academico",
                nullable: true);

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
                        principalColumn: "IdPermiso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_Permiso_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_Usuario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academico_OrganizadorIdOrganizador",
                table: "Academico",
                column: "OrganizadorIdOrganizador");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Academico_Organizador_OrganizadorIdOrganizador",
                table: "Academico",
                column: "OrganizadorIdOrganizador",
                principalTable: "Organizador",
                principalColumn: "IdOrganizador",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Organizador_OrganizadorIdOrganizador",
                table: "Academico");

            migrationBuilder.DropTable(
                name: "Role_Permiso");

            migrationBuilder.DropTable(
                name: "Role_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Academico_OrganizadorIdOrganizador",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "IdOrganizador",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "OrganizadorIdOrganizador",
                table: "Academico");

            migrationBuilder.AddColumn<int>(
                name: "AcademicoIdAcademico",
                table: "Organizador",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAcademico",
                table: "Organizador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Organizador_AcademicoIdAcademico",
                table: "Organizador",
                column: "AcademicoIdAcademico");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizador_Academico_AcademicoIdAcademico",
                table: "Organizador",
                column: "AcademicoIdAcademico",
                principalTable: "Academico",
                principalColumn: "IdAcademico",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
