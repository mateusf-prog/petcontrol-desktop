using PetControlSystem.Dto;
using PetControlSystem.Models;

namespace PetControlSystem.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(this Product product) =>
            new(product.Id, product.Name, product.Description, product.Price, product.Stock);

        public static Product ToModel(this ProductDto dto) =>
            new(dto.Name, dto.Price, dto.Description, dto.Stock);
    }
}
