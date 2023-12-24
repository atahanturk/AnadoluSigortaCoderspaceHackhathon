namespace BudgiesAPI.Models;

public class HealthRequestModel
{
    public int Id { get; set; }
    public string CustomerTcNo { get; set; }
    public bool SmokingStatus { get; set; }
    public bool GeneticDisease { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
}