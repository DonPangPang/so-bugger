using Microsoft.EntityFrameworkCore;
using SoBugger.Domain.Base;

namespace SoBugger.WebApi.Repository;

public interface IUnitOfWork
{
    IQueryable<T> Query<T>() where T : class, IEntity;
    DbSet<T> Set<T>() where T : class, IEntity;
    Task<bool> CommitAsync();
}
