using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.Shared.Dtos;

public record ProjectVersionDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }
    public ProjectDto? Project { get; set; }

    public List<BugDto> Bugs { get; set; } = new List<BugDto>();
    public List<TodoAssignmentDto> TodoAssignments { get; set; } = new List<TodoAssignmentDto>();

    public bool Deleted { get; set; }
    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifyerId { get; set; }
    public UserDto? Modifier { get; set; }
    public DateTime? ModifiedAt { get; set; }
}