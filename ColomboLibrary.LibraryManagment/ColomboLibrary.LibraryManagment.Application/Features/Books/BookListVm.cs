using ColomboLibrary.LibraryManagement.Domain.Entities;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books
{
    public class BookListVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public string ImageUrl { get; set; }
    }
}
