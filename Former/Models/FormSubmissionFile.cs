using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Former.Models;

[Table("form_submission_files")]
public class FormSubmissionFile
{
    [Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public ulong Id { get; set; }
    
    [ForeignKey("submission_id")]
    public required FormSubmission FormSubmission { get; set; }
    
    [Column("file_name")]
    public required string FileName { get; set; }
    
    [Column("file_directory")]
    public required string FileDirectory { get; set; }
    
    [Column("content_type"), EnumDataType(typeof(ContentTypeEnum))]
    public required ContentTypeEnum ContentType { get; set; }
    
    [Column("content_format")]
    public required string ContentFormat { get; set; }
    
    [Column("content_size")] // In KB
    public required uint ContentSize { get; set; }
    
    [Column("uploaded_at")]
    public DateTime UploadedAt { get; set; } = DateTime.Now.ToUniversalTime();
    public enum ContentTypeEnum : byte
    {
        Video,
        Image,
        Audio,
        Pdf,
        Other
    }
}