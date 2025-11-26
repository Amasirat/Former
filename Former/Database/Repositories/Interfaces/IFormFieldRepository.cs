using Former.Dtos.FormFields;
using Former.Dtos.Forms;
using Former.Models;

namespace Former.Database.Repositories.Interfaces;

public interface IFormFieldRepository
{
    Task<List<FormField>> GetAllFormFields();
    
    Task<FormField?> GetFormFieldByIdAsync(ulong id);
    
    Task<List<FormField>> GetFormFieldsForUserAsync(string userId);
    
    Task<FormField> CreateFormFieldAsync(CreateFormFieldDto createFormdto);
    
    Task<Form?> UpdateFormFieldAsync(ulong id, UpdateFormFieldDto updateFormdto);
    
    Task<bool> DeleteFormFieldAsync(ulong id);
}