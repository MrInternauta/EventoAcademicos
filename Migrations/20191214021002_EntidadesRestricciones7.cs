using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class EntidadesRestricciones7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Facultad_FacultadId",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "IdFacultad",
                table: "Estudiante");

            migrationBuilder.AlterColumn<int>(
                name: "FacultadId",
                table: "Estudiante",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Facultad_FacultadId",
                table: "Estudiante",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Facultad_FacultadId",
                table: "Estudiante");

            migrationBuilder.AlterColumn<int>(
                name: "FacultadId",
                table: "Estudiante",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdFacultad",
                table: "Estudiante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Facultad_FacultadId",
                table: "Estudiante",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
