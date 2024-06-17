using System.Reflection;
using System.Text;
using Utils.Extensions;

namespace Utils;

public static class ObjectPrinter<T>
{
    public static Dictionary<string, object> GetProperties(T inputObject)
    {
        if (inputObject == null)
            return [];

        var properties = inputObject
            .GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var propertyDictionary = new Dictionary<string, object>();

        foreach (var property in properties)
        {
            var value = property.GetValue(inputObject, null);
            propertyDictionary.Add(property.Name, value ?? "");
        }

        return propertyDictionary;
    }
}
