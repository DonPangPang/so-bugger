using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.Shared.Parameters;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Extensions;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers.Platform;

public class FileResourceController : ApiControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public FileResourceController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetList(FileResourceParameters parameters)
    {
        var res = await _unitOfWork.Query<FileResource>()
            .MapTo<FileResourceDto>().QueryAsync(parameters);

        return Ok(res);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var res = await _unitOfWork.Query<FileResource>()
            .MapTo<FileResourceDto>().FirstOrDefaultAsync(x => x.Id == id);

        return Ok(res);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var entity = await _unitOfWork.Query<FileResource>().FirstOrDefaultAsync(x => x.Id == id);

        if (entity is null)
        {
            return Ok();
        }

        _unitOfWork.Set<FileResource>().Remove(entity);

        var res = await _unitOfWork.CommitAsync();

        return Ok(res);
    }


    [HttpPost]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", file.FileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        if (file == null || file.Length == 0)
        {
            return BadRequest("No file uploaded.");
        }

        var fileResource = new FileResource
        {
            Name = Path.GetFileNameWithoutExtension(file.FileName),
            Path = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", file.FileName),
            Suffix = Path.GetExtension(file.FileName),
            Size = file.Length,
            ContentType = file.ContentType,
            Uri = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", file.FileName),
        };

        _unitOfWork.Set<FileResource>().Add(fileResource);
        await _unitOfWork.CommitAsync();

        return Ok("File uploaded successfully.");
    }
}
