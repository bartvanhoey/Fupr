using System.Reflection;

namespace Fupr.Functional.AllOfType
{
    public class GetAllOfType
    {
        public static IEnumerable<T> GetAll<T>() =>
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => typeof(T).IsAssignableFrom(type))
                .Where(type => type is { IsAbstract: false, IsGenericType: false } &&
                    type.GetConstructor([]) != null)
                .Select(type => (T)Activator.CreateInstance(type)!)
                .ToList();

        public static List<T> GetAll<T>(Assembly executingAssembly) =>
            executingAssembly
                .GetTypes()
                .Where(type => typeof(T).IsAssignableFrom(type))
                .Where(type =>
                    type is { IsAbstract: false, IsGenericType: false } &&
                    type.GetConstructor([]) != null)
                .Select(type => (T)Activator.CreateInstance(type)!)
                .ToList();
    }
}