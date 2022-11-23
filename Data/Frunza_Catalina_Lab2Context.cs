using Microsoft.EntityFrameworkCore;
using Frunza_Catalina_Lab2.Models;

namespace Frunza_Catalina_Lab2.Data
{
    public class Frunza_Catalina_Lab2Context : DbContext
    {
        public Frunza_Catalina_Lab2Context (DbContextOptions<Frunza_Catalina_Lab2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; } = null!;

        public virtual DbSet<Publisher> Publisher { get; set; } = null!;

        public virtual DbSet<Author> Author { get; set; } = null!;

        public virtual DbSet<Category> Category { get; set; } = null!;
    }
}
