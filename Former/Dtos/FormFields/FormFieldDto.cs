using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Dtos.Users;
using Former.Models;

namespace Former.Dtos.FormFields;

public class FormFieldDto : FormFieldBaseDto
{
    public UserDto? Owner { get; set; }
    
    public JsonObject? UiConfig { get; set; }
    
    public required DateTime CreatedAt { get; set; }
    
    public required DateTime UpdatedAt { get; set; }
}