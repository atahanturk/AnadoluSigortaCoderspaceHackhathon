namespace BudgiesAPI.Models;

public interface IPolicyModel
{
    
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string CustomerTcNo { get; set; }
    

}