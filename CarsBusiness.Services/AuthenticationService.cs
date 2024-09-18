using CarsBusiness.Abstractions;
using CarsBusiness.Abstractions.User;

namespace CarsBusiness.Services;

public class AuthenticationService(IUserService userService) : IAuthenticationService
{
    public string CreatePasswordHash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public async Task<bool> IsUserAuthenticated(string userName, string password)
    {
        var user = await userService.GetUserByUsername(userName);

        return user != null && BCrypt.Net.BCrypt.Verify(password, user.Password);
    }
}