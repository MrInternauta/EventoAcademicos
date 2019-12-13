using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class datosper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "DatosPersonales",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "DatosPersonales",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_DeletedById",
                table: "DatosPersonales",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_UpdatedById",
                table: "DatosPersonales",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales",
                column: "DeletedById",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DatosPersonales_Usuario_IdDatosPersonales",
                table: "DatosPersonales",
                column: "IdDatosPersonales",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_DatosPersonales_Usuario_DeletedById",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_IdDatosPersonales",
                table: "DatosPersonales");

            migrationBuilder.DropForeignKey(
                name: "FK_DatosPersonales_Usuario_UpdatedById",
                table: "DatosPersonales");

            migrationBuilder.DropIndex(
                name: "IX_DatosPersonales_DeletedById",
                table: "DatosPersonales");

            migrationBuilder.DropIndex(
                name: "IX_DatosPersonales_UpdatedById",
                table: "DatosPersonales");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "DatosPersonales");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "DatosPersonales");
        }
    }
}
