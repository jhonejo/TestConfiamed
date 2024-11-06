using jhon_andrade_back.Models;
using Microsoft.EntityFrameworkCore;

namespace jhon_andrade_back
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
