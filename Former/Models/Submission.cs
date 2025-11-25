using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

namespace Former.Models;

[Table("submissions")]
public class Submission
{
    [Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public ulong Id { get; set; }
    
    [ForeignKey("user_id")]
    public User? User { get; set; }
    
    [ForeignKey("form_id")]
    public required Form Form { get; set; }
    
    [Column("submission_data", TypeName = "jsonb")]
    public required JsonNode SubmissionData { get; set; }
    
    public List<SubmissionFile> SubmissionFiles { get; set; } = new List<SubmissionFile>();
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
}