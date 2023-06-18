using System.Reflection;

namespace Use_Case_23.Models
{
    public abstract class EnumBase
    {
        public string Value { get; }

        protected EnumBase(string value) => Value = value;

        public override string ToString() => Value;

        public static IEnumerable<T?> GetAllValues<T>() where T : EnumBase =>
                             typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static)
                            .Where(p => p.FieldType == typeof(T))
                            .Select(p => (T?)p.GetValue(null));

    }
}