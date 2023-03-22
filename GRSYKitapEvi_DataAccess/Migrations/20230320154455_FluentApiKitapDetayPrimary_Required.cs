using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class FluentApiKitapDetayPrimary_Required : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.CreateTable(
                name: "FluentApi_KitapDetaylar",
                columns: table => new
                {
                    KitapDetay_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumSayisi = table.Column<int>(type: "int", nullable: false),
                    KitapSayfasi = table.Column<int>(type: "int", nullable: false),
                    Agirlik = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_KitapDetaylar", x => x.KitapDetay_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApi_KitapDetaylar");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign");
        }
    }
}
