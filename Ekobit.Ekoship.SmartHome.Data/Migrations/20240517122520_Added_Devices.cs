using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ekobit.Ekoship.SmartHome.Data.Migrations
{
    public partial class Added_Devices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Homes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homes_DeviceId",
                table: "Homes",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Devices_DeviceId",
                table: "Homes",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Devices_DeviceId",
                table: "Homes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Homes_DeviceId",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Homes");
        }
    }
}
