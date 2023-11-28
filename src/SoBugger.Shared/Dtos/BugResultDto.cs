using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.Shared.Enums;

namespace SoBugger.Shared.Dtos;

public record BugResultDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public int Order { get; set; }

    public BugState BugState { get; set; } = BugState.Active;

    public bool Deleted { get; set; }
    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}