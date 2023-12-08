using System.Diagnostics.CodeAnalysis;

namespace SoBugger.Common.Extensions;

public static class CommonExtensions
{
    public static bool IsNullOrEmpty([NotNullWhen(true)] this string? value)
    {
        return string.IsNullOrWhiteSpace(value);
    }

    public static string HideSensitiveInformation(this string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }

        if (value.Contains("@"))
        {
            // 隐藏邮箱
            int atIndex = value.IndexOf("@");
            string username = value.Substring(0, atIndex);
            string domain = value.Substring(atIndex + 1);
            int hideLength = username.Length > 2 ? username.Length - 2 : 0;
            string hiddenUsername = new string('*', hideLength) + username.Substring(hideLength);
            return hiddenUsername + "@" + domain;
        }
        else if (value.Length >= 11)
        {
            // 隐藏手机号
            string hiddenValue = value.Substring(0, 3) + new string('*', value.Length - 7) + value.Substring(value.Length - 4);
            return hiddenValue;
        }
        else
        {
            return value;
        }
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
