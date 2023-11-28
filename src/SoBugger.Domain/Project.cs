using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class Project : EntityBase, ICreatored, ISoftDelted, IModifyer
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;

    public ICollection<ProjectVersion> ProjectVersions { get; set; } = new List<ProjectVersion>();

    public Guid LeaderId { get; set; }
    public User? Leader { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public ICollection<ProjectRequirement> ProjectRequirements { get; set; } = new List<ProjectRequirement>();

    public ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();

    public ICollection<TodoAssignment> TodoAssignments { get; set; } = new List<TodoAssignment>();

    public ICollection<Bug> Bugs { get; set; } = new List<Bug>();

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Deleted { get; set; }
    public Guid? ModifyerId { get; set; }
    public User? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
}