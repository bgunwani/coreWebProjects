namespace coreEFDependencyMiddlewareApp.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
