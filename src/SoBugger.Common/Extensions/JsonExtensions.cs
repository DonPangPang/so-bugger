using Newtonsoft.Json;

namespace SoBugger.Common.Extensions;

public static class JsonExtensions
{
    public static string ToJson(this object? obj)
    {
        if (obj is null) return string.Empty;
        return JsonConvert.SerializeObject(obj);
    }

    public static T? ToObject<T>(this string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}
