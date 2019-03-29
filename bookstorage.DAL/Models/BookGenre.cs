using System;
using System.Collections.Generic;

namespace bookstorage.DAL.Models
{
    public class BookGenre
    {
      public Guid genreId { get; set; }
      public string description { get; set; }
	    public string initials { get; set; }
      public virtual List<Book> books { get; set; }

      public BookGenre(string description, string initials)
      {
        this.description = description;
        this.initials = initials;
      }
    }
}
