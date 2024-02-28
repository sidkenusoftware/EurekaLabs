using AutoMapper;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Configuracion;
using Sidkenu.LogicaNegocio.Servicios.Interface.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Base
{
    public class ServicioBase : IServicioBase
    {
        protected readonly IConfiguracionServicio _configuracionServicio;
        protected readonly IMapper _mapper;

        protected ConfiguracionDTO _configuracionDTO;

        public ServicioBase(IMapper mapper, IConfiguracionServicio configuracionServicio)
        {
            _configuracionServicio = configuracionServicio;
            _mapper = mapper;

            var result = _configuracionServicio.Get();

            if (result != null && result.State)
            {
                _configuracionDTO = (ConfiguracionDTO)result.Data;
            }
            else
            {
                _configuracionDTO = (ConfiguracionDTO)null;
            }            
        }

        public ServicioBase(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
