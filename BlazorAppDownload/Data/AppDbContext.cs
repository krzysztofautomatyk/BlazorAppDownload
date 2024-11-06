using BlazorAppDownload.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppDownload.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }

    public DbSet<Product> Products { get; set; }
}
