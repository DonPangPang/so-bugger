using SoBugger.Shared.Dtos.Base;

namespace SoBugger.Shared.Dtos;

public record ProjectRequirementDto : RequirementDto
{
    public Guid ProjectId { get; set; }
    public ProjectDto? Project { get; set; }

    public List<ProjectAssignmentDto> Assignments { get; set; } = new List<ProjectAssignmentDto>();
}