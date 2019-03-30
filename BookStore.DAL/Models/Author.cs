using System;
using System.Collections.Generic;

namespace BookStore.DAL.Models
{
    public class Author
    {
      public Guid authorId { get; set; }
      public string name { get; set; }
	    public string nationality { get; set; }
      public virtual List<Book> books { get; set; }
    }
}



