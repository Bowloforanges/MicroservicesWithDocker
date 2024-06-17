using System.Text.Json;

namespace Utils.Extensions;

public static class ObjectExtensions
{
    static JsonSerializerOptions options =
        new() { WriteIndented = true, AllowTrailingCommas = false };

    public static T? Deserialize<T>(this string json)
    {
        return JsonSerializer.Deserialize<T>(json, options);
    }

    public static string Serialize<T>(this T defaultObject)
    {
        return JsonSerializer.Serialize(defaultObject, options);
    }
}
