using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_store_bugeto.Persistence.Migrations
{
    public partial class AddRequestPay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestPays",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    isPay = table.Column<bool>(type: "bit", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Authority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Removetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestPays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestPays_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 504, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 505, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 505, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 505, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 505, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 505, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 31, 10, 34, 27, 505, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.CreateIndex(
                name: "IX_RequestPays_UserID",
                table: "RequestPays",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestPays");

            migrationBuilder.UpdateData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 53, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 53, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 54, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 54, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "SlidersCategory",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 54, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 53, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 26, 2, 54, 49, 53, DateTimeKind.Local).AddTicks(9153));
        }
    }
}
