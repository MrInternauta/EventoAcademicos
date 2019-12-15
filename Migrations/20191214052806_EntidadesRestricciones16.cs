using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class EntidadesRestricciones16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_CreatedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Academico_AcademicoId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteId",
                table: "Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_CreatedById",
                table: "DatosPersonales",
                column: "CreatedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales",
                column: "DeletedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales",
                column: "UpdatedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Academico_AcademicoId",
                table: "Usuario",
                column: "AcademicoId",
                principalTable: "Academico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteId",
                table: "Usuario",
                column: "EstudianteId",
                principalTable: "Estudiante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_CreatedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Academico_AcademicoId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteId",
                table: "Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_CreatedById",
                table: "DatosPersonales",
                column: "CreatedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales",
                column: "DeletedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales",
                column: "UpdatedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Academico_AcademicoId",
                table: "Usuario",
                column: "AcademicoId",
                principalTable: "Academico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteId",
                table: "Usuario",
                column: "EstudianteId",
                principalTable: "Estudiante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
