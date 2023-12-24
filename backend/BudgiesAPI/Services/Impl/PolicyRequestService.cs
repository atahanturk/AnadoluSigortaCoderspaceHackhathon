using BudgiesAPI.Data;
using BudgiesAPI.DTO;
using BudgiesAPI.Models;

namespace BudgiesAPI.Services.Impl;

public class PolicyRequestService : IPolicyRequestService
{
    private readonly DataContext _context;

    public PolicyRequestService(DataContext context)
    {
        _context = context;
    }
    
    public async Task<HealthRequestModel> CreateHealthRequestAsync(HealthRequestDto dto)
    {
        var request = new HealthRequestModel
        {
            CustomerTcNo = dto.CustomerTcNo,
            SmokingStatus = dto.SmokingStatus,
            GeneticDisease = dto.GeneticDisease,
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddYears(1),
            Price = CalculateHealthPolicyPrice(dto)
        };
        _context.HealthRequests.Add(request);
        await _context.SaveChangesAsync();

        return request;
    }
    
    public async Task<PetRequestModel> CreatePetRequestAsync(PetRequestDto dto)
    {
        var request = new PetRequestModel
        {
            CustomerTcNo = dto.CustomerTcNo,
            PetAge = dto.PetAge,
            Genus = dto.Genus,
            Species = dto.Species,
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddYears(1),
            Price = CalculatePetPolicyPrice(dto)
        };
        _context.PetRequests.Add(request);
        await _context.SaveChangesAsync();

        return request;
    }
    
    public async Task<HomeRequestModel> CreateHomeRequestAsync(HomeRequestDto dto)
    {
        var request = new HomeRequestModel
        {
            CustomerTcNo = dto.CustomerTcNo,
            HomeType = dto.HomeType,
            HomeAge = dto.HomeAge,
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddYears(1),
            Price = CalculateHomePolicyPrice(dto)
        };
        _context.HomeRequests.Add(request);
        await _context.SaveChangesAsync();

        return request;
    }

    private decimal CalculateHealthPolicyPrice(HealthRequestDto dto)
    {
        return 1000;
    }
    private decimal CalculatePetPolicyPrice(PetRequestDto dto)
    {
        
        return 500; 
    }

    private decimal CalculateHomePolicyPrice(HomeRequestDto dto)
    {

        return 1500;
    }

}