using System.ComponentModel.DataAnnotations;

namespace Former.Dtos.Users;

public class UserDto
{
    [MaxLength(50)]
    public required string UserName { get; set; }
    
    [MaxLength(50)]
    public required string Email { get; set; }
    
    [MaxLength(16)]
    public required string PhoneNumber { get; set; }
    
    public bool EmailConfirmed { get; set; }
}