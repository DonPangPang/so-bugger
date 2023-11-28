namespace SoBugger.Shared.Dtos;

public record BugCommentAttachmentDto : AttachmentDto
{
    public Guid BugCommentId { get; set; }
    public BugCommentDto? BugComment { get; set; }
}