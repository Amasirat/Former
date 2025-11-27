using System.ComponentModel.DataAnnotations;

namespace Former.Dtos.Users;

public class CreateUserDto : UserBaseDto
{
    [MaxLength(70)]
    public required string Password { get; set; }
    
    [MaxLength(70), Compare("Password")]
    public required string PasswordConfirmation { get; set; }
}