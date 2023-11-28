using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugCommentController(IUnitOfWork unitOfWork) : ApiControllerBase<BugComment, BugCommentDto, BugCommentParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugCommentParameters parameters)
    {
        throw new NotImplementedException();
    }
}