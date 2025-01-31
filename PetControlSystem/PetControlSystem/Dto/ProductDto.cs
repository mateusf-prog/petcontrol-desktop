
namespace PetControlSystem.Dto
{
    public record ProductDto(
        long? Id,
        string Name,
        string Description,
        decimal Price,
        int Stock)
    { }
}
