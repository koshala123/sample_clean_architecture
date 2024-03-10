using ColomboLibrary.LibraryManagement.Domain.Common;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Member : AuditableEntity
    {
        public Guid MemberId { get; set; }
        public string Name { get; }
        public string MobileNumber { get; }
        public string Email { get; }

        public Member(string nameOfMember, string mobileNumber, string email)
        {
            MemberId = Guid.NewGuid();
            Name = nameOfMember;
            MobileNumber = mobileNumber;
            Email = email;
        }
    }
}
