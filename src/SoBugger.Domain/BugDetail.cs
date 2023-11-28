using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class BugDetail : EntityBase, ICreatored
{
    public Guid BugId { get; set; }
    public Bug? Bug { get; set; }

    public string Content { get; set; } = string.Empty;

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}