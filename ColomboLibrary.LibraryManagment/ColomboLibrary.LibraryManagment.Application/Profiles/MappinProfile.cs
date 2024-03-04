using AutoMapper;
using ColomboLibrary.LibraryManagement.Domain.Entities;
using ColomboLibrary.LibraryManagment.Application.Features.Books;

namespace ColomboLibrary.LibraryManagment.Application.Profiles
{
    public class MappinProfile : Profile
    {
        public MappinProfile()
        {
            CreateMap<Book, BookListVm>().ReverseMap();
        }
    }
}
