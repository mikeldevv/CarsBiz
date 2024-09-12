namespace CarsBusiness.WebApi.Dtos;

public class RegisterUserRequestDto
{
    public required string FirstName { get; set; }
    public required string LastNAme { get; set; }
    public required string EmailAddress { get; set; }
    public required string UserNAme { get; set; }
    public required string Password { get; set; }
}