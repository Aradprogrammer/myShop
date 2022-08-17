using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_store_bugeto.Persistence.Migrations
{
    public partial class AddHomePageSliders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SlidersCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    CategorySliderLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountItem = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Removetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlidersCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlidersCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 6, 11, 58, 37, 339, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.InsertData(
                table: "SlidersCategory",
                columns: new[] { "Id", "CategoryId", "CategorySliderLocation", "CountItem", "InsertTime", "IsRemoved", "Removetime", "UpDateTime" },
                values: new object[,]
                {
                    { 1L, null, "Slider1", 6, new DateTime(2022, 7, 6, 11, 58, 37, 340, DateTimeKind.Local).AddTicks(3626), false, null, null },
                    { 2L, null, "Slider2", 6, new DateTime(2022, 7, 6, 11, 58, 37, 340, DateTimeKind.Local).AddTicks(6000), false, null, null },
                    { 3L, null, "Slider3", 6, new DateTime(2022, 7, 6, 11, 58, 37, 340, DateTimeKind.Local).AddTicks(6093), false, null, null },
                    { 4L, null, "Slider4", 6, new DateTime(2022, 7, 6, 11, 58, 37, 340, DateTimeKind.Local).AddTicks(6149), false, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 6, 11, 58, 37, 339, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 6, 11, 58, 37, 340, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.CreateIndex(
                name: "IX_SlidersCategory_CategoryId",
                table: "SlidersCategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SlidersCategory");

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

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 7, 3, 16, 31, 50, 545, DateTimeKind.Local).AddTicks(9674));
        }
    }
}
