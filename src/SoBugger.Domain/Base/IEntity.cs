namespace SoBugger.Domain.Base;

public interface IEntity
{
    public Guid Id { get; set; }
}

public abstract class EntityBase : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}

public interface ISoftDelted
{
    public bool Deleted { get; set; }
}

public interface IDisabled
{
    public bool Disabled { get; set; }
}

public interface ICreatored
{
    public Guid CreatorId { get; set; }

    public DateTime CreatedAt { get; set; }
}

public interface IModifyer
{
    public Guid? ModifyerId { get; set; }

    public DateTime? ModifiedAt { get; set; }
}