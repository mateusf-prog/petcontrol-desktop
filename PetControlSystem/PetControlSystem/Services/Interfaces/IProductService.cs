using FluentResults;
using PetControlSystem.Dto;

namespace PetControlSystem.Services.Interfaces
{
    public interface IProductService
    {
        Task<Result<ProductDto>> Create(ProductDto input);
        Result<string> Delete(long id);
        Result<ProductDto> Read(long id);
        Result<List<ProductDto>> ReadAll();
    }
}
