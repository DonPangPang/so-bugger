using SoBugger.Domain.Base;

namespace SoBugger.Domain;

public class BugRequirement : Requirement
{
    public Guid BugId { get; set; }
    public Bug? Bug { get; set; }
}