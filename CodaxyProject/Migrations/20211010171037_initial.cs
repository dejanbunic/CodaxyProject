using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodaxyProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedBy", "Status", "TimeCreated", "TimeUpdated" },
                values: new object[] { 1, "Dejan Bunic", 0, new DateTime(2021, 10, 10, 19, 10, 36, 858, DateTimeKind.Local).AddTicks(5096), new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedBy", "Status", "TimeCreated", "TimeUpdated" },
                values: new object[] { 2, "Pero Peric", 2, new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3551), new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedBy", "Status", "TimeCreated", "TimeUpdated" },
                values: new object[] { 3, "Pero Budak", 1, new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3591), new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "CartId", "CreatedBy", "Description", "Name", "TimeCreated", "TimeUpdated" },
                values: new object[,]
                {
                    { 1, 1, "Dejan Bunic", "hibridni kukuruz", "kukuruz", new DateTime(2021, 10, 10, 19, 10, 36, 862, DateTimeKind.Local).AddTicks(9192), new DateTime(2021, 10, 10, 19, 10, 36, 862, DateTimeKind.Local).AddTicks(9532) },
                    { 2, 1, "Dejan Bunic", "crveni", "krompir", new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(148), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(178) },
                    { 3, 2, "Pero Peric", "crveni", "krompir", new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(195), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(199) },
                    { 4, 2, "Pero Peric", "ljuta paprika", "cips", new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(203), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(207) },
                    { 5, 3, "Pero Budak", "slane przene", "sjemenke bundeve", new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(211), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(214) },
                    { 6, 3, "Pero Budak", "zaledjeni fileti", "oslic", new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(218), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(221) },
                    { 7, 3, "Pero Budak", "sa ljesnjakom", "cokolada", new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(225), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(228) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
