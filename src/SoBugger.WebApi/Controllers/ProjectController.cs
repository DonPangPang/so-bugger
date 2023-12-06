using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectController(IUnitOfWork unitOfWork) : ApiControllerBase<Project, ProjectDto, ProjectParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(ProjectParameters parameters)
    {
        var result = await _unitOfWork.Query<Project>().QueryAsync(parameters);

        return Ok(result);
    }
}