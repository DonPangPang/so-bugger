using SoBugger.Domain.Base;

namespace SoBugger.Domain;

public class BugComment : EntityBase, ICreatored
{
    public Guid BugId { get; set; }
    public Bug? Bug { get; set; }

    public string Content { get; set; } = string.Empty;

    public ICollection<BugCommentAttachment> BugCommentAttachments = new List<BugCommentAttachment>();
    public Guid CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
}