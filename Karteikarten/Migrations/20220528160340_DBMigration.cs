using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Karteikarten.Migrations
{
    public partial class DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "thema",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    themaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thema", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "karte",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    qText = table.Column<string>(nullable: true),
                    qImg = table.Column<byte[]>(nullable: true),
                    aText = table.Column<string>(nullable: true),
                    aImg = table.Column<byte[]>(nullable: true),
                    themaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_karte", x => x.id);
                    table.ForeignKey(
                        name: "FK_karte_thema_themaid",
                        column: x => x.themaid,
                        principalTable: "thema",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_karte_themaid",
                table: "karte",
                column: "themaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "karte");

            migrationBuilder.DropTable(
                name: "thema");
        }
    }
}
