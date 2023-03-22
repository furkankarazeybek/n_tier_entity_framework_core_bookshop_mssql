using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class BirebirİliskiKitapveKitapDetayDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitapDetayIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "KitapDetaylari",
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
                    table.PrimaryKey("PK_KitapDetaylari", x => x.KitapDetay_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_KitapDetaylari_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign",
                principalTable: "KitapDetaylari",
                principalColumn: "KitapDetay_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_KitapDetaylari_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropTable(
                name: "KitapDetaylari");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropColumn(
                name: "KitapDetayIdForeign",
                table: "tb_Kitap");
        }
    }
}
