namespace Former.Dtos.Users;

public class LoginUserDto :  UserBaseDto
{
    public required string Password { get; set; }
}