using System.ComponentModel.DataAnnotations;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Member
    {
        public Guid MemberId { get; set; }
        public required string FirstName { get; set; }
        public required PhoneAttribute MobileNumber { get; set; }
    }
}
