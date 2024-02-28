using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante
{
    public class ComprobanteGastos : Comprobante
    {
        public override ResultDTO AddOrUpdate(ComprobanteDTO comprobante, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var _comprobanteGastoDto = (ComprobanteGastoDTO)comprobante;

                var comprobanteResult = base.AddOrUpdate(comprobante, userLogin);

                if (comprobanteResult != null && comprobanteResult.State)
                {
                    var nuevoComprobante = (ComprobanteGasto)comprobanteResult.Data;

                    nuevoComprobante.TipoGastoId = _comprobanteGastoDto.TipoGastoId;
                    nuevoComprobante.Descripcion = _comprobanteGastoDto.Descripcion;

                    _context.Comprobantes.Add(nuevoComprobante);

                    _context.SaveChanges();

                    comprobante.Id = nuevoComprobante.Id;

                    return new ResultDTO
                    {
                        State = true,
                        Message = "Los datos se grabaron correctamente",
                        Data = comprobante
                    };
                }
                else
                {
                    return comprobanteResult;
                }
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }
    }
}
