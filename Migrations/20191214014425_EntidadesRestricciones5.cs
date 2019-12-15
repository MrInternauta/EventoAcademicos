using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class EntidadesRestricciones5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Facultad_FacultadId",
                table: "Academico");

            migrationBuilder.DropColumn(
                name: "IdFacultad",
                table: "Academico");

            migrationBuilder.AlterColumn<int>(
                name: "FacultadId",
                table: "Academico",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Academico_Facultad_FacultadId",
                table: "Academico",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academico_Facultad_FacultadId",
                table: "Academico");

            migrationBuilder.AlterColumn<int>(
                name: "FacultadId",
                table: "Academico",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdFacultad",
                table: "Academico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Academico_Facultad_FacultadId",
                table: "Academico",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
