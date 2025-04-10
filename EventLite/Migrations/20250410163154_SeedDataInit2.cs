using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventLite.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartDateTime" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "RSVPs",
                keyColumn: "RSVPId",
                keyValue: 1,
                column: "RSVPDate",
                value: new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 15, 37, 57, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 5, 11, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(3577), new DateTime(2025, 5, 10, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartDateTime" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 4, 20, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "RSVPs",
                keyColumn: "RSVPId",
                keyValue: 1,
                column: "RSVPDate",
                value: new DateTime(2025, 4, 10, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 15, 32, 52, 621, DateTimeKind.Utc).AddTicks(2485));
        }
    }
}
