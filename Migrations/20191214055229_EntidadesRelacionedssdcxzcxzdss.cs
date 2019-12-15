using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class EntidadesRelacionedssdcxzcxzdss : Migration
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
                name: "FK_Usuario_DatosPersonales_DatosPersonalesId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_DatosPersonalesId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "AcademicoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DatosPersonalesId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "EstudianteId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "DatosPersonales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Academico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[] { 1, "admin@admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_UsuarioId",
                table: "Estudiante",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_UsuarioId",
                table: "DatosPersonales",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Academico_UsuarioId",
                table: "Academico",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Academico_Usuario_UsuarioId",
                table: "Academico",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_CreatedById",
                table: "DatosPersonales",
                column: "CreatedById",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales",
                column: "DeletedById",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales",
                column: "UpdatedById",
                principalTable: "Usuario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_UsuarioId",
                table: "DatosPersonales",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Usuario_UsuarioId",
                table: "Estudiante",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Usuario_UsuarioId",
                table: "Academico");

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
                name: "FK_DatosPersonales_Usuario_UsuarioId",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Usuario_UsuarioId",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_UsuarioId",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_DatosPersonales_UsuarioId",
                table: "DatosPersonales");

            migrationBuilder.DropIndex(
                name: "IX_Academico_UsuarioId",
                table: "Academico");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "DatosPersonales");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Academico");

            migrationBuilder.AddColumn<int>(
                name: "AcademicoId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DatosPersonalesId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstudianteId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcademicoId",
                table: "Usuario",
                column: "AcademicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DatosPersonalesId",
                table: "Usuario",
                column: "DatosPersonalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstudianteId",
                table: "Usuario",
                column: "EstudianteId",
                unique: true);

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
                name: "FK_Usuario_DatosPersonales_DatosPersonalesId",
                table: "Usuario",
                column: "DatosPersonalesId",
                principalTable: "DatosPersonales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Estudiante_EstudianteId",
                table: "Usuario",
                column: "EstudianteId",
                principalTable: "Estudiante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
