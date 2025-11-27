using System.ComponentModel.DataAnnotations;

namespace Former.Dtos.Users;

public class UserDto : UserBaseDto
{
    public bool EmailConfirmed { get; set; }
}