﻿using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.TipoResponsabilidad
{
    public class TipoResponsabilidadPersistenciaDTO : EntidadBaseDTO
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
