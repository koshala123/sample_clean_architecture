using MediatR;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books
{
    public class GetBookDetailQuery : IRequest<BookDetailVm>
    {
        public Guid Id { get; set; }
    }
}
