using SoBugger.Shared.Base;

namespace SoBugger.Shared.Dtos.Platform;

public record FileResourceDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Suffix { get; set; } = string.Empty;
    public string Uri { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? ContentType { get; set; }
    public long Size { get; set; }
    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}
