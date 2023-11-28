using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers.Platform;

public class RoleController : ApiControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public RoleController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetList(RoleParameters parameters)
    {
        var res = await _unitOfWork.Query<Role>()
            .MapTo<RoleDto>().QueryAsync(parameters);

        return Ok(res);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var res = await _unitOfWork.Query<Role>()
            .MapTo<RoleDto>().FirstOrDefaultAsync(x => x.Id == id);

        return Ok(res);
    }

    [HttpPost]
    public async Task<IActionResult> Add(RoleDto role)
    {
        var entity = role.MapTo<Role>();

        _unitOfWork.Set<Role>().Add(entity);

        var res = await _unitOfWork.CommitAsync();

        return Ok(res);
    }

    [HttpPut]
    public async Task<IActionResult> Update(RoleDto role)
    {
        var entity = await _unitOfWork.Query<Role>().FirstOrDefaultAsync(x => x.Id == role.Id);

        if (entity is null)
        {
            return await Add(role);
        }

        entity.Map(role);

        _unitOfWork.Set<Role>().Update(entity);

        var res = await _unitOfWork.CommitAsync();

        return Ok(res);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var res = await _unitOfWork.Set<Role>().Where(x => x.Id == id).ExecuteDeleteAsync() > 0;
        return Ok(res);
    }
}
