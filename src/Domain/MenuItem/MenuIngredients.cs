namespace Domain;

public sealed class MenuIngredients : BaseEntity
{
    public string Name { get; init; }
    public string Description { get; init; }
    public string ImageUrl { get; init; }
    public List<MenuItem> MenuItems{ get; init; }
}
