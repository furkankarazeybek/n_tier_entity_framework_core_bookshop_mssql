using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class RemoveNullableKategoriColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "tbl_Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tbl_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "tbl_Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
