using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.Shared.Dtos;

public record BugDetailDto : ViewModel
{
    public Guid BugId { get; set; }
    public BugDto? Bug { get; set; }

    public string Content { get; set; } = string.Empty;

    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}