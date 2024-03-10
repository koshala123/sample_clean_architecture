using ColomboLibrary.LibraryManagement.Domain.Common;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Book : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ISBN { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public string? Publisher { get; set; }
        public DateTime PublicationYear { get; set; }
        public BookStatus Status { get; set; }
        public BookType Type { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }

    public enum BookStatus
    {
        Available,
        CheckedOut,
        Reserved,
        OnHold
    }

    public enum BookType
    {
        Physical,
        Ebook,
        Audiobook
    }
}
