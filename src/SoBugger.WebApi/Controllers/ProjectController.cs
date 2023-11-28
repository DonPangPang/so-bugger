using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectController(IUnitOfWork unitOfWork) : ApiControllerBase<Project, ProjectDto, ProjectParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(ProjectParameters parameters)
    {
        throw new NotImplementedException();
    }
}