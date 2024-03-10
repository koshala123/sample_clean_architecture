using MediatR;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBookDetail
{
    public class GetBookDetailQuery : IRequest<BookDetailVm>
    {
        public Guid Id { get; set; }
    }
}
