using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Models;

namespace ESYTestApp.Core.Services
{
    public interface IProductService : IEntityService<Product>
    {
        Task AddProduct(AddProductRequest product);
        Product GetProductById(int id);

        List<Product> GetProducts();
        IQueryable<Product> GetProductsInTimeInterval(DateTime @from, DateTime to);
    }
}