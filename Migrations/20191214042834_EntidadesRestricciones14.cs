using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class EntidadesRestricciones14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario",
                column: "AcademicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario",
                column: "EstudianteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario",
                column: "EstudianteId");
        }
    }
}
