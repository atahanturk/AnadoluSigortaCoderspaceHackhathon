using BudgiesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgiesAPI.Data;

public class DataContext : DbContext
{
    public DbSet<CustomerModel>? Customers { get; set; }
    public DbSet<AdminModel>? Admins { get; set; }
    public DbSet<HealthModel>? HealthPolicies { get; set; } 
    public DbSet<HomeModel>? HomePolicies { get; set; }
    public DbSet<PetModel>? PetPolicies { get; set; }
    public DbSet<HealthRequestModel> HealthRequests { get; set; }
    public DbSet<HomeRequestModel> HomeRequests { get; set; }
    public DbSet<PetRequestModel> PetRequests { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       
        modelBuilder.Entity<HealthModel>().HasKey(h => h.Id);
        modelBuilder.Entity<HomeModel>().HasKey(h => h.Id);
        modelBuilder.Entity<PetModel>().HasKey(p => p.Id);

        
        modelBuilder.Entity<CustomerModel>()
            .HasKey(c => c.TcNo);
        
        modelBuilder.Entity<AdminModel>()
            .HasKey(a => a.TcNo);

        // CustomerModel ve PolicyModel arasında one-to-many ilişki tanımla
        modelBuilder.Entity<HealthModel>()
            .HasOne<CustomerModel>() // HealthModel, CustomerModel ile ilişkilendiriliyor
            .WithMany(c => c.HealthPolicies) // CustomerModel içindeki HealthPolicies koleksiyonu
            .HasForeignKey(h => h.CustomerTcNo);
        
        modelBuilder.Entity<PetModel>()
            .HasOne<CustomerModel>()
            .WithMany(c => c.PetPolicies)
            .HasForeignKey(p => p.CustomerTcNo);
        
        modelBuilder.Entity<HomeModel>()
            .HasOne<CustomerModel>()
            .WithMany(c => c.HomePolicies)
            .HasForeignKey(h => h.CustomerTcNo);
        
        modelBuilder.Entity<HealthRequestModel>()
            .HasOne<CustomerModel>()
            .WithMany()
            .HasForeignKey(h => h.CustomerTcNo);

        modelBuilder.Entity<HomeRequestModel>()
            .HasOne<CustomerModel>()
            .WithMany()
            .HasForeignKey(h => h.CustomerTcNo);

        modelBuilder.Entity<PetRequestModel>()
            .HasOne<CustomerModel>()
            .WithMany()
            .HasForeignKey(p => p.CustomerTcNo);
    }
    
}