using AutoMapper;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.AsistenteCargaInicial;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Empresa;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Grupo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.IngresoBruto;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Localidad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Modulo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Persona;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Provincia;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.PuestoTrabajo;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.TipoResponsabilidad;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Usuario;

namespace Sidkenu.Servicio.Mapper
{
    public class SeguridadAutoMapperProfile : Profile
    {
        public SeguridadAutoMapperProfile()
        {
            CreateMap<Empresa, EmpresaDTO>()
                .ForMember(x => x.TipoResponsabilidad, y => y.MapFrom(z => z.TipoResponsabilidad.Descripcion))
                .ForMember(x => x.Localidad, y => y.MapFrom(z => z.Localidad.Descripcion))
                .ForMember(x => x.Provincia, y => y.MapFrom(z => z.Localidad.Provincia.Descripcion))
                .ForMember(x => x.ProvinciaId, y => y.MapFrom(z => z.Localidad.ProvinciaId));

            CreateMap<EmpresaPersistenciaDTO, Empresa>();

            //============================================================================================ //

            CreateMap<TipoResponsabilidad, TipoResponsabilidadDTO>().ReverseMap();
            CreateMap<TipoResponsabilidadPersistenciaDTO, TipoResponsabilidad>();

            //============================================================================================ //

            CreateMap<IngresoBruto, IngresoBrutoDTO>().ReverseMap();
            CreateMap<IngresoBrutoPersistenciaDTO, IngresoBruto>();

            //============================================================================================ //

            CreateMap<Provincia, ProvinciaDTO>().ReverseMap();
            CreateMap<ProvinciaPersistenciaDTO, Provincia>();

            //============================================================================================ //

            CreateMap<PuestoTrabajo, PuestoTrabajoDTO>().ReverseMap();
            CreateMap<PuestoTrabajoPersistenciaDTO, PuestoTrabajo>();

            //============================================================================================ //

            CreateMap<Localidad, LocalidadDTO>()
                .ForMember(x => x.ProvinciaId, y => y.MapFrom(z => z.ProvinciaId))
                .ForMember(x => x.Provincia, y => y.MapFrom(z => z.Provincia.Descripcion))
                .ReverseMap();
            CreateMap<LocalidadPersistenciaDTO, Localidad>();

            //============================================================================================ //

            CreateMap<Persona, PersonaDTO>()
                .ForMember(x => x.TieneUsuario, y => y.MapFrom(z => z.Usuarios.Any()))
                .ForMember(x => x.Usuario, y => y.MapFrom(z => z.Usuarios.Any()
                                                             ? z.Usuarios.FirstOrDefault().Nombre
                                                             : "NO REGISTRADO"))
                .ReverseMap();

            CreateMap<PersonaPersistenciaDTO, Persona>();

            //============================================================================================ //

            CreateMap<Usuario, UsuarioDTO>()
                // Datos del Usuario
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Nombre, y => y.MapFrom(z => z.Nombre))
                .ForMember(x => x.EstaEliminado, y => y.MapFrom(z => z.EstaEliminado))
                .ForMember(x => x.InicioPorPrimeraVez, y => y.MapFrom(z => z.InicioPorPrimeraVez))
                // Datos de la Persona
                .ForMember(x => x.PersonaId, y => y.MapFrom(z => z.PersonaId))
                .ForMember(x => x.NombrePersona, y => y.MapFrom(z => z.Persona.Nombre))
                .ForMember(x => x.ApellidoPersona, y => y.MapFrom(z => z.Persona.Apellido))
                .ForMember(x => x.EmailPersona, y => y.MapFrom(z => z.Persona.Mail))
                .ForMember(x => x.FotoPersona, y => y.MapFrom(z => z.Persona.Foto))
                // Datos del o los Empresas
                .ForMember(x => x.Empresas, y => y.MapFrom(z => z.Persona.EmpresaPersonas
                                                               .Where(mp => !mp.EstaEliminado && !mp.Empresa.EstaEliminado)
                                                               .Select(mp => mp.Empresa)));

            //============================================================================================ //

