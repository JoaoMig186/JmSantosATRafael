using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JmSantosAT_Final_Rafael.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigo",
                columns: table => new
                {
                    AmigoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmigoNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmigoSobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmigoTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmigoEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AniversarioAmigo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaisAmigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoAmigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagemAmigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmigoId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigo", x => x.AmigoId);
                    table.ForeignKey(
                        name: "FK_Amigo_Amigo_AmigoId1",
                        column: x => x.AmigoId1,
                        principalTable: "Amigo",
                        principalColumn: "AmigoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amigo_AmigoId1",
                table: "Amigo",
                column: "AmigoId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigo");
        }
    }
}
