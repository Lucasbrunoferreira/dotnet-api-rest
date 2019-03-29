using System;

namespace bookstorage.DAL.DataImplementatios
{
    public class BookGenre
    {
      public string description { get; set; }

	    public string initials { get; set; }

      public BookGenre(string description, string initials)
      {
        this.description = description;
        this.initials = initials;
      }
    }
}
