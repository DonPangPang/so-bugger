using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectAssignmentController(IUnitOfWork unitOfWork) : ApiControllerBase<ProjectAssignment, ProjectAssignmentDto, ProjectAssignmentParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(ProjectAssignmentParameters parameters)
    {
        var result = await _unitOfWork.Query<ProjectAssignment>().QueryAsync(parameters);

        return Ok(result);
    }
}