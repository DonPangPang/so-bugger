namespace SoBugger.Shared;

public class PagedList<T> : List<T> where T : class, new()
{
    public int CurrentPage { get; protected set; }
    public int TotalPages { get; protected set; }
    public int PageSize { get; protected set; }
    public int TotalCount { get; protected set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;
}