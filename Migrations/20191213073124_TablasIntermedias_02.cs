using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class TablasIntermedias_02 : Migration
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

            migrationBuilder.InsertData(
                table: "DatosPersonales",
                columns: new[] { "IdDatosPersonales", "ApellidoMaterno", "ApellidoPaterno", "Created", "CreatedById", "Deleted", "DeletedById", "DeletedId", "FechaDeNacimiento", "Nombre", "Updated", "UpdatedById" },
                values: new object[] { 1, "AdminMaterno", "AdminPaterno", new DateTime(2019, 12, 13, 1, 31, 24, 290, DateTimeKind.Local).AddTicks(9350), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(2019, 12, 13, 1, 31, 24, 293, DateTimeKind.Local).AddTicks(2897), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "AcademicoIdAcademico", "IdDatosPersonales", "Email", "EstudianteIdEstudiante", "IdAcademico", "IdEstudiante", "Password" },
                values: new object[] { 1, null, 1, "admin@admin", null, -1, -1, "admin" });

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

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DatosPersonales",
                keyColumn: "IdDatosPersonales",
                keyValue: 1);

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
        }
    }
}
