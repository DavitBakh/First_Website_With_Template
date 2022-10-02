using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebsite.Data.Data.Migrations
{
    public partial class changeDbSetNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_citys_CityId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_citys_countries_CountryId",
                table: "citys");

            migrationBuilder.DropForeignKey(
                name: "FK_estates_addresses_AddressId",
                table: "estates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_estates",
                table: "estates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_countries",
                table: "countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_citys",
                table: "citys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.RenameTable(
                name: "estates",
                newName: "Estates");

            migrationBuilder.RenameTable(
                name: "countries",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "citys",
                newName: "Citys");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_estates_AddressId",
                table: "Estates",
                newName: "IX_Estates_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_citys_CountryId",
                table: "Citys",
                newName: "IX_Citys_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_CityId",
                table: "Addresses",
                newName: "IX_Addresses_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estates",
                table: "Estates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citys",
                table: "Citys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citys_Countries_CountryId",
                table: "Citys",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Addresses_AddressId",
                table: "Estates",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Citys_Countries_CountryId",
                table: "Citys");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Addresses_AddressId",
                table: "Estates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estates",
                table: "Estates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citys",
                table: "Citys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Estates",
                newName: "estates");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "countries");

            migrationBuilder.RenameTable(
                name: "Citys",
                newName: "citys");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Estates_AddressId",
                table: "estates",
                newName: "IX_estates_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Citys_CountryId",
                table: "citys",
                newName: "IX_citys_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityId",
                table: "addresses",
                newName: "IX_addresses_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_estates",
                table: "estates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_countries",
                table: "countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_citys",
                table: "citys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_citys_CityId",
                table: "addresses",
                column: "CityId",
                principalTable: "citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_citys_countries_CountryId",
                table: "citys",
                column: "CountryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_estates_addresses_AddressId",
                table: "estates",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
