using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class TodoAssignmentController(IUnitOfWork unitOfWork) : ApiControllerBase<TodoAssignment, TodoAssignmentDto, TodoAssignmentParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(TodoAssignmentParameters parameters)
    {
        throw new NotImplementedException();
    }
}