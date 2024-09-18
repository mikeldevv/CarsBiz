using CarsBusiness.Abstractions;
using CarsBusiness.WebApi.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace CarsBusiness.WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController(IAuthenticationService authenticationService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<LoginUserResponseDto>> Login(LoginUserRequestDto loginRequest)
    {
        var isAuthenticated = await authenticationService.IsUserAuthenticated(loginRequest.Username, loginRequest.Password);

        if (isAuthenticated)
        {
            return Ok("Successful");
        }

        return Unauthorized("Invalid Username/Password");
    }
}