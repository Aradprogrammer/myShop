using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_store_bugeto.Persistence.Migrations
{
    public partial class seedsenderemailtestdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SenderEmails",
                columns: new[] { "Id", "AddressEmail", "InsertTime", "IsRemoved", "Password", "Removetime", "UpDateTime" },
                values: new object[] { 1L, "test@email.com", new DateTime(2022, 2, 22, 8, 54, 42, 145, DateTimeKind.Local).AddTicks(2439), false, "1111", null, null });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "SenderEmailId", "Text" },
                values: new object[] { 1L, "<a href= $Link >بازیابی گذرواژه</a>" });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "SenderEmailId", "Text" },
                values: new object[] { 1L, "<a href= $Link >تایید ایمیل</a>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "SenderEmailId", "Text" },
                values: new object[] { null, "<a href= $link >بازیابی گذرواژه</a>" });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "SenderEmailId", "Text" },
                values: new object[] { null, "<a href= $link >تایید ایمیل</a>" });
        }
    }
}
