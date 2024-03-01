using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Seguridad
{
    public class SeguridadServicio : ISeguridadServicio
    {
        public bool VerificarAcceso(Guid personaId, Guid empresaId, string formulario)
        {
            using var _context = new DataContext();

            var result = _context.GruposPersonas
                .AsNoTracking()
                .Include(g => g.Grupo).ThenInclude(gp => gp.GrupoFormularios).ThenInclude(f => f.Formulario)
                .Where(x => !x.EstaEliminado
                                && !x.Grupo.EstaEliminado
                                && x.Grupo.EmpresaId == empresaId
                                && x.PersonaId == personaId
                                && x.Grupo.GrupoFormularios.Where(gf => !gf.EstaEliminado).Any(gf => gf.Formulario.DescripcionCompleta == formulario))
                .ToList();

            return result.Any();
        }
    }
}
