using AutoMapper;
using SoBugger.Domain;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.WebApi.Profiles;

public class GlobalProfile : Profile
{
    public GlobalProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
        CreateMap<FileResource, FileResourceDto>().ReverseMap();

        CreateMap<Bug, BugDto>().ReverseMap();
        CreateMap<BugAttachment, BugAttachmentDto>().ReverseMap();
        CreateMap<BugComment, BugCommentDto>().ReverseMap();
        CreateMap<BugCommentAttachment, BugCommentAttachmentDto>().ReverseMap();
        CreateMap<BugDetail, BugDetailDto>().ReverseMap();
        CreateMap<BugHistory, BugHistoryDto>().ReverseMap();
        CreateMap<BugLevel, BugLevelDto>().ReverseMap();
        CreateMap<BugRequirement, BugRequirementDto>().ReverseMap();
        CreateMap<BugResult, BugResultDto>().ReverseMap();
        CreateMap<BugType, BugTypeDto>().ReverseMap();
        CreateMap<Project, ProjectDto>().ReverseMap();
        CreateMap<ProjectAssignment, ProjectAssignmentDto>().ReverseMap();
        CreateMap<ProjectRequirement, ProjectRequirementDto>().ReverseMap();
        CreateMap<ProjectVersion, ProjectVersionDto>().ReverseMap();
        CreateMap<TodoAssignment, TodoAssignmentDto>().ReverseMap();
        CreateMap<TodoGroup, TodoGroupDto>().ReverseMap();
        CreateMap<TodoTag, TodoTagDto>().ReverseMap();
    }
}