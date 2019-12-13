using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWeb.Migrations
{
    public partial class TablasIntermedias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academico_Academia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicoId = table.Column<int>(nullable: false),
                    AcademiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academico_Academia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academico_Academia_Academia_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academia",
                        principalColumn: "IdAcademia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Academico_Academia_Academico_AcademicoId",
                        column: x => x.AcademicoId,
                        principalTable: "Academico",
                        principalColumn: "IdAcademico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Academico_Evento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicoId = table.Column<int>(nullable: false),
                    EventoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academico_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academico_Evento_Academico_AcademicoId",
                        column: x => x.AcademicoId,
                        principalTable: "Academico",
                        principalColumn: "IdAcademico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Academico_Evento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evento_Documento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventoId = table.Column<int>(nullable: false),
                    DocumentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento_Documento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_Documento_Documento_DocumentoId",
                        column: x => x.DocumentoId,
                        principalTable: "Documento",
                        principalColumn: "IdDocumento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_Documento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evento_SedeEvento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventoId = table.Column<int>(nullable: false),
                    SedeEventoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento_SedeEvento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_SedeEvento_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_SedeEvento_SedeEvento_SedeEventoId",
                        column: x => x.SedeEventoId,
                        principalTable: "SedeEvento",
                        principalColumn: "IdSedeEvento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Academia_AcademiaId",
                table: "Academico_Academia",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Academia_AcademicoId",
                table: "Academico_Academia",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Evento_AcademicoId",
                table: "Academico_Evento",
                column: "AcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Academico_Evento_EventoId",
                table: "Academico_Evento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Documento_DocumentoId",
                table: "Evento_Documento",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Documento_EventoId",
                table: "Evento_Documento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_SedeEvento_EventoId",
                table: "Evento_SedeEvento",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_SedeEvento_SedeEventoId",
                table: "Evento_SedeEvento",
                column: "SedeEventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academico_Academia");

            migrationBuilder.DropTable(
                name: "Academico_Evento");

            migrationBuilder.DropTable(
                name: "Evento_Documento");

            migrationBuilder.DropTable(
                name: "Evento_SedeEvento");
        }
    }
}
