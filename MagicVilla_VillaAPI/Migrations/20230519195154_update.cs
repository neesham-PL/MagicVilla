using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 1001, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4693), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4694), 1 },
                    { 102, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4696), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4697), 1 },
                    { 103, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4698), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4698), 1 },
                    { 201, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4699), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4700), 2 },
                    { 202, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4701), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4702), 2 },
                    { 301, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4703), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4704), 3 },
                    { 401, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4705), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4706), 4 },
                    { 501, new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4708), "this is a dummy text.", new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4708), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 20, 1, 21, 54, 733, DateTimeKind.Local).AddTicks(4525));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 501);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 12, 50, 5, 43, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 12, 50, 5, 43, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 12, 50, 5, 43, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 12, 50, 5, 43, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 12, 50, 5, 43, DateTimeKind.Local).AddTicks(6517));
        }
    }
}
