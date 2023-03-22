using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class FluentApiModellemesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitaplarYazarlar_tb_Yazar_Yazar_Id",
                table: "KitaplarYazarlar");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_YayinEvi_YayınEviIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Yazar",
                table: "tb_Yazar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_YayinEvi",
                table: "tb_YayinEvi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Kategori",
                table: "tb_Kategori");

            migrationBuilder.RenameTable(
                name: "tb_Yazar",
                newName: "Yazarlar");

            migrationBuilder.RenameTable(
                name: "tb_YayinEvi",
                newName: "Yayinevleri");

            migrationBuilder.RenameTable(
                name: "tb_Kategori",
                newName: "Kategori");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar",
                column: "Yazar_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yayinevleri",
                table: "Yayinevleri",
                column: "YayinEvi_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "KategoriId");

            migrationBuilder.CreateTable(
                name: "FluentApi_Kitaplar",
                columns: table => new
                {
                    Kitap_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_Kitaplar", x => x.Kitap_Id);
                });

            migrationBuilder.CreateTable(
                name: "FluentApi_YayınEvi",
                columns: table => new
                {
                    YayinEvi_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayinEviAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_YayınEvi", x => x.YayinEvi_Id);
                });

            migrationBuilder.CreateTable(
                name: "FluentApi_Yazar",
                columns: table => new
                {
                    Yazar_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_Yazar", x => x.Yazar_Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_KitaplarYazarlar_Yazarlar_Yazar_Id",
                table: "KitaplarYazarlar",
                column: "Yazar_Id",
                principalTable: "Yazarlar",
                principalColumn: "Yazar_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_Yayinevleri_YayınEviIdForeign",
                table: "tb_Kitap",
                column: "YayınEviIdForeign",
                principalTable: "Yayinevleri",
                principalColumn: "YayinEvi_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitaplarYazarlar_Yazarlar_Yazar_Id",
                table: "KitaplarYazarlar");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_Kategori_KategoriIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_Yayinevleri_YayınEviIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropTable(
                name: "FluentApi_Kitaplar");

            migrationBuilder.DropTable(
                name: "FluentApi_YayınEvi");

            migrationBuilder.DropTable(
                name: "FluentApi_Yazar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yayinevleri",
                table: "Yayinevleri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.RenameTable(
                name: "Yazarlar",
                newName: "tb_Yazar");

            migrationBuilder.RenameTable(
                name: "Yayinevleri",
                newName: "tb_YayinEvi");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "tb_Kategori");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Yazar",
                table: "tb_Yazar",
                column: "Yazar_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_YayinEvi",
                table: "tb_YayinEvi",
                column: "YayinEvi_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Kategori",
                table: "tb_Kategori",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_KitaplarYazarlar_tb_Yazar_Yazar_Id",
                table: "KitaplarYazarlar",
                column: "Yazar_Id",
                principalTable: "tb_Yazar",
                principalColumn: "Yazar_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriIdForeign",
                table: "tb_Kitap",
                column: "KategoriIdForeign",
                principalTable: "tb_Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_YayinEvi_YayınEviIdForeign",
                table: "tb_Kitap",
                column: "YayınEviIdForeign",
                principalTable: "tb_YayinEvi",
                principalColumn: "YayinEvi_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
