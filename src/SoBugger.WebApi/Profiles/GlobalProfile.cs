using AutoMapper;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos.Platform;

namespace SoBugger.WebApi.Profiles;

public class GlobalProfile : Profile
{
    public GlobalProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
        CreateMap<FileResource, FileResourceDto>().ReverseMap();
    }
}