            CreateMap<Persona, UsuarioDTO>()
                // Datos de la Persona
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Usuarios.Any() ? z.Usuarios.First().Id : Guid.Empty))
                .ForMember(x => x.ApellidoPersona, y => y.MapFrom(z => z.Apellido))
                .ForMember(x => x.NombrePersona, y => y.MapFrom(z => z.Nombre))
                .ForMember(x => x.EmailPersona, y => y.MapFrom(z => z.Mail))
                .ForMember(x => x.FotoPersona, y => y.MapFrom(z => z.Foto))
                // Datos del Usuario
                .ForMember(x => x.PersonaId, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Existe,
                    y => y.MapFrom(z => z.Usuarios.Any()))
                .ForMember(x => x.Nombre,
                    y => y.MapFrom(z => z.Usuarios.Any()
                                      ? z.Usuarios.First().Nombre
                                      : "NO ASIGNADO"))
                .ForMember(x => x.EstaEliminado,
                    y => y.MapFrom(z => z.Usuarios.Any() && z.Usuarios.First().EstaEliminado))
                .ForMember(x => x.InicioPorPrimeraVez,
                    y => y.MapFrom(z => z.Usuarios.Any() && z.Usuarios.First().InicioPorPrimeraVez));

            //============================================================================================ //

            CreateMap<EmpresaPersona, PersonaDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.PersonaId))
                .ForMember(x => x.Apellido, y => y.MapFrom(z => z.Persona.Apellido))
                .ForMember(x => x.Nombre, y => y.MapFrom(z => z.Persona.Nombre))
                .ForMember(x => x.Telefono, y => y.MapFrom(z => z.Persona.Telefono))
                .ForMember(x => x.Cuil, y => y.MapFrom(z => z.Persona.Cuil))
                .ForMember(x => x.Mail, y => y.MapFrom(z => z.Persona.Mail))
                .ForMember(x => x.Direccion, y => y.MapFrom(z => z.Persona.Direccion))
                .ForMember(x => x.EstaEliminado, y => y.MapFrom(z => z.Persona.EstaEliminado))
                .ForMember(x => x.Foto, y => y.MapFrom(z => z.Persona.Foto))
                .ForMember(x => x.TieneUsuario, y => y.MapFrom(z => z.Persona.Usuarios.Any()))
                .ForMember(x => x.Usuario, y => y.MapFrom(z => z.Persona.Usuarios.Any()
                                                               ? z.Persona.Usuarios.First().Nombre
                                                               : "NO ASIGNADO"));

            //============================================================================================ //

            CreateMap<ConfiguracionSeguridad, ConfiguracionDTO>().ReverseMap();
            CreateMap<ConfiguracionPersistenciaDTO, ConfiguracionSeguridad>();

            //============================================================================================ //

            CreateMap<EmpresaAsistenteDTO, EmpresaPersistenciaDTO>();
            CreateMap<PersonaAsistenteDTO, PersonaPersistenciaDTO>();
            CreateMap<ConfiguracionAsistenteDTO, ConfiguracionPersistenciaDTO>();

            //============================================================================================ //

            CreateMap<Grupo, GrupoDTO>()
                .ForMember(x => x.Empresa, y => y.MapFrom(z => z.Empresa.Descripcion))
                .ReverseMap();

            CreateMap<GrupoPersistenciaDTO, Grupo>();

            //============================================================================================ //

            CreateMap<Formulario, FormularioDTO>()
                .ReverseMap();

            //============================================================================================ //

            CreateMap<GrupoPersona, PersonaDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.PersonaId))
                .ForMember(x => x.Apellido, y => y.MapFrom(z => z.Persona.Apellido))
                .ForMember(x => x.Nombre, y => y.MapFrom(z => z.Persona.Nombre))
                .ForMember(x => x.Telefono, y => y.MapFrom(z => z.Persona.Telefono))
                .ForMember(x => x.Cuil, y => y.MapFrom(z => z.Persona.Cuil))
                .ForMember(x => x.Mail, y => y.MapFrom(z => z.Persona.Mail))
                .ForMember(x => x.Direccion, y => y.MapFrom(z => z.Persona.Direccion))
                .ForMember(x => x.EstaEliminado, y => y.MapFrom(z => z.Persona.EstaEliminado))
                .ForMember(x => x.Foto, y => y.MapFrom(z => z.Persona.Foto))
                .ForMember(x => x.TieneUsuario, y => y.MapFrom(z => z.Persona.Usuarios.Any()))
                .ForMember(x => x.Usuario, y => y.MapFrom(z => z.Persona.Usuarios.Any()
                                                               ? z.Persona.Usuarios.First().Nombre
                                                               : "NO ASIGNADO"));

            //============================================================================================ //

            CreateMap<GrupoFormulario, FormularioDTO>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.FormularioId))
                .ForMember(x => x.Codigo, y => y.MapFrom(z => z.Formulario.Codigo))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.Formulario.Descripcion))
                .ForMember(x => x.DescripcionCompleta, y => y.MapFrom(z => z.Formulario.DescripcionCompleta))
                .ForMember(x => x.EstaVigente, y => y.MapFrom(z => z.Formulario.EstaVigente))
                .ForMember(x => x.ExisteBase, y => y.MapFrom(z => true));

            //============================================================================================ //

            CreateMap<Modulo, ModuloDTO>().ReverseMap();
            CreateMap<ModuloPersistenciaDTO, Modulo>();
        }
    }
}
