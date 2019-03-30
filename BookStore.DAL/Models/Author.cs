using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
    [Table("author")]
    public class Author
    {
      public Guid authorId { get; set; }

      [Required]
      [MaxLength(40)]
      public string name { get; set; }

      [Required]
      [MaxLength(20)]
      public string nationality { get; set; }
      public virtual List<Book> books { get; set; }
    }
}



