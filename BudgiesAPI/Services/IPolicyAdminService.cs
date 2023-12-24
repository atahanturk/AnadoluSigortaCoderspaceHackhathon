using BudgiesAPI.Models;

namespace BudgiesAPI.Services;

public interface IPolicyAdminService
{
    Task<IEnumerable<HealthRequestModel>> GetAllHealthRequestsAsync();
    Task ApproveHealthRequestAsync(int requestId);
    Task<IEnumerable<PetRequestModel>> GetAllPetRequestsAsync();
    Task ApprovePetRequestAsync(int requestId);
    Task<IEnumerable<HomeRequestModel>> GetAllHomeRequestsAsync();
    Task ApproveHomeRequestAsync(int requestId);
}