using System;
using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Models;
using ESYTestApp.Core.Services;

namespace ESYTestApp.Services
{
    public class PvnCalculator : IPvnCalculator
    {
        public ProductWithPvn CalculatePvn(Product product)
        {
            var priceWithPvn = Math.Round(product.Price * (1 + 0.21), 2);
            var prodWithPvn = new ProductWithPvn
            {
                Name = product.Name,
                Amount = product.Amount,
                DateAdded = product.DateAdded,
                Price = product.Price,
                PriceWithPvn = priceWithPvn
            };
            return prodWithPvn;
        }
    }
}