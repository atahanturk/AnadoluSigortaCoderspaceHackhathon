namespace BudgiesAPI.Models;

public class CustomerModel : IUserModel
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
    public ICollection<HealthModel>? HealthPolicies { get; set; }
    public ICollection<HomeModel>? HomePolicies { get; set; }
    public ICollection<PetModel>? PetPolicies { get; set; }
    
    
    public CustomerModel(string tcNo, string name, string surname, string city, string address, string email,
        DateTime birthDate, string gender, string password)
    {
        TcNo = tcNo;
        Name = name;
        Surname = surname;
        City = city;
        Address = address;
        Email = email;
        BirthDate = birthDate;
        Gender = gender;
        Password = password;
        
    }
}