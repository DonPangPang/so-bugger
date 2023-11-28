using SoBugger.Shared.Base;

namespace SoBugger.Shared.Dtos;

public record ProjectAssignmentDto : ViewModel
{
    public Guid ProjectRequirementId { get; set; }
    public ProjectRequirementDto? ProjectRequirement { get; set; }
}