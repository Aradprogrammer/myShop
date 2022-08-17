using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_store_bugeto.Persistence.Migrations
{
    public partial class AddHomePageImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PicsAndLinks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Src = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Removetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicsAndLinks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 3, 16, 31, 50, 545, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 3, 16, 31, 50, 545, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.InsertData(
                table: "Temps",
                columns: new[] { "Id", "Description", "InsertTime", "IsRemoved", "Key", "Removetime", "UpDateTime", "Value" },
                values: new object[] { 2L, null, new DateTime(2022, 7, 3, 16, 31, 50, 545, DateTimeKind.Local).AddTicks(9674), false, "Img_Path_HomePage", null, null, "Images/HomePageImage/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PicsAndLinks");

            migrationBuilder.DeleteData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 6, 29, 12, 21, 4, 442, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 6, 29, 12, 21, 4, 442, DateTimeKind.Local).AddTicks(4890));
        }
    }
}
