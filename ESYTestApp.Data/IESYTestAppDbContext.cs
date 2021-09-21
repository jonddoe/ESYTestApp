using System.Threading.Tasks;
using ESYTestApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ESYTestApp.Data
{
    public interface IESYTestAppDbContext
    {
        DbSet<T> Set<T>() where T : class;
        EntityEntry<T> Entry<T>(T entity) where T : class;
        DatabaseFacade Database { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbSet<Product> Products { get; set; }
    }
}