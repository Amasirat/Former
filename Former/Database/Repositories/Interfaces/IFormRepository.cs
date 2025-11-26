using Former.Dtos.Forms;
using Former.Models;

namespace Former.Database.Repositories.Interfaces;

public interface IFormRepository
{
    Task<List<Form>> GetAllFormsAsync();
    
    Task<Form?> GetFormByIdAsync(ulong id);

    Task<List<Form>> GetFormsForUserAsync(string userId);

    Task<Form> CreateFormAsync(CreateFormDto createFormdto);

    Task<Form?> UpdateFormAsync(ulong id, UpdateFormDto updateFormDto);
}