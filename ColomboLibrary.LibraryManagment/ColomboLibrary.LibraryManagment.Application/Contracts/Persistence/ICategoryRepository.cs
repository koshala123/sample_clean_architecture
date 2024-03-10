using ColomboLibrary.LibraryManagement.Domain.Entities;

namespace ColomboLibrary.LibraryManagment.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
