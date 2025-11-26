using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;
using Former.Dtos.Users;
using Former.Models;

namespace Former.Dtos.Forms;

public class FormDto
{
    [MaxLength(50)]
    public required string Name { get; set; }
    
    public required Form.StatusEnum Status { get; set; }
    
    public required bool IsAuthorizedLimited { get; set; }
    
    [MaxLength(512)]
    public string? Description { get; set; }
    
    public Form.LayoutEnum Layout { get; set; }
    
    public required UserDto Owner { get; set; }
    
    public JsonNode? UiConfig { get; set; }
    
    public bool IsArchived { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}