using BudgiesAPI.DTO;
using BudgiesAPI.Models;

namespace BudgiesAPI.Services;

public interface IUserService
{
    Task RegisterUserAsync(IUserModel user);
    Task RegisterAdminAsync(IUserModel admin);
    Task<IUserModel> AuthenticateUserAsync(string tcNo, string password);
    string GenerateJwtToken(IUserModel user);
    Task<IEnumerable<IUserModel>> GetAllUsersAsync();
    Task<UserPoliciesDto> GetUserPoliciesAsync(string tcNo);
}