using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectVersionController(IUnitOfWork unitOfWork) : ApiControllerBase<ProjectVersion, ProjectVersionDto, ProjectVersionParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(ProjectVersionParameters parameters)
    {
        throw new NotImplementedException();
    }
}