using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFDependencyMiddlewareApp.Models
{
    public class BookDetail
    {
        // Scalar Properties
        public int BookDetailId { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public int PageCount { get; set; }

        // Navigation Properties
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
