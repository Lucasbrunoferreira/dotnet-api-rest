using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bookStore");

            migrationBuilder.CreateTable(
                name: "books",
                schema: "bookStore",
                columns: table => new
                {
                    bookId = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 30, nullable: false),
                    price = table.Column<float>(nullable: false),
                    genre = table.Column<string>(maxLength: 20, nullable: false),
                    author = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.bookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books",
                schema: "bookStore");
        }
    }
}
