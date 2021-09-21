using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Models;

namespace ESYTestApp.Core.Services
{
    public interface IPvnCalculator
    {
        ProductWithPvn CalculatePvn(Product product);
    }
}