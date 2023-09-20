using Microsoft.EntityFrameworkCore;
using Velocity.Shared.Entities;

namespace Velocity.API.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<CustomerVendorDetail> CustomerVendorDetails { get; set; }
}