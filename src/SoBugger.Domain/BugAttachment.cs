using SoBugger.Domain.Base;

namespace SoBugger.Domain;

public class BugAttachment : Attachment
{
    public Guid BugId { get; set; }
    public Bug? Bug { get; set; }
}
