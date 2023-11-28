using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugHistoryController(IUnitOfWork unitOfWork) : ApiControllerBase<BugHistory, BugHistoryDto, BugHistoryParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugHistoryParameters parameters)
    {
        throw new NotImplementedException();
    }
}