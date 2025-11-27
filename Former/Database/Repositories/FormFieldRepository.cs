using Former.Database.Repositories.Interfaces;
using Former.Dtos.FormFields;
using Former.Mappers;
using Former.Models;
using Microsoft.EntityFrameworkCore;

namespace Former.Database.Repositories;

public class FormFieldRepository : IFormFieldRepository
{
    public FormFieldRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<FormField>> GetAllFormFields()
    {
        var formFields = await _context.FormFields.OrderBy(ff => ff.Id).ToListAsync();
        
        return formFields;
    }

    public async Task<FormField?> GetFormFieldByIdAsync(ulong id)
    {
        var formField = await _context.FormFields.FirstOrDefaultAsync(ff => ff.Id == id);
        
        return formField;
    }

    public async Task<List<FormField>> GetFormFieldsForUserAsync(string userId)
    {
        var formFields = await _context.FormFields.
            Where(ff => ff.User.Id.Equals(userId)).
            OrderBy(ff => ff.Id).
            ToListAsync();
        
        return formFields;
    }
    
    public async Task<FormField> CreateFormFieldAsync(CreateFormFieldDto createFormFielddto)
    {
        var formField = createFormFielddto.MapToFormField();
        
        await _context.FormFields.AddAsync(formField);
        
        await _context.SaveChangesAsync();
        return formField;
    }
    
    public async Task<FormField?> UpdateFormFieldAsync(ulong id, UpdateFormFieldDto updateFormdto)
    {
        var formFieldToUpdate = await _context.FormFields.FirstOrDefaultAsync(ff => ff.Id == id);
        
        if(formFieldToUpdate == null) return null;

        var formField = updateFormdto.MapToFormField(formFieldToUpdate);
        
        await _context.SaveChangesAsync();
        
        return formField;
    }

    public async Task<bool> DeleteFormFieldAsync(ulong id)
    {
        var formFieldToDelete = await GetFormFieldByIdAsync(id);
        if (formFieldToDelete == null) 
            return false;
        
        _context.FormFields.Remove(formFieldToDelete);
        
        await _context.SaveChangesAsync();
        return true;
    }
    
    private readonly AppDbContext _context;
}