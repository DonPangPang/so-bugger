using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Base;
using SoBugger.Shared.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
}

public abstract class ApiControllerBase<TEntity, TViewModel, TParameter>(IUnitOfWork unitOfWork) : ApiControllerBase
    where TEntity : class, IEntity, new()
    where TViewModel : class, IViewModel, new()
    where TParameter : class, IParameter
{
    [HttpGet]
    public abstract Task<IActionResult> GetList(TParameter parameters);

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var res = await unitOfWork.Query<TEntity>()
            .MapTo<TViewModel>().FirstOrDefaultAsync(x => x.Id == id);

        return Ok(res);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TViewModel dto)
    {
        var entity = dto.MapTo<TEntity>();

        unitOfWork.Set<TEntity>().Add(entity);

        var res = await unitOfWork.CommitAsync();

        return Ok(res);
    }

    [HttpPut]
    public async Task<IActionResult> Update(TViewModel dto)
    {
        var entity = await unitOfWork.Query<TEntity>().FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (entity is null)
        {
            return await Add(dto);
        }

        entity.Map(dto);

        unitOfWork.Set<TEntity>().Update(entity);

        var res = await unitOfWork.CommitAsync();

        return Ok(res);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var res = await unitOfWork.Set<TEntity>().Where(x => x.Id == id).ExecuteDeleteAsync() > 0;
        return Ok(res);
    }
}