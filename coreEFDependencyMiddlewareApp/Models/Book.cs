namespace coreEFDependencyMiddlewareApp.Models
{
    public class Book
    {
        // Scalar Properties
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        
        // Navigation Properties
        public BookDetail? BookDetail { get; set; }
    }
}
