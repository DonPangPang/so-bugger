using Microsoft.AspNetCore.Mvc;
using SoBugger.Domain;
using SoBugger.Shared.Dtos;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers;

public class TodoTagController(IUnitOfWork unitOfWork) : ApiControllerBase<TodoTag, TodoTagDto, TodoTagParameters>(unitOfWork)
{
    public override Task<IActionResult> GetList(TodoTagParameters parameters)
    {
        throw new NotImplementedException();
    }
}