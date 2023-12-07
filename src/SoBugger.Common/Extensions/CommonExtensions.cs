using System.Diagnostics.CodeAnalysis;

namespace SoBugger.Common.Extensions;

public static class CommonExtensions
{
    public static bool IsNullOrEmpty([NotNullWhen(true)] this string? value)
    {
        return string.IsNullOrWhiteSpace(value);
    }
}

public static class ThrowHelper
{
    public static void ThrowIfNull<T>(this T? value, string? paramName = null)
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName ?? nameof(value));
        }
    }

    public static void ThrowIfNullOrEmpty(this string? value, string? paramName = null)
    {
        if (value.IsNullOrEmpty())
        {
            throw new ArgumentNullException(paramName ?? nameof(value));
        }
    }
}
