using SoBugger.Domain.Base;

namespace SoBugger.Domain;

public class ProjectRequirement : Requirement
{
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }

    public ICollection<ProjectAssignment> Assignments { get; set; } = new List<ProjectAssignment>();
}