namespace CarsBusiness.Abstractions;

public interface IAuthenticationService
{
    string CreatePasswordHash(string password);
    Task<bool> IsUserAuthenticated(string userName, string password);
}