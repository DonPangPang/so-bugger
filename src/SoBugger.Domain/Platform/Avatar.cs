using System.ComponentModel.DataAnnotations.Schema;

namespace SoBugger.Domain.Platform;

public class Avatar : FileResource
{
    public Guid? UserId { get; set; }

    public User? User { get; set; }
}