using ColomboLibrary.LibraryManagement.Domain.Entities;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBookDetail
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
