using AutoMapper;
using ColomboLibrary.LibraryManagement.Domain.Entities;
using ColomboLibrary.LibraryManagment.Application.Features.Books.Queries.GetBooksList;

namespace ColomboLibrary.LibraryManagment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListVm>().ReverseMap();
            CreateMap<Book, BookDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
