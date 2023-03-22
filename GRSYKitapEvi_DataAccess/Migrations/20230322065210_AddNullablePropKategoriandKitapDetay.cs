using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class AddNullablePropKategoriandKitapDetay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_KitapDetaylari_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.AlterColumn<int>(
                name: "KitapDetayIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign",
                unique: true,
                filter: "[KitapDetayIdForeign] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_KitapDetaylari_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign",
                principalTable: "KitapDetaylari",
                principalColumn: "KitapDetay_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "tbl_Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_KitapDetaylari_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap");

            migrationBuilder.AlterColumn<int>(
                name: "KitapDetayIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KategoriIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_KitapDetaylari_KitapDetayIdForeign",
                table: "tb_Kitap",
                column: "KitapDetayIdForeign",
                principalTable: "KitapDetaylari",
                principalColumn: "KitapDetay_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "tbl_Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
