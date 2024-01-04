using BookStore.Enums;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public required string Title { get; set; }

        public Genre Genre { get; set; }

        public required string Description { get; set; }

        public virtual required Author Author { get; set; }
    }
}
