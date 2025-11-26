using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Models;

namespace Former.Dtos.FormFields;

public class FormFieldDto
{
    [MaxLength(70)]
    public required string Name { get; set; }
    
    [MaxLength(70)]
    public required string Label { get; set; }
    
    public FormField.TypeEnum Type { get; set; }
    
    [MaxLength(512)]
    public string? Description { get; set; }
    
    public bool IsRequired { get; set; }
    
    public JsonObject? FieldOptions { get; set; }
    
    public JsonObject? UiConfig { get; set; }

    public User? Owner { get; set; }
    
    public required DateTime CreatedAt { get; set; }
    
    public required DateTime UpdatedAt { get; set; }
}