using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Base
{
    public class GenericCompareDTO<T> : IEqualityComparer<T> where T : EntidadBaseDTO
    {
        public bool Equals(T x, T y)
        {
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id;
        }

        public int GetHashCode(T obj)
        {
            return obj.Id.GetHashCode();
        }
    }

    public class GenericCompare<T> : IEqualityComparer<T> where T : EntidadBase
    {
        public bool Equals(T x, T y)
        {
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id;
        }

        public int GetHashCode(T obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
