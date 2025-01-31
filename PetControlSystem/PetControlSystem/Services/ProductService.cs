using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetControlSystem.Dto;
using PetControlSystem.Mappers;
using PetControlSystem.Repositories.Interfaces;
using PetControlSystem.Services.Interfaces;

namespace PetControlSystem.Services
{
    public class ProductService(IRepository repository) : IProductService
    {
        private readonly IRepository _repository = repository;

        public Result<string> Delete(long id)
        {
            var existingProduct = _repository.Products.FirstOrDefault(p => p.Id.Equals(id));
            if (existingProduct == null)
                return Result.Fail($"Product not found. ID: {id}");

            _repository.Products.Remove(existingProduct!);
            _repository.SaveChanges();

            return Result.Ok();
        }

        public Result<ProductDto> Read(long id)
        {
            var existingProduct = _repository.Products.FirstOrDefault(p => p.Id.Equals(id));
            if (existingProduct == null)
                return Result.Fail<ProductDto>($"Product not found. ID: {id}");

            var result = existingProduct.ToDto();

            return Result.Ok(result);
        }

        public Result<List<ProductDto>> ReadAll()
        {
            var products = _repository.Products.Select(p => p.ToDto()).ToList();
            return Result.Ok(products);
        }

        public async Task<Result<ProductDto>> Create(ProductDto input)
        {
            var existingProduct = await _repository.Products.FirstOrDefaultAsync(p => p.Name == input.Name);
            if (existingProduct != null)
                return Result.Fail<ProductDto>("Product already exists with the same name");

            var product = input.ToModel();
            await _repository.Products.AddAsync(product);
            _repository.SaveChanges();

            var result = product.ToDto();
            return Result.Ok(result);
        }
    }
}