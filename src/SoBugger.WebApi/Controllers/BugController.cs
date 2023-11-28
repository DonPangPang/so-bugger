using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugController(IUnitOfWork unitOfWork) : ApiControllerBase<Bug, BugDto, BugParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    [HttpGet]
    public override async Task<IActionResult> GetList([FromQuery] BugParameters parameters)
    {
        var result = await _unitOfWork.Query<Bug>().QueryAsync(parameters);
        return Ok(result);
    }
}