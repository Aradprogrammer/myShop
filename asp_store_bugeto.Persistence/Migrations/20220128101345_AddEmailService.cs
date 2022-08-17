using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_store_bugeto.Persistence.Migrations
{
    public partial class AddEmailService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SenderEmails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressEmail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Removetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenderEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SentEmails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Removetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderEmailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_SenderEmails_SenderEmailId",
                        column: x => x.SenderEmailId,
                        principalTable: "SenderEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "SenderEmailId", "Subject", "Text", "Titel", "URL" },
                values: new object[] { 1L, null, "بازیابی گذرواژه", "<a href= $Link >بازیابی گذرواژه</a>", "بازیابی گذرواژه", "Authentication/resetpassword" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "SenderEmailId", "Subject", "Text", "Titel", "URL" },
                values: new object[] { 2L, null, "تایید ایمیل", "<a href= $Link >تایید ایمیل</a>", "تایید ایمیل", "Authentication/verifyemail" });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_SenderEmailId",
                table: "Emails",
                column: "SenderEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_Subject",
                table: "Emails",
                column: "Subject",
                unique: true,
                filter: "[Subject] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SenderEmails_AddressEmail",
                table: "SenderEmails",
                column: "AddressEmail",
                unique: true,
                filter: "[AddressEmail] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "SentEmails");

            migrationBuilder.DropTable(
                name: "Temps");

            migrationBuilder.DropTable(
                name: "SenderEmails");
        }
    }
}
