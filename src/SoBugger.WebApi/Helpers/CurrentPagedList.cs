using Microsoft.EntityFrameworkCore;
using SoBugger.Shared;

namespace SoBugger.WebApi.Helpers;

public class CurrentPagedList<T> : PagedList<T> where T : class, new()
{
    public CurrentPagedList(List<T> items, int count, int pageNumber, int pageSize)
    {
        TotalPages = count;
        PageSize = pageSize;
        CurrentPage = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        AddRange(items);
    }

    public static async Task<CurrentPagedList<T>> CreateAsync(IQueryable<T> sourse, int pageNumber, int pageSize)
    {
        var count = await sourse.CountAsync();
        var items = await sourse.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        return new CurrentPagedList<T>(items, count, pageNumber, pageSize);
    }
}
