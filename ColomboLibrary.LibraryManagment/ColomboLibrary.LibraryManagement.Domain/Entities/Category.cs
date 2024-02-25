namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Book>? Books { get; set; }
    }
}
