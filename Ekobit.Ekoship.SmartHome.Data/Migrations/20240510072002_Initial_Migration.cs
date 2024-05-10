using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ekobit.Ekoship.SmartHome.Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homes_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "Number", "StreetName", "ZipCode" },
                values: new object[] { 1, "Varazdin", "HR", 2, "Pavlinska", 42000 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "Number", "StreetName", "ZipCode" },
                values: new object[] { 2, "Varazdin", "HR", 5, "Zagrebacka", 42000 });

            migrationBuilder.InsertData(
                table: "Homes",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[] { 1, 1, "Dvorana 6" });

            migrationBuilder.InsertData(
                table: "Homes",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[] { 2, 1, "Dvorana 7" });

            migrationBuilder.CreateIndex(
                name: "IX_Homes_AddressId",
                table: "Homes",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
