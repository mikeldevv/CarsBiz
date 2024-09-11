using CarsBusiness.Abstractions.User;
using Microsoft.EntityFrameworkCore;

namespace CarsBusiness.Persistence;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
}