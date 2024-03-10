using AutoMapper;
using ColomboLibrary.LibraryManagement.Domain.Entities;
using ColomboLibrary.LibraryManagment.Application.Contracts.Persistence;
using MediatR;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBooksList
{
    public class GetBooksListQueryHandler : IRequestHandler<GetBooksListQuery, List<BookListVm>>
    {
        private readonly IAsyncRepository<Book> _bookRepository;
        private readonly IMapper _mapper;

        public GetBooksListQueryHandler(IAsyncRepository<Book> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookListVm>> Handle(GetBooksListQuery request, CancellationToken cancellationToken)
        {
            var allBooks = (await _bookRepository.ListAllAsync()).OrderBy(x => x.Title);
            return _mapper.Map<List<BookListVm>>(allBooks);
        }
    }
}
