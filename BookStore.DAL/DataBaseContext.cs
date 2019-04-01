using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookStore.DAL
{
  public class DataBaseContext : DbContext
  {
    public DbSet<Book> Book {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PGSQL_CONNECTION_STRING") ?? "host=127.0.0.1;port=5432;database=library;user id=postgres;password=mysecretpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("bookStore");
      modelBuilder.Entity<Book>().HasKey(b => b.bookId);
    }
  }
}