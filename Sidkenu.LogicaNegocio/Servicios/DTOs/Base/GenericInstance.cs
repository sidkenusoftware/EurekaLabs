namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Base
{
    public class GenericInstance<TEntity> where TEntity : class
    {
        public static TEntity InstanciarEntidad(string tipoEntidad)
        {
            var tipoObjeto = Type.GetType(tipoEntidad);

            if (tipoObjeto == null) return null;

            var entidad = Activator.CreateInstance(tipoObjeto) as TEntity;

            return entidad;
        }

        public static TEntity InstanciarEntidad(EntidadBaseDTO entidad, Dictionary<Type, string> _diccionario)
        {
            if (!_diccionario.TryGetValue(entidad.GetType(), out var tipoEntidad))
                throw new Exception($"There is no definition of the entity {entidad.GetType()} in the Dictionary");

            var entity = InstanciarEntidad(tipoEntidad);

            if (entity == null) throw new Exception($"An error occurred while instantiating {entidad.GetType()}");

            return entity;
        }

        public static TEntity InstanciarEntidad(Type tipo, Dictionary<Type, string> _diccionario)
        {
            if (!_diccionario.TryGetValue(tipo, out var tipoEntidad))
                throw new Exception($"There is no definition of the entity {tipo.ToString()} in the Dictionary");

            var entity = InstanciarEntidad(tipoEntidad);

            if (entity == null) throw new Exception($"An error occurred while instantiating {tipo}");

            return entity;
        }
    }
}
