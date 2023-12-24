using BudgiesAPI.Models;

namespace BudgiesAPI.DTO;

public class UserPoliciesDto
{
    public IEnumerable<HealthModel> HealthPolicies { get; set; }
    public IEnumerable<HomeModel> HomePolicies { get; set; }
    public IEnumerable<PetModel> PetPolicies { get; set; }
}