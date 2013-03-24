using KrabStore.Domain.Entities;
using System.Data.Entity;

namespace KrabStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
