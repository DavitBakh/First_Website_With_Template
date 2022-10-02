using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebsite.Data.Data.Migrations
{
    public partial class changeAddresAndCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Citys_CityId",
                table: "Estates");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Citys_CityId",
                table: "Estates",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Citys_CityId",
                table: "Estates");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Citys_CityId",
                table: "Estates",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id");
        }
    }
}
