using MediatR;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBooksList
{
    public class GetBooksListQuery : IRequest<List<BookListVm>>
    {
    }
}
