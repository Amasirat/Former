using Former.Database.Repositories.Interfaces;
using Former.Dtos.Forms;
using Former.Mappers;
using Former.Models;
using Microsoft.EntityFrameworkCore;

namespace Former.Database.Repositories;

public class FormRepository : IFormRepository
{
    public FormRepository(AppDbContext context)
    {
        _context = context;
    }
    // Currently a very expensive Form Getter for testing purposes.
    // A QueryBuilder might be necessary to access filtered data
    public async Task<List<Form>> GetAllFormsAsync()
    {
        var forms = await _context.Forms.OrderBy(f => f.Id).ToListAsync();
        
        return forms;
    }
    
    // TODO: GetFormsForUserAsync method (Needs User DTO)
    
    public async Task<Form?> GetFormByIdAsync(ulong id)
    {
        var form = await _context.Forms.FindAsync(id);
        
        return form ?? null;
    }

    public async Task<Form> CreateFormAsync(CreateFormDto createFormDto)
    {
        var newForm = createFormDto.MapToForm();
        
        await _context.Forms.AddAsync(newForm);
        await _context.SaveChangesAsync();
        return newForm;
    }
    
    // TODO
    public Task<Form> UpdateFormAsync(UpdateFormDto form)
    {
        throw new NotImplementedException();
    }
    
    private AppDbContext _context;
}