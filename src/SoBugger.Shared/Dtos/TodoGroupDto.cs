using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.Shared.Dtos;

public record TodoGroupDto : ViewModel
{
    public string Name { get; set; } = string.Empty;

    public List<TodoAssignmentDto> TodoAssignments { get; set; } = new List<TodoAssignmentDto>();

    public bool Deleted { get; set; }

    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}