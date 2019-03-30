using System;
using System.Collections.Generic;

namespace BookStore.DAL.Models
{
    public class Genre
    {
      public Guid genreId { get; set; }
      public string description { get; set; }
	    public string initials { get; set; }
      public virtual List<Book> books { get; set; }
    }
}
