using MyLibrary.Entities.Concrete;
using System.Data.Entity;

namespace MyLibrary.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext:DbContext
    {      
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LibraryUser> LibraryUsers { get; set; }
        public DbSet<Trace> Traces { get; set; }
        public DbSet<UserBookTrace> UserBookTraces { get; set; }
    }
}
