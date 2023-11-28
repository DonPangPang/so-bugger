using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectRequirementController(IUnitOfWork unitOfWork) : ApiControllerBase<ProjectRequirement, ProjectRequirementDto, ProjectRequirementParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(ProjectRequirementParameters parameters)
    {
        throw new NotImplementedException();
    }
}