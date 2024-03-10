using ColomboLibrary.LibraryManagement.Domain.Entities;

namespace ColomboLibrary.LibraryManagment.Application.Contracts.Persistence
{
    public interface ICheckoutRepository : IAsyncRepository<Checkout>
    {
    }
}
