using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class ProjectVersion : EntityBase, ICreatored, IModifyer, ISoftDelted
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }

    public ICollection<Bug> Bugs { get; set; } = new List<Bug>();
    public ICollection<TodoAssignment> TodoAssignments { get; set; } = new List<TodoAssignment>();

    public bool Deleted { get; set; }
    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifyerId { get; set; }
    public User? Modifier { get; set; }
    public DateTime? ModifiedAt { get; set; }
}