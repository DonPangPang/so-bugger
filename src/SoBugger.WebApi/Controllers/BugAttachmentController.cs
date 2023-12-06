using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class BugAttachmentController(IUnitOfWork unitOfWork) : ApiControllerBase<BugAttachment, BugAttachmentDto, BugAttachmentParameters>(unitOfWork)
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public override async Task<IActionResult> GetList(BugAttachmentParameters parameters)
    {
        var result = await _unitOfWork.Query<BugAttachment>().QueryAsync(parameters);

        return Ok(result);
    }
}