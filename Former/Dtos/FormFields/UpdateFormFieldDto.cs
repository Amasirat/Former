using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace Former.Dtos.FormFields;

public class UpdateFormFieldDto
{
    [MaxLength(50)]
    public required string Name { get; set; }
    
    [MaxLength(50)]
    public required string Label { get; set; }
    
    [MaxLength(50)]
    public string? Description { get; set; }
    
    public bool IsRequired { get; set; }
    
    public JsonNode? FieldOptions { get; set; }
    
    public JsonNode? UiConfig { get; set; }
}