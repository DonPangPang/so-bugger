using SoBugger.Domain.Base;

namespace SoBugger.Domain.Logs;

public class AccessLog : LogBase
{
    public string Path { get; set; } = string.Empty;
    public string? Data { get; set; }
    public string HttpMethod { get; set; } = string.Empty;
    public string Referer { get; set; } = string.Empty;

    public string Ip { get; set; } = string.Empty;
    public string Agaent { get; set; } = string.Empty;
}
