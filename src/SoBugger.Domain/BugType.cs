using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class BugType : EntityBase, ICreatored, ISoftDelted
{
    public string Name { get; set; } = string.Empty;
    public int Order { get; set; }

    public bool Deleted { get; set; }
    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}