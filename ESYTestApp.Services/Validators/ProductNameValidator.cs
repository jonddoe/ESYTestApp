using ESYTestApp.Core.Dto;
using ESYTestApp.Core.Services;

namespace ESYTestApp.Services.Validators
{
    public class ProductNameValidator: IInputValidator
    {
        public bool Validate(AddProductRequest request)
        {
            return !string.IsNullOrEmpty(request.Name);
        }
    }
}