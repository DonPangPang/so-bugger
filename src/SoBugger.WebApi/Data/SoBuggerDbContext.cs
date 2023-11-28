using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Base;
using SoBugger.Domain.Platform;

namespace SoBugger.WebApi.Data;

public class SoBuggerDbContext(DbContextOptions<SoBuggerDbContext> options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entityTypes = typeof(IEntity).Assembly.GetTypes().Where(t =>
            t is { IsInterface: false, IsAbstract: false } && t.IsAssignableTo(typeof(IEntity)));

        foreach (var type in entityTypes)
        {
            if (modelBuilder.Model.FindEntityType(type) is null)
                modelBuilder.Model.AddEntityType(type);
            else
            {
                Console.WriteLine($"Entity type {type.Name} already exists in the model");
            }
        }

        //modelBuilder.Model.AddEntityType(typeof(Role));

        base.OnModelCreating(modelBuilder);
    }
}