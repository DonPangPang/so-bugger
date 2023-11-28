using SoBugger.Shared.Base;

namespace SoBugger.Shared.Dtos.Platform;

public record RoleDto : ViewModel
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public List<string> ScopeList { get; set; } = new();

    public ICollection<UserDto> Users { get; set; } = new List<UserDto>();

    public Guid? ModifyerId { get; set; }
    public UserDto? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool Deleted { get; set; } = false;
}
