
using CarsBusiness.Abstractions;

namespace CarsBusiness.Services;

public class AuthenticationService : IAuthenticationService
{
    public string CreatePasswordHash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}