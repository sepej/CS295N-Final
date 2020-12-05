using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MADWORDS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Madwords",
                columns: table => new
                {
                    MadwordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MadwordTitle = table.Column<string>(nullable: true),
                    MadwordTopic = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    MadwordRating = table.Column<int>(nullable: false),
                    AuthorUserID = table.Column<int>(nullable: true),
                    MadwordText = table.Column<string>(nullable: true),
                    MadwordDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Madwords", x => x.MadwordID);
                    table.ForeignKey(
                        name: "FK_Madwords_User_AuthorUserID",
                        column: x => x.AuthorUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Madwords_AuthorUserID",
                table: "Madwords",
                column: "AuthorUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Madwords");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
