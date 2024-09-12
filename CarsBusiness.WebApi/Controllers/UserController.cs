using CarsBusiness.Abstractions.User;
using CarsBusiness.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CarsBusiness.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<RegisterUserResponseDto>> Register(RegisterUserRequestDto registerUserDto)
    {
        var createdUser = await userService.Register(registerUserDto.FirstName, registerUserDto.LastNAme,
            registerUserDto.EmailAddress, registerUserDto.UserNAme, registerUserDto.Password);

        var user = new RegisterUserResponseDto
        {
            UserId = createdUser.UserId,
            FirstName = createdUser.FirstName,
            LastName = createdUser.LastName,
            EmailAddress = createdUser.EmailAddress,
            UserName = createdUser.UserName
        };

        return CreatedAtAction(nameof(Register), user);
    }
}