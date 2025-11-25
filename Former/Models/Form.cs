using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

namespace Former.Models;
[Table("forms")]
public class Form
{
    [Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public ulong Id { get; set; }
    
    [Column("name"), MaxLength(100)]
    public required string Name { get; set; }
    
    [ForeignKey("user_id")]
    public required User User { get; set; }
        
    public List<FormField> FormFields { get; set; } = new List<FormField>();
    
    [Column("status"), EnumDataType(typeof(StatusEnum))]
    public StatusEnum Status { get; set; }

    [Column("is_authorized_limited")]
    public bool IsAuthorizedLimited { get; set; } = false;
    
    [Column("description"), MaxLength(512)]
    public string? Description { get; set; }
    
    [Column("layout"), EnumDataType(typeof(LayoutEnum))]
    public LayoutEnum Layout { get; set; }
    
    [Column("is_archived")]
    public bool IsArchived { get; set; } = false;
    
    [Column("ui_config", TypeName = "jsonb")]
    public JsonNode? UiConfig { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    
    public enum StatusEnum : byte
    {
        Draft,
        Published
    }

    public enum LayoutEnum
    {
        Ltr,
        Rtl
    }
}