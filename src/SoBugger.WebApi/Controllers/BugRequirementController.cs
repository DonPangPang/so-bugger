using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugRequirementController(IUnitOfWork unitOfWork)
    : ApiControllerBase<BugRequirement, BugRequirementDto, BugRequirementParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugRequirementParameters parameters)
    {
        throw new NotImplementedException();
    }
}