using System.ComponentModel.DataAnnotations.Schema;
using SoBugger.Domain.Base;
using SoBugger.Shared.Enums;

namespace SoBugger.Domain.Platform;

public class User : EntityBase, IModifyer, IDisabled, ISoftDelted
{
    public string Account { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public Gender Gender { get; set; } = Gender.None;

    [ForeignKey(nameof(Avatar))]
    public Guid? AvatarId { get; set; }

    public Avatar? Avatar { get; set; }

    public UserAccess UserAccess { get; set; } = UserAccess.User;

    public ICollection<Role>? Roles { get; set; } = new List<Role>();

    public Guid? ModifyerId { get; set; }
    public User? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool Disabled { get; set; } = false;
    public bool Deleted { get; set; } = false;
}