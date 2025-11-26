using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Dtos.Users;
using Former.Models;

namespace Former.Dtos.FormFields;

public class CreateFormFieldDto
{
    [MaxLength(50)]
    public required string Name { get; set; }
    
    [MaxLength(50)]
    public required string Label { get; set; }
    
    public string? Description { get; set; }
    
    public UserDto? User { get; set; }
    
    public FormField.TypeEnum Type { get; set; }
    
    public bool IsRequired { get; set; } = false;
    
    public JsonNode? FieldOptions { get; set; }
    
    public JsonNode? UiConfig { get; set; }
}