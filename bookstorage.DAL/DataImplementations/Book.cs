using bookstorage.DAL.DataImplementatios;
using System;

namespace bookstorage.DAL.DataImplementatios
{
    public class Book
    {
      public string name { get; set; }

      public virtual Author author { get; set; }

      public float price { get; set; }

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
