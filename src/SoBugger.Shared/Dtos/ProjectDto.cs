using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.Shared.Dtos;

public record ProjectDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;

    public List<ProjectVersionDto> ProjectVersions { get; set; } = new List<ProjectVersionDto>();

    public Guid LeaderId { get; set; }
    public UserDto? Leader { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<ProjectRequirementDto> ProjectRequirements { get; set; } = new List<ProjectRequirementDto>();

    public List<ProjectAssignmentDto> ProjectAssignments { get; set; } = new List<ProjectAssignmentDto>();

    public List<TodoAssignmentDto> TodoAssignments { get; set; } = new List<TodoAssignmentDto>();
    public List<BugDto> Bugs { get; set; } = new List<BugDto>();

    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Deleted { get; set; }
    public Guid? ModifyerId { get; set; }
    public UserDto? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
}