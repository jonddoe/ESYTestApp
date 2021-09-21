using ESYTestApp.Core.Dto;

namespace ESYTestApp.Core.Services
{
    public interface IInputValidator
    {
        bool Validate(AddProductRequest request);
    }
}