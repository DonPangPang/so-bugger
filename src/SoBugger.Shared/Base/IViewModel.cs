namespace SoBugger.Shared.Base;

public interface IViewModel
{
    public Guid Id { get; set; }
}

public abstract class ViewModel : IViewModel
{
    public Guid Id { get; set; }
}
