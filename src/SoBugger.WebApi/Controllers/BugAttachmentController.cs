using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugAttachmentController(IUnitOfWork unitOfWork) : ApiControllerBase<BugAttachment, BugAttachmentDto, BugAttachmentParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugAttachmentParameters parameters)
    {
        throw new NotImplementedException();
    }
}