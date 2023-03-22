using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class FluentApiKategoriTableName_ColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "tbl_Kategori");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "tbl_Kategori",
                newName: "KategoriAdi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Kategori",
                table: "tbl_Kategori",
                column: "KategoriId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Kategori",
                table: "tbl_Kategori");

            migrationBuilder.RenameTable(
                name: "tbl_Kategori",
                newName: "Kategori");

            migrationBuilder.RenameColumn(
                name: "KategoriAdi",
                table: "Kategori",
                newName: "Ad");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
