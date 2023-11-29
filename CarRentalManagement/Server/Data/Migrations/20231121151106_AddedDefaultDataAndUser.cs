using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "24818f36-88c2-4959-98a3-b37c11c4aa4e", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEERHT1mVDIxoIRXZ3RF4m6ust1eJ1KFIo3tVd2+VH6CGTDfuPg1O0TOM03X8s0FRRA==", null, false, "8f01513d-3fa1-48ef-92f4-0af9734f4bbb", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3493), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3496), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3496), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3764), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3765), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3766), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3766), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3913), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3913), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3914), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3915), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3916), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3917), new DateTime(2023, 11, 21, 23, 11, 6, 183, DateTimeKind.Local).AddTicks(3917), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
