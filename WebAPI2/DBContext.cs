using Microsoft.EntityFrameworkCore;
using WebAPI2.Models;

namespace WebAPI2
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { } 

        public DbSet<TestTable> Items { get; set; }   

    }
}
