using System;
using System.Collections.Generic;

namespace Bookstorage.DAL.Models
{
    public class Author
    {
      public Guid authorId { get; set; }
      public string name { get; set; }
	    public string nationality { get; set; }
      public virtual List<Book> books { get; set; }

      public Author(string name, string nationality)
      {
        this.name = name;
        this.nationality = nationality;
      }
    }
}



