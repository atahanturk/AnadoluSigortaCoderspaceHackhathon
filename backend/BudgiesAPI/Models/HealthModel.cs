
namespace BudgiesAPI.Models;

public class HealthModel : IPolicyModel
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public string CustomerTcNo { get; set; }
    public bool SmokingStatus { get; set; }
    public bool GeneticDisease { get; set; }

    public HealthModel(int id, DateTime startDate, DateTime endDate, decimal price, string customerTcNo, bool smokingStatus, bool geneticDisease)
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
        Price = price;
        CustomerTcNo = customerTcNo;
        SmokingStatus = smokingStatus;
        GeneticDisease = geneticDisease;
    }
}