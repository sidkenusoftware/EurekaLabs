using Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using StructureMap;

namespace Sidkenu.LogicaNegocio.IoC
{
    public class StructureMapRegistrySeguridad : Registry
    {
        public StructureMapRegistrySeguridad()
        {
            // Servicios Seguridad
            For<ICuentaServicio>().Use<CuentaServicio>();
            For<IPasswordServicio>().Use<PasswordServicio>();
            For<IUsuarioServicio>().Use<UsuarioServicio>();
            For<IPersonaServicio>().Use<PersonaServicio>();
            For<IEmpresaPersonaServicio>().Use<EmpresaPersonaServicio>();
            For<IEmpresaServicio>().Use<EmpresaServicio>();
            For<IProvinciaServicio>().Use<ProvinciaServicio>();
            For<IIngresoBrutoServicio>().Use<IngresoBrutoServicio>();
            For<ITipoResponsabilidadServicio>().Use<TipoResponsabilidadServicio>();
            For<ILocalidadServicio>().Use<LocalidadServicio>();
            For<IConfiguracionServicio>().Use<ConfiguracionServicio>();
            For<IGrupoServicio>().Use<GrupoServicio>();
            For<IFormularioServicio>().Use<FormularioServicio>();
            For<IGrupoPersonaServicio>().Use<GrupoPersonaServicio>();
            For<IGrupoFormularioServicio>().Use<GrupoFormularioServicio>();
            For<IModuloServicio>().Use<ModuloServicio>();
            For<IPuestoTrabajoServicio>().Use<PuestoTrabajoServicio>();
        }
    }
}
