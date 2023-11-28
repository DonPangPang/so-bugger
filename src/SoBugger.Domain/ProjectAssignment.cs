using SoBugger.Domain.Base;

namespace SoBugger.Domain;

public class ProjectAssignment : Assignment
{
    public Guid ProjectRequirementId { get; set; }
    public ProjectRequirement? ProjectRequirement { get; set; }
}