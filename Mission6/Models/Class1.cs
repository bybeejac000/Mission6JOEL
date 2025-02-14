using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class Class1 : DbContext
    {
        public Class1(DbContextOptions<Class1> options) : base(options)
        { }

        public DbSet<Form> Movies { get; set; }
    }
}
