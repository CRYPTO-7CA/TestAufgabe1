using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AddDevicesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    _id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deviceTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    failsafe = table.Column<bool>(type: "bit", nullable: false),
                    tempMin = table.Column<int>(type: "int", nullable: false),
                    tempMax = table.Column<int>(type: "int", nullable: false),
                    installationPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insertInto19InchCabinet = table.Column<bool>(type: "bit", nullable: false),
                    motionEnable = table.Column<bool>(type: "bit", nullable: false),
                    siplusCatalog = table.Column<bool>(type: "bit", nullable: false),
                    simaticCatalog = table.Column<bool>(type: "bit", nullable: false),
                    rotationAxisNumber = table.Column<int>(type: "int", nullable: false),
                    positionAxisNumber = table.Column<int>(type: "int", nullable: false),
                    terminalElement = table.Column<bool>(type: "bit", nullable: true),
                    advancedEnvironmentConditions = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x._id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");
        }
    }
}
