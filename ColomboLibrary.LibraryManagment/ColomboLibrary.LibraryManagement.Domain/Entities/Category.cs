using ColomboLibrary.LibraryManagement.Domain.Common;

namespace ColomboLibrary.LibraryManagement.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
        public ICollection<Book>? Books { get; set; }
    }

    public enum BookCategory
    {
        Fiction,
        NonFiction,
        Science,
        History,
        Biography,
        Mystery,
        Fantasy,
        Romance,
        Thriller,
        Horror,
        SelfHelp,
        Health,
        Travel,
        Cookbooks,
        Art,
        Poetry,
        Religion,
        Music,
        ScienceFiction,
        Business,
        Economics,
        Politics,
        Philosophy,
        Psychology,
        Education,
        SocialSciences,
        Law,
        ComputerScience,
        Mathematics,
        Medicine,
        Engineering,
        Agriculture,
        Architecture,
        Sports,
        Games,
        Comics,
        GraphicNovels,
        Drama,
        Crafts,
        Hobbies,
        Home,
        Humor,
        Literature,
        Reference,
        Technology,
        Parenting,
        Pets,
        Photography,
        PoliticalScience,
        TrueCrime
    }
}
