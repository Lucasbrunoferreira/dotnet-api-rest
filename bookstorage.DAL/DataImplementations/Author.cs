using System;

namespace bookstorage.DAL.DataImplementatios
{
    public class Author
    {
      public string name { get; set; }

	    public string nationality { get; set; }

      public Author(string name, string nationality)
      {
        this.name = name;
        this.nationality = nationality;
      }
    }
}



