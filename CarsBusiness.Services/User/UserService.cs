using CarsBusiness.Abstractions.User;
using CarsBusiness.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarsBusiness.Services.User;

public class UserService(UserDbContext dbContext) : IUserService
{
    public async Task<Abstractions.User.User> Register(string firstName, string lastName, string emailAddress, string userName, string passwordHash)
    {
        var newUser = new Abstractions.User.User
        {
            FirstName = firstName,
            LastName = lastName,
            EmailAddress = emailAddress,
            UserName = userName,
            Password = passwordHash
        };
         dbContext.Users.Add(newUser);
         await dbContext.SaveChangesAsync();
         
         return newUser;
    }

    public async Task<Abstractions.User.User?> GetUserByUsername(string userName)
    {
        return await dbContext.Users.SingleOrDefaultAsync(x => x.UserName == userName);
    }
    public async Task<Abstractions.User.User?> GetUserById(long userId)
    {
        return await dbContext.Users.SingleOrDefaultAsync(x => x.UserId == userId);
    }
}