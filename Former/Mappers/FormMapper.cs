using Former.Dtos.Forms;
using Former.Models;

namespace Former.Mappers;

public static class FormMapper
{
    public static Form MapToForm(this CreateFormDto createFormDto)
    {
        return new Form
        {
            Name = createFormDto.Name,
            Description = createFormDto.Description,
            IsAuthorizedLimited = createFormDto.IsAuthorizedLimited,
            Status = createFormDto.Status,
            Layout = createFormDto.Layout,
            User = createFormDto.User,
        };
    }

    public static FormDto MapToFormDto(this Form form)
    {
        return new FormDto
        {
            Name = form.Name,
            Description = form.Description,
            IsAuthorizedLimited = form.IsAuthorizedLimited,
            Status = form.Status,
            Owner = form.User.MapToUserDto(),
            UiConfig = form.UiConfig,
            IsArchived = form.IsArchived,
            CreatedAt = form.CreatedAt,
            UpdatedAt = form.UpdatedAt,
            Layout = form.Layout
        };
    }

    public static Form UpdateFormFromDto(this UpdateFormDto updateFormDto, Form form)
    {
        form.Name = updateFormDto.Name;
        form.Description = updateFormDto.Description;
        form.IsAuthorizedLimited = updateFormDto.IsAuthorizedLimited;
        form.Status = updateFormDto.Status;
        form.Layout = updateFormDto.Layout;
        form.UiConfig = updateFormDto.UiConfig;
        form.IsArchived = updateFormDto.IsArchived;
        
        form.UpdatedAt = DateTime.Now.ToUniversalTime();
        return form;
    }
}