using System.Collections.Generic;
using System.Linq;
using ESYTestApp.Core.Models;
using ESYTestApp.Core.Services;
using ESYTestApp.Data;

namespace ESYTestApp.Services
{
    public class EntityService<T> : DbService, IEntityService<T> where T : Entity
    {
        public EntityService(ESYTestAppDbContext context) : base(context)
        {
        }

        public IQueryable<T> Query()
        {
            return Query<T>();
        }

        public IEnumerable<T> Get()
        {
            return Get<T>();
        }

        public T GetById(int id)
        {
            return GetById<T>(id);
        }

        public void Create(T entity)
        {
            Create<T>(entity);
        }

        public void Update(T entity)
        {
            Update<T>(entity);
        }

        public void Delete(T entity)
        {
            Delete<T>(entity);
        }
    }
}