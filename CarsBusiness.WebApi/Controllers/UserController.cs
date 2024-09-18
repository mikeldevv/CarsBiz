using CarsBusiness.Abstractions;
using CarsBusiness.Abstractions.User;
using CarsBusiness.WebApi.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace CarsBusiness.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UserController(IUserService userService, IAuthenticationService authenticationService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<RegisterUserResponseDto>> Register(RegisterUserRequestDto registerUserDto)
    {
        var hashedPassword = authenticationService.CreatePasswordHash(registerUserDto.Password);

        var createdUser = await userService.Register(registerUserDto.FirstName, registerUserDto.LastNAme,
            registerUserDto.EmailAddress, registerUserDto.UserNAme, hashedPassword);

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