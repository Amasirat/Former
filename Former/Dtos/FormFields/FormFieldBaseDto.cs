using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Models;

namespace Former.Dtos.FormFields;

public abstract class FormFieldBaseDto
{
    [MaxLength(50)]
    public required string Name { get; set; }
    
    [MaxLength(50)]
    public required string Label { get; set; }
    
    public FormField.TypeEnum Type { get; set; }
    
    [MaxLength(512)]
    public string? Description { get; set; }
    
    public bool IsRequired { get; set; }
    
    public JsonNode? FieldOptions { get; set; }
}