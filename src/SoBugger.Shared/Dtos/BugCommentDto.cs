using SoBugger.Shared.Base;

namespace SoBugger.Shared.Dtos;

public record BugCommentDto : ViewModel
{
    public Guid BugId { get; set; }
    public BugDto? Bug { get; set; }

    public string Content { get; set; } = string.Empty;

    public List<BugCommentAttachmentDto> BugCommentAttachments = new List<BugCommentAttachmentDto>();
    public Guid CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
}