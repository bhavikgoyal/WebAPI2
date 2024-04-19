using Microsoft.EntityFrameworkCore;
using WebAPI2.Models;

namespace WebAPI2
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options)
             : base(options)
        { }

        public DbSet<TestTable> Items { get; set; }   

    }
}
