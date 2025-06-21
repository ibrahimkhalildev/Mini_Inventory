using Microsoft.EntityFrameworkCore;
using MiniInventoryManagementSystem.Models;

namespace MiniInventoryManagementSystem.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
    }
}
