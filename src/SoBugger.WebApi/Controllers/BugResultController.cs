using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugResultController(IUnitOfWork unitOfWork) : ApiControllerBase<BugResult, BugResultDto, BugResultParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugResultParameters parameters)
    {
        throw new NotImplementedException();
    }
}