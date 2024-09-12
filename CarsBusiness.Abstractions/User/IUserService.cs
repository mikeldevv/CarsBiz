namespace CarsBusiness.Abstractions.User;

public interface IUserService
{
    Task<User> Register(string firstName, string lastName, string emailAddress, string userName, string passwordHash);
}