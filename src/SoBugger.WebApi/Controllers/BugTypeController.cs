using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugTypeController(IUnitOfWork unitOfWork) : ApiControllerBase<BugType, BugTypeDto, BugTypeParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugTypeParameters parameters)
    {
        throw new NotImplementedException();
    }
}