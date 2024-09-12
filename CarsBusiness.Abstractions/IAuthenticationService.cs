namespace CarsBusiness.Abstractions;

public interface IAuthenticationService
{
    string CreatePasswordHash(string password);
}