using SoBugger.Domain.Base;

namespace SoBugger.Domain;

public class BugCommentAttachment : Attachment
{
    public Guid BugCommentId { get; set; }
    public BugComment? BugComment { get; set; }
}