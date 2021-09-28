using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookstore.Migrations
{
    public partial class testAzure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "6bd48a35-5707-4e7c-9efc-ed4735d8ac72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "31de8c1e-46b6-44af-ba89-ff6d9791ea1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "20ca9571-9500-4de3-83af-14dbbb17e330");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPF+4c0CD7+123mi9SfCOPQuRlbgm9yjOp1NOoqSLLeS7nYZ6CEhzrydl65MzCLXuA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "fe7f2bfb-15b0-4668-912d-2040ba30cbc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "6c9d82f9-c1de-48e2-b5dc-a90471040a6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "8889fa9c-cbe1-4dd9-a67c-9e52d4b2afc2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEG2yx3v/2zaZnnwKidyWfItaq6tFF64zLxHGtg0j8/jyWcvFyI9L5rRsH5XTrWwJLA==");
        }
    }
}
