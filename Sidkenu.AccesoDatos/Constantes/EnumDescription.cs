using System.ComponentModel;
using System.Reflection;

namespace Sidkenu.AccesoDatos.Constantes
{
    public static class EnumDescription
    {
        public static string Get(System.Enum value)
        {
            return
                value
                    .GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    ?.GetCustomAttribute<DescriptionAttribute>()
                    ?.Description
                ?? value.ToString();
        }

        public static object GetAll<T>() where T : System.Enum
        {
            return System.Enum.GetValues(typeof(T))
                       .Cast<System.Enum>()
                       .Select(value => new EnumDTO
                       {
                           Descripcion = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                           Valor = value
                       })
                        .OrderBy(item => item.Valor)
                        .ToList();
        }

        public static object GetAll<T>(List<EnumDTO> tiposParaExcluir) where T : System.Enum
        {
            var result = System.Enum.GetValues(typeof(T))
                        .Cast<System.Enum>()
                        .Select(value => new EnumDTO
                        {
                            Descripcion = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                            Valor = value
                        })
                        .OrderBy(item => item.Valor)
                        .ToList();

            return result.Except(tiposParaExcluir, new EnumCompareDTO<EnumDTO>()).ToList();
        }
    }

    public class EnumDTO
    {
        public System.Enum Valor { get; set; }
        public string Descripcion { get; set; }
    }

    public class EnumCompareDTO<T> : IEqualityComparer<T> where T : EnumDTO
    {
        public bool Equals(T x, T y)
        {
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Descripcion.Equals(y.Descripcion, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(T obj)
        {
            return obj.Descripcion.GetHashCode();
        }
    }
}
