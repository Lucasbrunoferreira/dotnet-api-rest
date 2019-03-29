using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookStore.DAL.Databases
{
  public class PGSQLContext : DbContext
  {
    public DbSet<Author> Author {get; set;}
    public DbSet<Book> Book {get; set;}
    public DbSet<BookGenre> BookGenre {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PGSQL_CONNECTION_STRING") ?? "host=127.0.0.1;port=5432;database=teste;user id=postgres;password=mysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("teste");
      modelBuilder.Entity<Author>().HasKey(a => a.authorId);
      modelBuilder.Entity<BookGenre>().HasKey(bg => bg.genreId);
      modelBuilder.Entity<Book>().HasKey(bg => bg.bookId);
      modelBuilder.Entity<BookGenre>().HasMany(a => a.books)
        .WithOne(b => b.genre)
        .HasForeignKey(c => c.genreId);
      modelBuilder.Entity<Author>().HasMany(a => a.books)
        .WithOne(b => b.author)
        .HasForeignKey(c => c.authorId);
    }
  }
}