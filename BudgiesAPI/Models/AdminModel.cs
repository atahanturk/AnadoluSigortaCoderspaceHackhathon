namespace BudgiesAPI.Models;

public class AdminModel : IUserModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string TcNo { get; set; }


    public AdminModel(string name, string surname, string email, string password, string tcNo)
    {
        TcNo = tcNo;
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
    }
}