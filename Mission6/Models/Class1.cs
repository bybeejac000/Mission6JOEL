using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{   //Make the model for the db
    public class Class1 : DbContext
    {
        public Class1(DbContextOptions<Class1> options) : base(options)
        { }

        public DbSet<Form> Movies { get; set; }
        public DbSet<CatForm> Cats { get; set; }
    }
}
