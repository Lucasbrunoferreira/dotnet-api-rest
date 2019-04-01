using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models
{
   [Table("books")]
  public class Book
  {
    public Guid bookId { get; set; }
    [Required]
    [MaxLength(30)]
    public string name { get; set; }
    [Required]
    public float price { get; set; }
    [Required]
    [MaxLength(20)]
    public string genre { get; set; }
    [Required]
    [MaxLength(40)]
    public string author { get; set; }
  }
}
