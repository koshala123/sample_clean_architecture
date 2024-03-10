using ColomboLibrary.LibraryManagement.Domain.Entities;

namespace ColomboLibrary.LibraryManagment.Application.Contracts.Persistence
{
    public interface IMemberRepository : IAsyncRepository<Member>
    {
    }
}
