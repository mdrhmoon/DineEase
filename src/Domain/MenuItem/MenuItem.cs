namespace Domain;

public sealed class MenuItem : BaseEntity
{
    public string Name { get; init; }
    public string Description { get; init; }
    public Decimal Price { get; init; }
    public Guid CategoryId { get; init; }
    public bool IsAvailable { get; init; }
    public string ImageUrl { get; init; }
    public Category Category { get; init; }
    public List<MenuIngredients> MenuIngredients { get; init; }
}
