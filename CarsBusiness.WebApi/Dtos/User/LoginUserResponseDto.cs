namespace CarsBusiness.WebApi.Dtos.User;

public class LoginUserResponseDto
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}