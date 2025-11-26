using Former.Dtos.Users;
using Former.Models;

namespace Former.Mappers;

public static class UserMapper
{
    public static User MapToUser(this UserDto dto)
    {
        return new User
        {
            UserName = dto.UserName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            NormalizedEmail = dto.Email.ToUpper(),
            NormalizedUserName = dto.UserName.ToUpper(),
            EmailConfirmed = dto.EmailConfirmed
        };
    }

    public static UserDto MapToUserDto(this User user)
    {
        return new UserDto()
        {
            UserName = user.UserName ?? string.Empty,
            Email = user.Email ?? string.Empty,
            PhoneNumber = user.PhoneNumber ?? string.Empty,
            EmailConfirmed = user.EmailConfirmed
        };
    }
}