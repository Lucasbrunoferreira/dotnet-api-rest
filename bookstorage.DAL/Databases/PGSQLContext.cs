using bookstorage.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace bookstorage.DAL.Databases
{
  public class PGSQLContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PGSQL_CONNECTION_STRING") ?? "host=172.17.0.2;port=5432;database=Teste;user id=postgres;password=mysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("teste");
      modelBuilder.Entity<Author>().HasKey(a => a.authorId);
      modelBuilder.Entity<BookGenre>().HasKey(bg => bg.genreId);
      modelBuilder.Entity<Book>().HasKey(bg => bg.bookId);
    }
  }
}