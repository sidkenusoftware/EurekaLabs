using System.Reflection;

namespace Sidkenu.AccesoDatos.Constantes
{
    public static class EntityReflection
    {
        public static string GetPropValue(this Object obj)
        {
            var _result = string.Empty;

            Type typeObj = obj.GetType();
            PropertyInfo[] properties = typeObj.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                _result += $"{property.Name}:{property.GetValue(obj)}" + Environment.NewLine;
            }

            return _result;
        }

        public static string GetName(this Object obj)
        {
            return obj.GetType().Name;
        }

        public static IEnumerable<IGrouping<TKey, IDictionary<TColumn, TValue>>> Pivot<TSource, TKey, TColumn, TValue>(
                      this IEnumerable<TSource> source, Func<TSource, TKey> rowSelector,
                      Func<TSource, TColumn> columnSelector, Func<IEnumerable<TSource>, TValue> valueSelector)
        {
            return source.GroupBy(rowSelector)
                .Select(g => new
                {
                    RowKey = g.Key,
                    Columns = source.Select(columnSelector).Distinct(),
                    Values = g.GroupBy(columnSelector)
                        .ToDictionary(g2 => g2.Key, g2 => valueSelector(g2))
                })
                .GroupBy(x => x.RowKey, x => x.Values);
        }
    }
}
