using System.Text.Json;
using static System.Text.Json.JsonSerializer;

namespace Fupr.Extensions
{
    public static class ObjectExtensions
    {
        public static string ConvertToJson(this object objectToSerialize)
        {
            if (objectToSerialize is null)
                throw new ArgumentNullException("ConvertToJson: You cannot convert a null string to a Type");

            return Serialize(objectToSerialize, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public static bool IsEqualTo<T>(this T originalObject, T objectToCompare)
        {
            if (originalObject == null && objectToCompare == null) return true;
            if (originalObject == null) return false;
            if (objectToCompare == null) return false;

            return objectToCompare.ConvertToJson() == originalObject.ConvertToJson();
        }

        public static T DeepCopy<T>(this T obj) 
            => (obj ?? throw new ArgumentNullException(nameof(obj))).ConvertToJson().ConvertTo<T>() ?? throw new InvalidOperationException();
    }
}