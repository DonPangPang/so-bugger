using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Enums;

namespace SoBugger.Domain;

public class BugResult : EntityBase, ICreatored, ISoftDelted
{
    public string Name { get; set; } = string.Empty;
    public int Order { get; set; }

    public BugState BugState { get; set; } = BugState.Active;

    public bool Deleted { get; set; }
    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}