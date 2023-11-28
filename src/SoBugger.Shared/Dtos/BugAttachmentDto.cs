namespace SoBugger.Shared.Dtos;

public record BugAttachmentDto : AttachmentDto
{
    public Guid BugId { get; set; }
    public BugDto? Bug { get; set; }
}