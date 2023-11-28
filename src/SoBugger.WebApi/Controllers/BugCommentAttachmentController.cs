using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugCommentAttachmentController(IUnitOfWork unitOfWork) : ApiControllerBase<BugCommentAttachment, BugCommentAttachmentDto, BugCommentAttachmentParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(BugCommentAttachmentParameters parameters)
    {
        throw new NotImplementedException();
    }
}