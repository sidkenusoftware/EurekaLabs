using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Email;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interface.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interfaces.Email;
using StructureMap;

namespace Sidkenu.LogicaNegocio.IoC
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<IServicioBase>().Use<ServicioBase>();
            For<ICuentaServicio>().Use<CuentaServicio>();
            For<ICorreoElectronico>().Use<CorreoElectronico>();
            For<IConexionServicio>().Use<ConexionServicio>();
            For<IConectividadServicio>().Use<ConectividadServicio>();
            For<ISeguridadServicio>().Use<SeguridadServicio>();
            For<IAsistenteCargaInicialServicio>().Use<AsistenteCargaInicialServicio>();
        }
    }
}
