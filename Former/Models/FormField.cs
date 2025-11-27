using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

namespace Former.Models;

[Table("form_fields")]
public class FormField
{
    [Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public ulong Id { get; set; }
    
    [Column("name"), MaxLength(50)]
    public required string Name { get; set; }
    
    [Column("label"), MaxLength(50)]
    public required string Label { get; set; }
    
    [Column("description"), MaxLength(512)]
    public string? Description { get; set; }
    
    [Column("type"), EnumDataType(typeof(TypeEnum))]
    public TypeEnum Type { get; set; }

    [Column("is_required")] 
    public bool IsRequired { get; set; } = false;

    [ForeignKey("user_id")] 
    public required User User { get; set; }
    
    public List<Form> Forms { get; set; } = new List<Form>();
    
    [Column("field_options", TypeName = "jsonb")]
    public JsonNode? FieldOptions { get; set; }
    
    [Column("ui_config", TypeName = "jsonb")]
    public JsonNode? UiConfig { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    public enum TypeEnum : byte
    {
        Text,
        Number,
        Date,
        DateTime,
        Email,
        Password,
        Radio,
        Checkbox,
        Other
    }
}