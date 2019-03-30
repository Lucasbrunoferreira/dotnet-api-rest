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
                name: "author",
                schema: "bookStore",
                columns: table => new
                {
                    authorId = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 40, nullable: false),
                    nationality = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.authorId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                schema: "bookStore",
                columns: table => new
                {
                    genreId = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    initials = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.genreId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                schema: "bookStore",
                columns: table => new
                {
                    authorId = table.Column<Guid>(nullable: false),
                    genreId = table.Column<Guid>(nullable: false),
                    bookId = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.bookId);
                    table.ForeignKey(
                        name: "FK_Book_author_authorId",
                        column: x => x.authorId,
                        principalSchema: "bookStore",
                        principalTable: "author",
                        principalColumn: "authorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Genre_genreId",
                        column: x => x.genreId,
                        principalSchema: "bookStore",
                        principalTable: "Genre",
                        principalColumn: "genreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_authorId",
                schema: "bookStore",
                table: "Book",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_genreId",
                schema: "bookStore",
                table: "Book",
                column: "genreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book",
                schema: "bookStore");

            migrationBuilder.DropTable(
                name: "author",
                schema: "bookStore");

            migrationBuilder.DropTable(
                name: "Genre",
                schema: "bookStore");
        }
    }
}
