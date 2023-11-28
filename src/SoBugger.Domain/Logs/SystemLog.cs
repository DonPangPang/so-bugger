using Microsoft.Extensions.Logging;

namespace SoBugger.Domain.Logs;

public class SystemLog : AccessLog
{
    public string Category { get; set; } = "System";
    public string? Message { get; set; }
    public string? TraceId { get; set; }
    public string? StackTrace { get; set; }
    public LogLevel Level { get; set; }
}
