using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class TodoAssignment : EntityBase, ICreatored, ISoftDelted
{
    public string Name { get; set; } = string.Empty;
    public string? Content { get; set; }

    public Guid? ProjectId { get; set; }
    public Project? Project { get; set; }

    public ICollection<ProjectVersion> ProjectVersions { get; set; } = new List<ProjectVersion>();

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public ICollection<TodoTag> TodoTags { get; set; } = new List<TodoTag>();
    public Guid? TodoGroupId { get; set; }
    public TodoGroup? TodoGroup { get; set; }

    public bool Deleted { get; set; }

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}
