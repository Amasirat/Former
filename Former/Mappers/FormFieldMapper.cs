using Former.Dtos.FormFields;
using Former.Dtos.Users;
using Former.Models;

namespace Former.Mappers;

public static class FormFieldMapper
{
    public static FormField MapToFormField(this CreateFormFieldDto createDto)
    {
        return new FormField
        {
            Name = createDto.Name,
            Label = createDto.Label,
            FieldOptions = createDto.FieldOptions,
            // if User is null in Dto, then null will be given.
            // Nullability is intended feature, refer to Docs
            User = createDto.User,
            Description = createDto.Description,
            IsRequired = createDto.IsRequired,
            Type = createDto.Type,
            UiConfig = createDto.UiConfig
        };
    }

    public static FormField MapToFormField(this UpdateFormFieldDto updateDto, FormField formField)
    {
        return new FormField
        {
            Name = updateDto.Name,
            Label = updateDto.Label,
            FieldOptions = updateDto.FieldOptions,
            User = formField.User,
            Description = updateDto.Description,
            IsRequired = updateDto.IsRequired,
            Type = updateDto.Type,
            UiConfig = updateDto.UiConfig
        };
    }

    public static FormFieldDto MapToFormFieldDto(this FormField formField)
    {
        return new FormFieldDto()
        {
            Name = formField.Name,
            Label = formField.Label,
            FieldOptions = formField.FieldOptions,
            Owner = formField.User.MapToUserDto(),
            Description = formField.Description,
            IsRequired = formField.IsRequired,
            Type = formField.Type,
            CreatedAt = formField.CreatedAt,
            UpdatedAt = formField.UpdatedAt
        };
    }
}