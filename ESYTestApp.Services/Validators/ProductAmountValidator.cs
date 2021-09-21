using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Services;

namespace ESYTestApp.Services.Validators
{
    public class ProductAmountValidator:IInputValidator     
    {
        public bool Validate(AddProductRequest request)
        {
            return request.Amount > 0;
        }
    }
}