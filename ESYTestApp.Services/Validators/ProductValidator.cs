using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Services;

namespace ESYTestApp.Services.Validators
{
    public class ProductValidator : IInputValidator
    {
        public bool Validate(AddProductRequest request)
        {
            return request != null;
        }
    }
}