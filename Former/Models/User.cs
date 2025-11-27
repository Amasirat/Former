using Microsoft.AspNetCore.Identity;

namespace Former.Models;

public class User : IdentityUser
{
    public List<Form> Forms { get; set; }
    public List<FormField> FormFields { get; set; }
    public List<FormSubmission> Submissions { get; set; }
}