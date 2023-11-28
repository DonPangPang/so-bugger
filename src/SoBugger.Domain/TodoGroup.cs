using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class TodoGroup : EntityBase, ICreatored, ISoftDelted
{
    public string Name { get; set; } = string.Empty;

    public ICollection<TodoAssignment> TodoAssignments { get; set; } = new List<TodoAssignment>();

    public bool Deleted { get; set; }

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}
