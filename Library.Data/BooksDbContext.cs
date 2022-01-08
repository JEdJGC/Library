using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class BooksDbContext : DbContext
    {

        private const string ConnectionString =
        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;"
+ "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;"
+ "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DbSet<Author> Authors { get; set; }

        public BooksDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(LoadAuthors());
            base.OnModelCreating(modelBuilder);
        }
        private Author[] LoadAuthors()
        {
            return new Author[]
            {
                new Author
                {
                    AuthorId = 1,
                    FirstName = "Harvey",
                    LastName = "Deitel"
                },
                new Author
                {
                    AuthorId = 2,
                    FirstName = "Paul",
                    LastName = "Deitel"
                },
                new Author
                {
                    AuthorId = 3,
                    FirstName = "Ian",
                    LastName = "Summerville"
                }
            };
        }
    }
}
