using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "teste");

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "teste",
                columns: table => new
                {
                    authorId = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.authorId);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                schema: "teste",
                columns: table => new
                {
                    genreId = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    initials = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.genreId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                schema: "teste",
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
                        name: "FK_Book_Author_authorId",
                        column: x => x.authorId,
                        principalSchema: "teste",
                        principalTable: "Author",
                        principalColumn: "authorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_BookGenre_genreId",
                        column: x => x.genreId,
                        principalSchema: "teste",
                        principalTable: "BookGenre",
                        principalColumn: "genreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_authorId",
                schema: "teste",
                table: "Book",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_genreId",
                schema: "teste",
                table: "Book",
                column: "genreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book",
                schema: "teste");

            migrationBuilder.DropTable(
                name: "Author",
                schema: "teste");

            migrationBuilder.DropTable(
                name: "BookGenre",
                schema: "teste");
        }
    }
}
