using System.ComponentModel.DataAnnotations;
using Former.Models;

namespace Former.Dtos.Forms;

public class CreateFormDto
{
    [MaxLength(50)]
    public required string Name { get; set; }
    
    public required User User { get; set; }
    
    public required Form.StatusEnum Status { get; set; }

    public required bool IsAuthorizedLimited { get; set; } = false;

    public Form.LayoutEnum Layout { get; set; } = Form.LayoutEnum.Ltr;
    
    [MaxLength(512)]
    public string? Description { get; set; }
}