using ColomboLibrary.LibraryManagement.Domain.Common;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Checkout : AuditableEntity
    {
        public Guid CheckoutId { get; }
        public Guid BookId { get; }
        public Guid MemberId { get; }
        public DateTime DateIssued { get; }
        public DateTime DueDate { get; }
        public DateTime? DateReturned { get; set; }
        public bool IsOverDue => DateReturned == null && DueDate < DateTime.Now;

        public Checkout(Guid bookId, Guid memberId, DateTime issuedDate, DateTime dueDate, DateTime? dateReturned)
        {
            CheckoutId = Guid.NewGuid();
            BookId = bookId;
            MemberId = memberId;
            DateIssued = issuedDate;
            DueDate = dueDate;
            DateReturned = dateReturned;
        }
    }
}
