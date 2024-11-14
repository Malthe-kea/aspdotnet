using Microsoft.EntityFrameworkCore;

namespace aspdotnet.Models
{
    public class AspdotnetDbContext : DbContext
    {
       public DbSet<Expense> Expenses { get; set; }

       public AspdotnetDbContext(DbContextOptions<AspdotnetDbContext> options) : base(options)
       {
       }
    }
}
