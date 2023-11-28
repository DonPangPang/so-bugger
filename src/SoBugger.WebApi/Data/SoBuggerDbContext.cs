using Microsoft.EntityFrameworkCore;

namespace SoBugger.WebApi.Data;

public class SoBuggerDbContext : DbContext
{
    public SoBuggerDbContext(DbContextOptions<SoBuggerDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
