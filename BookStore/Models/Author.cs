namespace BookStore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public required string  Name { get; set; }

        public required string Surname { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
