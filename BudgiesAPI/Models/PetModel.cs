using System.Text.Json.Serialization;

namespace BudgiesAPI.Models;

public class PetModel : IPolicyModel
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public string CustomerTcNo { get; set; }
    public int PetAge { get; set; }
    public string Genus { get; set; }
    public string Species { get; set; }

    [JsonConstructor]
    public PetModel(int id, DateTime startDate, DateTime endDate, decimal price, string customerTcNo, int petAge, string genus, string species)
        
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
        Price = price;
        CustomerTcNo = customerTcNo;
        PetAge = petAge;
        Genus = genus;
        Species = species;
    }
}