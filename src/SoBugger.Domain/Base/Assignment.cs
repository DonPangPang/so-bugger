
using SoBugger.Domain.Platform;

namespace SoBugger.Domain.Base;

public abstract class Assignment : EntityBase, ICreatored, IModifyer, ISoftDelted
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifyerId { get; set; }
    public User? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool Deleted { get; set; }
}
