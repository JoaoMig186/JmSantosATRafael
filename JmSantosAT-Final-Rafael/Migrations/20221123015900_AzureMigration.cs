using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JmSantosAT_Final_Rafael.Migrations
{
    public partial class AzureMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoPais",
                columns: table => new
                {
                    EstadosListaEstadosId = table.Column<int>(type: "int", nullable: false),
                    PaisesListaPaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPais", x => new { x.EstadosListaEstadosId, x.PaisesListaPaisId });
                    table.ForeignKey(
                        name: "FK_EstadoPais_Estado_EstadosListaEstadosId",
                        column: x => x.EstadosListaEstadosId,
                        principalTable: "Estado",
                        principalColumn: "EstadosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstadoPais_Pais_PaisesListaPaisId",
                        column: x => x.PaisesListaPaisId,
                        principalTable: "Pais",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstadoPais_PaisesListaPaisId",
                table: "EstadoPais",
                column: "PaisesListaPaisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoPais");
        }
    }
}
