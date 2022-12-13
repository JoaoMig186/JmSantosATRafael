using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JmSantosAT_Final_Rafael.Migrations
{
    public partial class ComPais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoPais");

            migrationBuilder.RenameColumn(
                name: "EstadosSelect",
                table: "Estado",
                newName: "PaisId");

            migrationBuilder.AddColumn<int>(
                name: "EstadosId",
                table: "Pais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_PaisId",
                table: "Estado",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Pais_PaisId",
                table: "Estado",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "PaisId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_PaisId",
                table: "Estado");

            migrationBuilder.DropIndex(
                name: "IX_Estado_PaisId",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "EstadosId",
                table: "Pais");

            migrationBuilder.RenameColumn(
                name: "PaisId",
                table: "Estado",
                newName: "EstadosSelect");

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
    }
}
