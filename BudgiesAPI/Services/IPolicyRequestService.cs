using BudgiesAPI.DTO;
using BudgiesAPI.Models;

namespace BudgiesAPI.Services;

public interface IPolicyRequestService
{
    Task<HealthRequestModel> CreateHealthRequestAsync(HealthRequestDto dto);
    Task<PetRequestModel> CreatePetRequestAsync(PetRequestDto dto);
    Task<HomeRequestModel> CreateHomeRequestAsync(HomeRequestDto dto);


}