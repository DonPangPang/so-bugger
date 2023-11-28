using SoBugger.Shared.Base;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.Shared.Enums;

namespace SoBugger.Shared.Dtos;

public record BugDto : ViewModel
{
    public long Code { get; set; }

    public Guid BugTypeId { get; set; }
    public BugTypeDto? BugType { get; set; }

    public Guid BugLevelId { get; set; }
    public BugLevelDto? BugLevel { get; set; }

    /// <summary>
    /// ȷ��bug
    /// </summary>
    public bool Ask { get; set; } = false;

    public string Title { get; set; } = string.Empty;

    public Guid ProjectId { get; set; }
    public ProjectDto? Project { get; set; }

    public List<ProjectVersionDto> ProjectVersions { get; set; } = new List<ProjectVersionDto>();

    public Guid BugStateId { get; set; }
    public BugState BugState { get; set; } = BugState.None;

    public Guid? AssignUserId { get; set; }
    public UserDto? AssignUser { get; set; }

    public Guid? BugResultId { get; set; }
    public BugResultDto? BugResult { get; set; }

    public Guid BugDetailId { get; set; }
    public BugDetailDto? BugDetail { get; set; }

    /// <summary>
    /// ��Ŀ����
    /// </summary>
    public List<ProjectRequirementDto> ProjectRequirements { get; set; } = new List<ProjectRequirementDto>();

    /// <summary>
    /// ����
    /// </summary>
    public List<ProjectAssignmentDto> ProjectAssignments { get; set; } = new List<ProjectAssignmentDto>();

    /// <summary>
    /// ����
    /// </summary>
    public List<BugAttachmentDto> BugAttachments { get; set; } = new List<BugAttachmentDto>();

    /// <summary>
    /// bug����
    /// </summary>
    public List<BugRequirementDto> BugRequirements { get; set; } = new List<BugRequirementDto>();

    /// <summary>
    /// ��ע
    /// </summary>
    public List<BugCommentDto> BugComments { get; set; } = new List<BugCommentDto>();

    /// <summary>
    /// ���ӵ�bug
    /// </summary>
    public List<BugDto> Links { get; set; } = new List<BugDto>();

    /// <summary>
    /// ������
    /// </summary>
    public List<UserDto> CarbonCopyUsers { get; set; } = new List<UserDto>();

    public string? Keywords { get; set; }

    public Guid CreatorId { get; set; }
    public UserDto? Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Disabled { get; set; }
    public bool Deleted { get; set; }
    public Guid? ModifyerId { get; set; }
    public UserDto? Modifyer { get; set; }
    public DateTime? ModifiedAt { get; set; }
}