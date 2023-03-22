using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class EkleCokaCokKitapYazarDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KitaplarYazarlar",
                columns: table => new
                {
                    Kitap_Id = table.Column<int>(type: "int", nullable: false),
                    Yazar_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitaplarYazarlar", x => new { x.Yazar_Id, x.Kitap_Id });
                    table.ForeignKey(
                        name: "FK_KitaplarYazarlar_tb_Kitap_Kitap_Id",
                        column: x => x.Kitap_Id,
                        principalTable: "tb_Kitap",
                        principalColumn: "Kitap_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitaplarYazarlar_tb_Yazar_Yazar_Id",
                        column: x => x.Yazar_Id,
                        principalTable: "tb_Yazar",
                        principalColumn: "Yazar_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KitaplarYazarlar_Kitap_Id",
                table: "KitaplarYazarlar",
                column: "Kitap_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitaplarYazarlar");
        }
    }
}
