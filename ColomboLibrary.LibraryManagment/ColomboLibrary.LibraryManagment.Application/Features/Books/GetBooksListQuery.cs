using MediatR;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books
{
    public class GetBooksListQuery : IRequest<List<BookListVm>>
    {
    }
}
