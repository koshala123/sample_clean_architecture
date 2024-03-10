using ColomboLibrary.LibraryManagement.Domain.Entities;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
