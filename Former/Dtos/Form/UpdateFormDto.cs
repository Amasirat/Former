using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Models;

namespace Former.Dtos.Forms;

public class UpdateFormDto
{
    [MaxLength(70)]
    public required string Name { get; set; }
    
    public required Form.StatusEnum Status { get; set; }

    public required bool IsAuthorizedLimited { get; set; }

    public Form.LayoutEnum Layout { get; set; }
    
    public JsonObject? UiConfig { get; set; }
    
    [MaxLength(512)]
    public string? Description { get; set; }
    
    public bool IsArchived  { get; set; }
    
    private DateTime UpdatedAt { get; set; } = DateTime.Now;
}