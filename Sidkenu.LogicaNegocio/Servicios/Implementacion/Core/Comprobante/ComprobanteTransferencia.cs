using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Comprobante;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core.Comprobante
{
    public class ComprobanteTransferencia : Comprobante
    {
        public override ResultDTO AddOrUpdate(ComprobanteDTO comprobante, string userLogin)
        {
            using var _context = new DataContext();

            try
            {
                var _comprobanteTransferenciaDto = (ComprobanteTransferenciaDTO)comprobante;

                var comprobanteResult = base.AddOrUpdate(comprobante, userLogin);

                if (comprobanteResult != null && comprobanteResult.State)
                {
                    var nuevoComprobante = (Sidkenu.AccesoDatos.Entidades.Core.ComprobanteTransferencia)comprobanteResult.Data;

                    nuevoComprobante.Descripcion = _comprobanteTransferenciaDto.Descripcion;

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
