using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Services;

namespace ESYTestApp.Services.Validators
{
    public class ProductPriceValidator:IInputValidator
    {
        public bool Validate(AddProductRequest request)
        {
            return request.Price > 0;
        }
    }
}