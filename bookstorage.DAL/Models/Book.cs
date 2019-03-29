using System;

namespace bookstorage.DAL.Models
{
  public class Book
  {
    public Guid authorId { get; set; }
    public Guid genreId { get; set; }
    public Guid bookId { get; set; }
    public string name { get; set; }
    public float price { get; set; }
    public virtual Author author { get; set; }
    public virtual BookGenre genre { get; set; }

    public Book(string name, Author author, float price, BookGenre genre)
    {
      this.name = name;
      this.author = author;
      this.price = price;
      this.genre = genre;
    }
  }
}
