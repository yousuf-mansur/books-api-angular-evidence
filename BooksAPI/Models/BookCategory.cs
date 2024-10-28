using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BooksAPI.Models
{
    [Table(nameof(BookCategory))]
    public class BookCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookCategoryId { get; set; }

        
        public required string CategoryName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
