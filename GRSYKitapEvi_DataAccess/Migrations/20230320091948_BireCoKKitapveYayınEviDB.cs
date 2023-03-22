using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class BireCoKKitapveYayınEviDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YayınEviIdForeign",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_YayınEviIdForeign",
                table: "tb_Kitap",
                column: "YayınEviIdForeign");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_YayinEvi_YayınEviIdForeign",
                table: "tb_Kitap",
                column: "YayınEviIdForeign",
                principalTable: "tb_YayinEvi",
                principalColumn: "YayinEvi_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_YayinEvi_YayınEviIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_YayınEviIdForeign",
                table: "tb_Kitap");

            migrationBuilder.DropColumn(
                name: "YayınEviIdForeign",
                table: "tb_Kitap");
        }
    }
}
