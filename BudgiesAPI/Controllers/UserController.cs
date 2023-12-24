using System.Security.Claims;
using BudgiesAPI.Services;
using Microsoft.AspNetCore.Mvc;
using BudgiesAPI.DTO;
using BudgiesAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace BudgiesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(CustomerRegistrationDto registrationDto)
    {
        registrationDto.NormalizeDateTimesToUtc();
        IUserModel user = CreateUserFromDto(registrationDto);

        await _userService.RegisterUserAsync(user);

        return Ok(); 
    }

    private IUserModel CreateUserFromDto(CustomerRegistrationDto registrationDto)
    {
        return new CustomerModel(
            tcNo: registrationDto.TcNo,
            name: registrationDto.Name,
            surname: registrationDto.Surname,
            city: registrationDto.City,
            address: registrationDto.Address,
            email: registrationDto.Email,
            birthDate: registrationDto.BirthDate,
            gender: registrationDto.Gender,
            password: registrationDto.Password 
        );
    }

    private IUserModel CreateAdminFromDto(AdminRegistrationDto registrationDto)
    {
        return new AdminModel(
            tcNo: registrationDto.TcNo,
            name: registrationDto.Name,
            surname: registrationDto.Surname,
            email: registrationDto.Email,
            password: registrationDto.Password
                );
        
    }

    [HttpPost("register-admin")]
    public async Task<IActionResult> RegisterAdmin(AdminRegistrationDto registrationDto)
    {
        IUserModel admin = CreateAdminFromDto(registrationDto);

        await _userService.RegisterAdminAsync(admin);

        return Ok();
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await _userService.AuthenticateUserAsync(loginDto.TcNo, loginDto.Password);
        if (user == null)
        {
            return Unauthorized("Kullanıcı adı veya şifre yanlış.");
        }

        var token = _userService.GenerateJwtToken(user); // JWT token oluştur
        return Ok(new { token = token, role = user is AdminModel ? "Admin" : "Customer" });
    }
    
    [HttpGet("{tcNo}/policies")]
    public async Task<IActionResult> GetUserPolicies(string tcNo)
    {
        
        var policies = await _userService.GetUserPoliciesAsync(tcNo);
        if (policies == null)
        {
            return NotFound("Kullanıcı bulunamadı.");
        }

        return Ok(policies);
    }
}
