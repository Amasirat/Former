using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using Former.Dtos.Users;
using Former.Models;

namespace Former.Dtos.FormFields;

public class CreateFormFieldDto : FormFieldBaseDto
{
    public JsonNode? UiConfig { get; set; }
    
    public User? User { get; set; }
}