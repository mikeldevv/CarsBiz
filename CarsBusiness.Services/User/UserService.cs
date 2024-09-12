using CarsBusiness.Abstractions;
using CarsBusiness.Abstractions.User;
using CarsBusiness.Persistence;

namespace CarsBusiness.Services.User;

public class UserService(UserDbContext dbContext, IAuthenticationService authenticationService) : IUserService
{
    public async Task<Abstractions.User.User> Register(string firstName, string lastName, string emailAddress, string userName, string passwordHash)
    {
        var hashedPassword = authenticationService.CreatePasswordHash(passwordHash);
        var newUser = new Abstractions.User.User
        {
            FirstName = firstName,
            LastName = lastName,
            EmailAddress = emailAddress,
            UserName = userName,
            Password = hashedPassword
        };
         dbContext.Users.Add(newUser);
         await dbContext.SaveChangesAsync();
         
         return newUser;
    }
}