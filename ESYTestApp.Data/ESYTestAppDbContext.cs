using System.Threading.Tasks;
using ESYTestApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ESYTestApp.Data
{
    public class ESYTestAppDbContext : DbContext, IESYTestAppDbContext
    {
        public ESYTestAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<Product> Products { get; set; }
    }
}