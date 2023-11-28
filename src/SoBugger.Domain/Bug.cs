using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.Domain;

public class Bug : EntityBase, ISoftDelted, IDisabled, ICreatored, IModifyer
{
    public long Code { get; set; }

    public Guid BugTypeId { get; set; }
    public BugType? BugType { get; set; }

    public Guid BugLevelId { get; set; }
    public BugLevel? BugLevel { get; set; }

    /// <summary>
    /// 确认bug
    /// </summary>
    public bool Ask { get; set; } = false;

    public string Title { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }

    public ICollection<ProjectVersion> ProjectVersions { get; set; } = new List<ProjectVersion>();

    public Guid BugStateId { get; set; }
    public BugState? BugState { get; set; }

    public Guid? AssignUserId { get; set; }
    public User? AssignUser { get; set; }

    public Guid? BugResultId { get; set; }
    public BugResult? BugResult { get; set; }

    public Guid BugDetailId { get; set; }
    public BugDetail? BugDetail { get; set; }

    public ICollection<BugHistory> BugHistories { get; set; } = new List<BugHistory>();

    /// <summary>
    /// 项目需求
    /// </summary>
    public ICollection<ProjectRequirement> ProjectRequirements { get; set; } = new List<ProjectRequirement>();

    /// <summary>
    /// 任务
    /// </summary>
    public ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();

    /// <summary>
    /// 附件
    /// </summary>
    public ICollection<BugAttachment> BugAttachments { get; set; } = new List<BugAttachment>();

    /// <summary>
    /// bug需求
    /// </summary>
    public ICollection<BugRequirement> BugRequirements { get; set; } = new List<BugRequirement>();

    /// <summary>
    /// 备注
    /// </summary>
    public ICollection<BugComment> BugComments { get; set; } = new List<BugComment>();

    /// <summary>
    /// 链接的bug
    /// </summary>
    public ICollection<Bug> Links { get; set; } = new List<Bug>();

    /// <summary>
    /// 抄送人
    /// </summary>
    public ICollection<User> CarbonCopyUsers { get; set; } = new List<User>();

    public string? Keywords { get; set; }

    public Guid CreatorId { get; set; }
    public User? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Disabled { get; set; }
    public bool Deleted { get; set; }
    public Guid? ModifyerId { get; set; }
    public User? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
}