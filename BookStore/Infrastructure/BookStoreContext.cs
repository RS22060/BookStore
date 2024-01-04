using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions<BookStoreContext> options) 
            : base(options)
        { 
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
