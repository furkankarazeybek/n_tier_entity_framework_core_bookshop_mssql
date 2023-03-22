using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class EkleCokaCokFluentKitapYazarDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentApi_KitapYazar",
                columns: table => new
                {
                    Kitap_Id = table.Column<int>(type: "int", nullable: false),
                    Yazar_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_KitapYazar", x => new { x.Yazar_Id, x.Kitap_Id });
                    table.ForeignKey(
                        name: "FK_FluentApi_KitapYazar_FluentApi_Kitaplar_Kitap_Id",
                        column: x => x.Kitap_Id,
                        principalTable: "FluentApi_Kitaplar",
                        principalColumn: "Kitap_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentApi_KitapYazar_FluentApi_Yazar_Yazar_Id",
                        column: x => x.Yazar_Id,
                        principalTable: "FluentApi_Yazar",
                        principalColumn: "Yazar_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_KitapYazar_Kitap_Id",
                table: "FluentApi_KitapYazar",
                column: "Kitap_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApi_KitapYazar");
        }
    }
}
