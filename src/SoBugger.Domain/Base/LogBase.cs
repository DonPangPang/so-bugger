
using SoBugger.Domain.Platform;

namespace SoBugger.Domain.Base;

public abstract class LogBase : EntityBase, ICreatored
{

    public string? Note { get; set; }
    public int Count { get; set; }

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}
