using SoBugger.Shared.Dtos.Base;

namespace SoBugger.Shared.Dtos;

public record BugRequirementDto : RequirementDto
{
    public Guid BugId { get; set; }
    public BugDto? Bug { get; set; }
}