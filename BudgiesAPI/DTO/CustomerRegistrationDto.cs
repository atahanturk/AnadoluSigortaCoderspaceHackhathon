using BudgiesAPI.Models;

namespace BudgiesAPI.DTO;

public class CustomerRegistrationDto
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Surname { get; set; }
    public string TcNo { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
    
    public void NormalizeDateTimesToUtc()
    {
        BirthDate = DateTime.SpecifyKind(BirthDate, DateTimeKind.Utc);
    }
}