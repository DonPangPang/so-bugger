using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugLevelController(IUnitOfWork unitOfWork) : ApiControllerBase<BugLevel, BugLevelDto, BugLevelParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugLevelParameters parameters)
    {
        throw new NotImplementedException();
    }
}