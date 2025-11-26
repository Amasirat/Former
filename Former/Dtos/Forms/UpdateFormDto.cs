using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Models;

namespace Former.Dtos.Forms;

public class UpdateFormDto : CreateFormDto
{
    public JsonObject? UiConfig { get; set; }
    
    public bool IsArchived  { get; set; }
}