using System.Data.Entity;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    class EFDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
