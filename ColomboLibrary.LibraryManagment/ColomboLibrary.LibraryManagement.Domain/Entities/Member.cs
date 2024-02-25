using System.ComponentModel.DataAnnotations;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Member
    {
        public Guid MemberId { get; set; }
        public required string Name { get; set; }
        [RegularExpression(@"^\d{10}$")]
        public required string MobileNumber { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
    }
}
