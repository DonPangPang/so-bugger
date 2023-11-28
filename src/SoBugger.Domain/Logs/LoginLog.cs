using SoBugger.Domain.Base;

namespace SoBugger.Domain.Logs;

public class LoginLog : LogBase
{
    public string Account { get; set; } = string.Empty;
    public string? AuthType { get; set; }
    public string Ip { get; set; } = string.Empty;
    public string Agaent { get; set; } = string.Empty;
}
