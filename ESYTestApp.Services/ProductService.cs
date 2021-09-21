using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Models;
using ESYTestApp.Core.Services;
using ESYTestApp.Data;

namespace ESYTestApp.Services
{
    public class ProductService : EntityService<Product>, IProductService
    {
        private readonly ESYTestAppDbContext _context;

        public ProductService(ESYTestAppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddProduct(AddProductRequest product)
        {
            var productToBeAdded = new Product
            {
                Amount = product.Amount,
                DateAdded = product.DateAdded,
                Name = product.Name,
                Price = product.Price
            };
            _context.Products.Add(productToBeAdded);
            await _context.SaveChangesAsync();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(u => u.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public IQueryable<Product> GetProductsInTimeInterval(DateTime from, DateTime to)
        {
            return _context.Products.Where(p => p.DateAdded >= from && p.DateAdded <= to);
        }
    }
}