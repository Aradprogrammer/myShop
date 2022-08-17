using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_store_bugeto.Persistence.Migrations
{
    public partial class Add_Popular_And_Satars_And_Visist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllStarsScore",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "PopularCount",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "StarsCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "VisitCount",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "UsersPopulars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Removetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPopulars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersPopulars_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersPopulars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UsersPopulars_ProductId",
                table: "UsersPopulars",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersPopulars_UserId",
                table: "UsersPopulars",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersPopulars");

            migrationBuilder.DropColumn(
                name: "AllStarsScore",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PopularCount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StarsCount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VisitCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "SenderEmails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 5, 29, 12, 20, 46, 880, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Temps",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 5, 29, 12, 20, 46, 881, DateTimeKind.Local).AddTicks(921));
        }
    }
}
