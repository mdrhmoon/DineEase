namespace Domain;

public sealed class Category : BaseEntity
{
    public string Name { get; init; }
    public string Description { get; init; }
    public List<MenuItem> MenuItems { get; init; }
}