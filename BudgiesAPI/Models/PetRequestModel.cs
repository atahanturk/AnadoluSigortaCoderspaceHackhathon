namespace BudgiesAPI.Models;

public class PetRequestModel
{
    public int Id { get; set; }
    public string CustomerTcNo { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public int PetAge { get; set; }
    public string Genus { get; set; }
    public string Species { get; set; }
}