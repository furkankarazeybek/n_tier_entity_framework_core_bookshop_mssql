using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class KitapRelationBireBirveBireCok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentApi_Kitaplar_FluentApi_KitapDetaylar_KitapDetay_Id",
                table: "FluentApi_Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_FluentApi_Kitaplar_KitapDetay_Id",
                table: "FluentApi_Kitaplar");

            migrationBuilder.DropColumn(
                name: "KitapDetay_Id",
                table: "FluentApi_Kitaplar");

            migrationBuilder.AddColumn<int>(
                name: "YayinEviIdForeign",
                table: "FluentApi_Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_Kitaplar_KitapDetayIdForeign",
                table: "FluentApi_Kitaplar",
                column: "KitapDetayIdForeign",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_Kitaplar_YayinEviIdForeign",
                table: "FluentApi_Kitaplar",
                column: "YayinEviIdForeign");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentApi_Kitaplar_FluentApi_KitapDetaylar_KitapDetayIdForeign",
                table: "FluentApi_Kitaplar",
                column: "KitapDetayIdForeign",
                principalTable: "FluentApi_KitapDetaylar",
                principalColumn: "KitapDetay_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentApi_Kitaplar_FluentApi_YayınEvi_YayinEviIdForeign",
                table: "FluentApi_Kitaplar",
                column: "YayinEviIdForeign",
                principalTable: "FluentApi_YayınEvi",
                principalColumn: "YayinEvi_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentApi_Kitaplar_FluentApi_KitapDetaylar_KitapDetayIdForeign",
                table: "FluentApi_Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentApi_Kitaplar_FluentApi_YayınEvi_YayinEviIdForeign",
                table: "FluentApi_Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_FluentApi_Kitaplar_KitapDetayIdForeign",
                table: "FluentApi_Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_FluentApi_Kitaplar_YayinEviIdForeign",
                table: "FluentApi_Kitaplar");

            migrationBuilder.DropColumn(
                name: "YayinEviIdForeign",
                table: "FluentApi_Kitaplar");

            migrationBuilder.AddColumn<int>(
                name: "KitapDetay_Id",
                table: "FluentApi_Kitaplar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_Kitaplar_KitapDetay_Id",
                table: "FluentApi_Kitaplar",
                column: "KitapDetay_Id",
                unique: true,
                filter: "[KitapDetay_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentApi_Kitaplar_FluentApi_KitapDetaylar_KitapDetay_Id",
                table: "FluentApi_Kitaplar",
                column: "KitapDetay_Id",
                principalTable: "FluentApi_KitapDetaylar",
                principalColumn: "KitapDetay_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
