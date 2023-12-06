using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugRequirementController(IUnitOfWork unitOfWork)
    : ApiControllerBase<BugRequirement, BugRequirementDto, BugRequirementParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(BugRequirementParameters parameters)
    {
        var result = await _unitOfWork.Query<BugRequirement>().QueryAsync(parameters);

        return Ok(result);
    }
}