using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.Shared.Dtos.Base;

public record AssignmentDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifyerId { get; set; }
    public UserDto? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool Deleted { get; set; }
}