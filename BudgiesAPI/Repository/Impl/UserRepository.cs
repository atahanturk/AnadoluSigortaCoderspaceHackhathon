using BudgiesAPI.Data;
using BudgiesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgiesAPI.Repository.Impl;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }

    public async Task AddUserAsync(IUserModel user)
    {
        _context.Add(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task<IUserModel?> FindByTcNoAsync(string tcNo)
    {
        // Öncelikle Customer tablosunda arama yap
        var customer = await _context.Customers.FirstOrDefaultAsync(c => c.TcNo == tcNo);
        if (customer != null)
        {
            return customer;
        }

        // Customer bulunamazsa, Admin tablosunda arama yap
        var admin = await _context.Admins.FirstOrDefaultAsync(a => a.TcNo == tcNo);
        return admin; // Admin bulunursa döndür, bulunamazsa null döndür
    }
    
    public async Task<IEnumerable<IUserModel>> GetAllUsersAsync()
    {
        // Customer ve Admin tablolarından tüm kullanıcıları getir
        var customers = await _context.Customers.Include(c => c.HealthPolicies)
            .Include(c => c.HomePolicies)
            .Include(c => c.PetPolicies)
            .ToListAsync();

        return customers;
    }

}