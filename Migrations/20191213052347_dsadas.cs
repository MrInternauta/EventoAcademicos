using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class dsadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedById",
                table: "DatosPersonales",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedById",
                table: "DatosPersonales",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "DatosPersonales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedId",
                table: "DatosPersonales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_CreatedById",
                table: "DatosPersonales",
                column: "CreatedById");

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

            migrationBuilder.DropIndex(
                name: "IX_DatosPersonales_CreatedById",
                table: "DatosPersonales");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "DatosPersonales");

            migrationBuilder.DropColumn(
                name: "DeletedId",
                table: "DatosPersonales");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedById",
                table: "DatosPersonales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedById",
                table: "DatosPersonales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
