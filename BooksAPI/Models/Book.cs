using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI.Models
{
    [Table(nameof(Book))]
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        
        public required string BookName { get; set; }

   
        public required string ISBNNumber { get; set; }

        public string? Writer { get; set; }

        
        public decimal StandardCost { get; set; }

        
        public decimal ListPrice { get; set;}

       
        public int Edition { get; set;}

        
        public decimal Pages { get; set;}

        [ForeignKey(nameof(ProductCategory.BookCategoryId))]
        public int BookCategoryId { get; set; }

        public BookCategory? ProductCategory { get; set; }
    }
}
