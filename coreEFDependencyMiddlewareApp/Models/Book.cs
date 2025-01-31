using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFDependencyMiddlewareApp.Models
{
    public class Book
    {
        // Scalar Properties
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        // Navigation Properties
        public BookDetail? BookDetail { get; set; }
        public Author? Author { get; set; }
    }
}
