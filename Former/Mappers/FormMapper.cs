using System.Text.Json.Nodes;
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
            Owner = form.User,
            UiConfig = form.UiConfig,
            IsArchived = form.IsArchived,
            CreatedAt = form.CreatedAt,
            UpdatedAt = form.UpdatedAt,
            Layout = form.Layout
        };
    }
}