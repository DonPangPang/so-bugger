using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class TodoGroupController(IUnitOfWork unitOfWork) : ApiControllerBase<TodoGroup, TodoGroupDto, TodoGroupParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(TodoGroupParameters parameters)
    {
        throw new NotImplementedException();
    }
}