using SoBugger.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoBugger.Domain.Platform;

public class Role : EntityBase, IModifyer, ISoftDelted
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public string Scope { get; set; } = string.Empty;

    private List<string>? _scope = null;

    [NotMapped]
    public List<string> ScopeList
    {
        get
        {
            if (_scope is null)
            {
                _scope = Scope.Split(',').ToList();
            }
            return _scope;
        }
        set
        {
            Scope = string.Join(',', value);
            _scope = value;
        }
    }

    public ICollection<User> Users { get; set; } = new List<User>();

    public Guid? ModifyerId { get; set; }
    public User? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool Deleted { get; set; } = false;
}