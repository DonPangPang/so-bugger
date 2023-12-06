using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugCommentAttachmentController(IUnitOfWork unitOfWork) : ApiControllerBase<BugCommentAttachment, BugCommentAttachmentDto, BugCommentAttachmentParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(BugCommentAttachmentParameters parameters)
    {
        var result = await _unitOfWork.Query<BugCommentAttachment>().QueryAsync(parameters);

        return Ok(result);
    }
}