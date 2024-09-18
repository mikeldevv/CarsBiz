namespace CarsBusiness.WebApi.Dtos.User;

public class RegisterUserResponseDto
{
    public long UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
}