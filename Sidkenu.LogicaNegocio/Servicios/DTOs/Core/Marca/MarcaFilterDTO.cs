﻿using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Marca
{
    public class MarcaFilterDTO : FilterBaseDTO
    {
        public string? CadenaBuscar { get; set; } = null;
    }
}