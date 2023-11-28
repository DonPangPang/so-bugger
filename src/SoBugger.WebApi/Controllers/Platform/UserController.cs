using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers.Platform;

public class UserController : ApiControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public UserController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetList(UserParameters parameters)
    {
        var res = await _unitOfWork.Query<User>()
            .MapTo<UserDto>().QueryAsync(parameters);

        return Ok(res);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var res = await _unitOfWork.Query<User>()
            .MapTo<UserDto>().FirstOrDefaultAsync(x => x.Id == id);

        return Ok(res);
    }

    [HttpPost]
    public async Task<IActionResult> Add(UserDto user)
    {
        var entity = user.MapTo<User>();

        _unitOfWork.Set<User>().Add(entity);

        var res = await _unitOfWork.CommitAsync();

        return Ok(res);
    }

    [HttpPut]
    public async Task<IActionResult> Update(UserDto user)
    {
        var entity = await _unitOfWork.Query<User>().FirstOrDefaultAsync(x => x.Id == user.Id);

        if (entity is null)
        {
            return await Add(user);
        }

        entity.Map(user);

        _unitOfWork.Set<User>().Update(entity);

        var res = await _unitOfWork.CommitAsync();

        return Ok(res);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var res = await _unitOfWork.Set<User>().Where(x => x.Id == id).ExecuteDeleteAsync() > 0;
        return Ok(res);
    }
}
