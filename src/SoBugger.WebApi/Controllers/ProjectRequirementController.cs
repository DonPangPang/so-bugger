using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectRequirementController(IUnitOfWork unitOfWork) : ApiControllerBase<ProjectRequirement, ProjectRequirementDto, ProjectRequirementParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(ProjectRequirementParameters parameters)
    {
        var result = await _unitOfWork.Query<ProjectRequirement>().QueryAsync(parameters);

        return Ok(result);
    }
}