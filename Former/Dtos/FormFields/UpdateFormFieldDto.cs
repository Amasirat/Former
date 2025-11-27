using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace Former.Dtos.FormFields;

public class UpdateFormFieldDto : FormFieldBaseDto
{
    public JsonObject? UiConfig { get; set; }
}