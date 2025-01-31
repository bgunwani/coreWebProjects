namespace coreEFDependencyMiddlewareApp.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = string.Empty;

        // Navigation Properties
        public List<BookPublisher>? BookPublishers { get; set; }
    }
}
