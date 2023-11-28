using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class ProjectAssignmentController(IUnitOfWork unitOfWork) : ApiControllerBase<ProjectAssignment, ProjectAssignmentDto, ProjectAssignmentParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(ProjectAssignmentParameters parameters)
    {
        throw new NotImplementedException();
    }
}