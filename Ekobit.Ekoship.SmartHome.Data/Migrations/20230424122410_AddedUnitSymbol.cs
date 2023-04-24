using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ekobit.Ekoship.SmartHome.Data.Migrations
{
    public partial class AddedUnitSymbol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceTypes_TypeId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Devices",
                newName: "DeviceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_TypeId",
                table: "Devices",
                newName: "IX_Devices_DeviceTypeId");

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_HomeId",
                table: "Devices",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceTypes_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId",
                principalTable: "DeviceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Homes_HomeId",
                table: "Devices",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceTypes_DeviceTypeId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Homes_HomeId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_HomeId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "DeviceTypeId",
                table: "Devices",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                newName: "IX_Devices_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceTypes_TypeId",
                table: "Devices",
                column: "TypeId",
                principalTable: "DeviceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
