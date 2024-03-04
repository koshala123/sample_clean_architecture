using ColomboLibrary.LibraryManagement.Domain.Common;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Checkout : AuditableEntity
    {
        public Guid CheckoutId { get; }
        public Book Book { get; }
        public Member Member { get; }
        public DateTime DateIssued { get; }
        public DateTime DueDate { get; }
        public DateTime? DateReturned { get; set; }
        public bool IsOverDue => DateReturned == null && DueDate < DateTime.Now;

        public Checkout(Book book, Member member, DateTime issuedDate, DateTime dueDate, DateTime? dateReturned)
        {
            CheckoutId = Guid.NewGuid();
            Book = book;
            Member = member;
            DateIssued = issuedDate;
            DueDate = dueDate;
            DateReturned = dateReturned;
        }
    }
}
