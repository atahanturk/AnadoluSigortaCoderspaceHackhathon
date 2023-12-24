using System.Text.Json.Serialization;

namespace BudgiesAPI.Models;

public class HomeModel : IPolicyModel
{   
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public string CustomerTcNo { get; set; }
    public string HomeType { get; set; }
    public int HomeAge { get; set; }

    [JsonConstructor]
    public HomeModel(int id, DateTime startDate, DateTime endDate, decimal price, string customerTcNo, string homeType, int homeAge) 
        
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
        Price = price;
        CustomerTcNo = customerTcNo;
        HomeType = homeType;
        HomeAge = homeAge;
    }
}