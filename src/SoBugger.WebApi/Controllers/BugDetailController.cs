using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugDetailController(IUnitOfWork unitOfWork) : ApiControllerBase<BugDetail, BugDetailDto, BugDetailParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugDetailParameters parameters)
    {
        throw new NotImplementedException();
    }
}