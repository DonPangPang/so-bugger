using SoBugger.Shared.Base;
using SoBugger.Shared.Enums;

namespace SoBugger.Shared.Dtos.Platform;

public record UserDto : ViewModel
{
    public string Account { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }

    public Guid? AvatarId { get; set; }
    public FileResourceDto? Avatar { get; set; }

    public UserAccess UserAccess { get; set; } = UserAccess.User;

    public ICollection<RoleDto> Roles { get; set; } = new List<RoleDto>();

    public Guid? ModifyerId { get; set; }
    public UserDto? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool Disabled { get; set; } = false;
    public bool Deleted { get; set; } = false;
}
