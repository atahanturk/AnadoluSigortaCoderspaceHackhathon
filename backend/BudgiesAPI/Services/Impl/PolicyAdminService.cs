using BudgiesAPI.Data;
using BudgiesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgiesAPI.Services.Impl;

public class PolicyAdminService : IPolicyAdminService
{
    private readonly DataContext _context;

    public PolicyAdminService(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<HealthRequestModel>> GetAllHealthRequestsAsync()
    {
        return await _context.HealthRequests.ToListAsync();
    }

    public async Task ApproveHealthRequestAsync(int requestId)
    {
        var request = await _context.HealthRequests.FindAsync(requestId);
        if (request != null)
        {
            var approvedPolicy = new HealthModel(
                id: 0, 
                startDate: request.StartDate,
                endDate: request.EndDate,
                price: request.Price,
                customerTcNo: request.CustomerTcNo,
                smokingStatus: request.SmokingStatus,
                geneticDisease: request.GeneticDisease
            );
            

            _context.HealthPolicies.Add(approvedPolicy);
            var customer = await _context.Customers.FindAsync(request.CustomerTcNo);
            if (customer != null)
            {
                customer.HealthPolicies.Add(approvedPolicy);
            }
            _context.HealthRequests.Remove(request);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new KeyNotFoundException("Request not found");
        }
    }
    
    public async Task<IEnumerable<PetRequestModel>> GetAllPetRequestsAsync()
    {
        return await _context.PetRequests.ToListAsync();
    }

    public async Task ApprovePetRequestAsync(int requestId)
    {
        var request = await _context.PetRequests.FindAsync(requestId);
        if (request != null)
        {
            var approvedPolicy = new PetModel(
                // ID, veritabanı tarafından otomatik olarak atanan bir değer olabilir
                id: 0, 
                startDate: request.StartDate,
                endDate: request.EndDate,
                price: request.Price,
                customerTcNo: request.CustomerTcNo,
                petAge: request.PetAge,
                genus: request.Genus,
                species: request.Species
            );
            _context.PetPolicies.Add(approvedPolicy);
            var customer = await _context.Customers.FindAsync(request.CustomerTcNo);
            if (customer != null)
            {
                customer.PetPolicies.Add(approvedPolicy);
            }
            _context.PetRequests.Remove(request);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new KeyNotFoundException("Request not found");
        }
    }

    public async Task<IEnumerable<HomeRequestModel>> GetAllHomeRequestsAsync()
    {
        return await _context.HomeRequests.ToListAsync();
    }

    public async Task ApproveHomeRequestAsync(int requestId)
    {
        var request = await _context.HomeRequests.FindAsync(requestId);
        if (request != null)
        {
            var approvedPolicy = new HomeModel(
                id: 0,
                startDate: request.StartDate,
                endDate: request.EndDate,
                price: request.Price,
                customerTcNo: request.CustomerTcNo,
                homeType: request.HomeType,
                homeAge: request.HomeAge
            );
            _context.HomePolicies.Add(approvedPolicy);
            var customer = await _context.Customers.FindAsync(request.CustomerTcNo);
            if (customer != null)
            {
                customer.HomePolicies.Add(approvedPolicy);
            }
            _context.HomeRequests.Remove(request);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new KeyNotFoundException("Request not found");
        }
    }

    
}
