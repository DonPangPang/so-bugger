using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugTypeController(IUnitOfWork unitOfWork) : ApiControllerBase<BugType, BugTypeDto, BugTypeParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(BugTypeParameters parameters)
    {
        var result = await _unitOfWork.Query<BugType>().QueryAsync(parameters);

        return Ok(result);
    }
}