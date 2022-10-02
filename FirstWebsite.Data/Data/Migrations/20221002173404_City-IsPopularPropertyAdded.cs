using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebsite.Data.Data.Migrations
{
    public partial class CityIsPopularPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isPopular",
                table: "Citys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Estates_CityId",
                table: "Estates",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Citys_CityId",
                table: "Estates",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Citys_CityId",
                table: "Estates");

            migrationBuilder.DropIndex(
                name: "IX_Estates_CityId",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "isPopular",
                table: "Citys");
        }
    }
}
