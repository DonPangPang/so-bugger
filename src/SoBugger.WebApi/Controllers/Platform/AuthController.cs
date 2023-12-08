using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Platform;
using SoBugger.Shared.Dtos.Platform;
using SoBugger.WebApi.Controllers.Base;
using SoBugger.WebApi.Repository;

namespace SoBugger.WebApi.Controllers.Platform;

public class AuthController(IUnitOfWork unitOfWork) : ApiControllerBase
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        if (string.IsNullOrWhiteSpace(loginDto.Account))
        {
            return BadRequest("Account not empty");
        }

        if (string.IsNullOrWhiteSpace(loginDto.Password))
        {
            return BadRequest("Password not empty");
        }

        var res = await _unitOfWork.Query<User>().Where(x => x.Account == loginDto.Account && x.Password == loginDto.Password).AnyAsync();

        if (res)
        {
            return Ok("Login success");
        }
        else
        {
            return BadRequest("Login failed");
        }
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserDto user)
    {
        if (string.IsNullOrWhiteSpace(user.Account))
        {
            return BadRequest("Account not empty");
        }

        if (string.IsNullOrWhiteSpace(user.Password))
        {
            return BadRequest("Password not empty");
        }

        if (user.Password.Length < 8)
        {
            return BadRequest("Password lenght not valid");
        }

        var res = await _unitOfWork.Query<User>().Where(x => x.Account == user.Account).AnyAsync();

        if (res)
        {
            return BadRequest("Account not valid");
        }

        var newUser = new User
        {
            Account = user.Account,
            Password = user.Password,
            Name = user.Name,
            Email = user.Email,
            Phone = user.Phone,
        };

        await _unitOfWork.Set<User>().AddAsync(newUser);

        var result = await _unitOfWork.CommitAsync();

        if (result)
        {
            return Ok("Register success");
        }
        else
        {
            return BadRequest("Register failed");
        }
    }
}
