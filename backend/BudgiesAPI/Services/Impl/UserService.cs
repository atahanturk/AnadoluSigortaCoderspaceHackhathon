using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BudgiesAPI.Data;
using BudgiesAPI.DTO;
using BudgiesAPI.Models;
using BudgiesAPI.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace BudgiesAPI.Services.Impl;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly DataContext _context;

    public UserService(IUserRepository userRepository, DataContext context)
    {
        _userRepository = userRepository;
        _context = context;
    }
    

    public async Task RegisterUserAsync(IUserModel user)
    {
        user.Password = PasswordHasher.HashPassword(user.Password);
        await _userRepository.AddUserAsync(user);
    }
    
    public async Task RegisterAdminAsync(IUserModel admin)
    {
        admin.Password = PasswordHasher.HashPassword(admin.Password);
        await _userRepository.AddUserAsync(admin);
    }
    
    
    public string GenerateJwtToken(IUserModel user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("BudgiesApiicinYeterliUzunluktaBirKey"); // Bu anahtarı güvenli bir yerde saklayın
        
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.TcNo),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user is AdminModel ? "Admin" : "Customer")
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
    
    public async Task<IUserModel> AuthenticateUserAsync(string tcNo, string password)
    {
        var user = await _userRepository.FindByTcNoAsync(tcNo);
        if (user is not null && PasswordHasher.VerifyPassword(password, user.Password))
        {
            return user;
        }

        return null;
    }
    
    public async Task<IEnumerable<IUserModel>> GetAllUsersAsync()
    {
        
        return await _userRepository.GetAllUsersAsync();
    }
    
    public async Task<UserPoliciesDto> GetUserPoliciesAsync(string tcNo)
    {
        var user = await _context.Customers
            .Include(c => c.HealthPolicies)
            .Include(c => c.HomePolicies)
            .Include(c => c.PetPolicies)
            .FirstOrDefaultAsync(c => c.TcNo == tcNo);

        if (user == null)
        {
            return null;
        }

        return new UserPoliciesDto
        {
            HealthPolicies = user.HealthPolicies,
            HomePolicies = user.HomePolicies,
            PetPolicies = user.PetPolicies
        };
    }
    
    


    
}