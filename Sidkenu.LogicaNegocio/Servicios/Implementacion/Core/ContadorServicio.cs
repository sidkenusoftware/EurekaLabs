using Sidkenu.AccesoDatos.Constantes.Enum;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class ContadorServicio : IContadorServicio
    {
        public long ObtenerNumero(TipoContador tipoContador, Guid empresaId, string user)
        {
            using var _context = new DataContext();

            try
			{
                long _numero = 0;

                var result = _context.Contadores
                    .Where(x => x.TipoContador == tipoContador
                                && x.EmpresaId == empresaId)
                    .ToList();

                if (result != null && result.Any())
                {
                    var _contador = result.FirstOrDefault();

                    if (tipoContador == TipoContador.ArticuloTemporal)
                    {
                        _contador.Numero--;
                    }
                    else
                    {
                        _contador.Numero++;
                    }
                    _contador.User = user;

                    _context.Contadores.Update(_contador);

                    _numero = _contador.Numero;
                }
                else
                {
                    _context.Contadores.Add(new Contador
                    {
                        EmpresaId = empresaId,
                        EstaEliminado = false,
                        Numero = tipoContador == TipoContador.ArticuloTemporal ? 999999 : 1,
                        TipoContador = tipoContador,
                        User = user
                    });

                    _numero = tipoContador == TipoContador.ArticuloTemporal ? 999999 : 1;
                }

                _context.SaveChanges();

                return _numero;
			}
			catch (Exception ex)
			{
                throw new Exception($"Ocurrio un error al obtener el contador. {ex.Message}");
            }
        }
    }
}
