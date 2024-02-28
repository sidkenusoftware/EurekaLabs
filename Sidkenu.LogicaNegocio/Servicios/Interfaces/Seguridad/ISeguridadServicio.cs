namespace Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad
{
    public interface ISeguridadServicio
    {
        bool VerificarAcceso(Guid personaLoginId, Guid empresaId, string formulario);
    }
}
