namespace SoBugger.Shared.Base;

public interface IViewModel
{
    public Guid Id { get; set; }
}

public abstract record ViewModel : IViewModel
{
    public Guid Id { get; set; }
}

public interface IPaging
{
    int Page { get; set; }
    int PageSize { get; set; }
}

public interface ISorting
{
    string OrderBy { get; set; }
}

public interface IParameter
{

}
