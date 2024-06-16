using System.Reflection;
using System.Text;
using Utils.Extensions;

namespace Utils;

public static class ObjectPrinter
{
    public static string Print(object obj)
    {
        if (obj == null)
            return "{}";

        var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var propertyDictionary = new Dictionary<string, object>();

        foreach (var property in properties)
        {
            var value = property.GetValue(obj, null);
            propertyDictionary.Add(property.Name, value ?? "");
        }

        string result = $"{obj.GetType().Name}: {ObjectExtensions.Serialize(propertyDictionary)}";

        return result;
    }
}
