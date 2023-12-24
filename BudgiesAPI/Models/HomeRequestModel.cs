namespace BudgiesAPI.Models;

public class HomeRequestModel
{
    public int Id { get; set; }
    public string CustomerTcNo { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public string HomeType { get; set; }
    public int HomeAge { get; set; }
}