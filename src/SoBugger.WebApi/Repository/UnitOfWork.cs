using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Base;
using SoBugger.WebApi.Data;

namespace SoBugger.WebApi.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly SoBuggerDbContext _dbContext;

    public UnitOfWork(SoBuggerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CommitAsync()
    {
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public IQueryable<T> Query<T>() where T : class, IEntity
    {
        return _dbContext.Set<T>().AsQueryable();
    }

    public DbSet<T> Set<T>() where T : class, IEntity
    {
        return _dbContext.Set<T>();
    }
}
