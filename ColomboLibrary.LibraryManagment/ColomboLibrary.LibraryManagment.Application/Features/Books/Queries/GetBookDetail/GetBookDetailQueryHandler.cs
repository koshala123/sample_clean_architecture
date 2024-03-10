using AutoMapper;
using ColomboLibrary.LibraryManagement.Domain.Entities;
using ColomboLibrary.LibraryManagment.Application.Contracts.Persistence;
using MediatR;

namespace ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBookDetail
{
    public class GetBookDetailQueryHandler : IRequestHandler<GetBookDetailQuery, BookDetailVm>
    {

        private readonly IAsyncRepository<Book> _bookRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetBookDetailQueryHandler(IMapper mapper, IAsyncRepository<Category> categoryRepository, IAsyncRepository<Book> bookRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _bookRepository = bookRepository;
        }

        public async Task<BookDetailVm> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
        {
            var @book = await _bookRepository.GetByIdAsync(request.Id);
            var bookDetailDto = _mapper.Map<BookDetailVm>(@book);

            var category = _categoryRepository.GetByIdAsync(@book.CategoryId);
            bookDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return bookDetailDto;
        }
    }
}
