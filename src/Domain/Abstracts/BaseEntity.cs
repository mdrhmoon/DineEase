namespace Domain;

public class BaseEntity
{
    public Guid Id { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.Now;
    public Guid CreatedById { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public Guid? UpdatedById { get; init; }
    public bool IsActive { get; init; } = true;
}
