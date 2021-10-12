using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodaxyProject.Migrations
{
    public partial class obelix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 810, DateTimeKind.Local).AddTicks(9825), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1020), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1075), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1083), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1147), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1156), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1163), new DateTime(2021, 10, 11, 18, 31, 56, 811, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 806, DateTimeKind.Local).AddTicks(4655), new DateTime(2021, 10, 11, 18, 31, 56, 809, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 809, DateTimeKind.Local).AddTicks(6861), new DateTime(2021, 10, 11, 18, 31, 56, 809, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 31, 56, 809, DateTimeKind.Local).AddTicks(6901), new DateTime(2021, 10, 11, 18, 31, 56, 809, DateTimeKind.Local).AddTicks(6905) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 862, DateTimeKind.Local).AddTicks(9192), new DateTime(2021, 10, 10, 19, 10, 36, 862, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(148), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(195), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(203), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(211), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(218), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(225), new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 858, DateTimeKind.Local).AddTicks(5096), new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3551), new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3591), new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3595) });
        }
    }
}
