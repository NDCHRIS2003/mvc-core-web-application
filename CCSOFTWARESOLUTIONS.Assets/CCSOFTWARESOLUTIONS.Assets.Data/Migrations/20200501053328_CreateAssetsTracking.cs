using Microsoft.EntityFrameworkCore.Migrations;

namespace CCSOFTWARESOLUTIONS.Assets.Data.Migrations
{
    public partial class CreateAssetsTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNumber = table.Column<string>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Monitor" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phone" });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetTypeId", "Description", "Manufacturer", "Model", "SerialNumber", "TagNumber" },
                values: new object[,]
                {
                    { 1, 1, "Inspiron", "Dell", "CO61-410US", "NXP-157-I", "1A1" },
                    { 2, 1, "Hnspiron", "HP", "BO61-410US", "HXP-157-I", "2A1" },
                    { 3, 1, "Anspiron", "Acer", "AO61-410US", "AXP-157-I", "3A1" },
                    { 4, 2, "AMnspiron", "Acer", "AMO61-410US", "AMXP-157-I", "4MA1" },
                    { 5, 2, "LMnspiron", "LG", "LMO61-410US", "LMXP-157-I", "3MA1" },
                    { 6, 2, "HMnspiron", "HP", "HMO61-410US", "HMXP-157-I", "3HA1" },
                    { 7, 3, "APnspiron", "Avaya", "APO61-410US", "APXP-157-I", "3PA1" },
                    { 8, 3, "CPnspiron", "Cisco", "CPO61-410US", "CPXP-157-I", "3CA1" },
                    { 9, 3, "PPnspiron", "Polycom", "PPO61-410US", "PPXP-157-I", "3PPA1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetType");
        }
    }
}
