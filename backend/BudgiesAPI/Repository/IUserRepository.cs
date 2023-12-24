using BudgiesAPI.Models;

namespace BudgiesAPI.Repository;

public interface IUserRepository
{
    Task AddUserAsync(IUserModel user);
    Task<IUserModel?> FindByTcNoAsync(string tcNo);
    Task<IEnumerable<IUserModel>> GetAllUsersAsync();
}