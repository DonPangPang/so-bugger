using SoBugger.Domain.Base;

namespace SoBugger.Domain.Platform;

public class FileResource : EntityBase, ICreatored
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Suffix { get; set; } = string.Empty;
    public string Uri { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? ContentType { get; set; }
    public long Size { get; set; }
    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
}
