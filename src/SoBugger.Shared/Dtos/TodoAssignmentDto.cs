using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.Shared.Dtos;

public record TodoAssignmentDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public string? Content { get; set; }

    public Guid? ProjectId { get; set; }
    public ProjectDto? Project { get; set; }

    public List<ProjectVersionDto> ProjectVersions { get; set; } = new List<ProjectVersionDto>();

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<TodoTagDto> TodoTags { get; set; } = new List<TodoTagDto>();
    public Guid? TodoGroupId { get; set; }
    public TodoGroupDto? TodoGroup { get; set; }

    public bool Deleted { get; set; }

    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}