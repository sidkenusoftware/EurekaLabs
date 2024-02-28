using Sidkenu.AccesoDatos.Constantes;
using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using System;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MedioPago
{
    public class MedioPagoDTO : EntidadBaseDTO
    {
        public TipoMedioDePago Tipo { get; set; }
        public string TipoMedioDePagoStr => EnumDescription.Get(Tipo);
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
    }
}
