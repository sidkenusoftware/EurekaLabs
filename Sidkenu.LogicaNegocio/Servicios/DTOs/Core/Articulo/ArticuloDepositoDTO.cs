namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Articulo
{
    public class ArticuloDepositoDTO
    {
        public Guid Id { get; set; }

        public Guid DepositoId { get; set; }

        public Guid EmpresaId { get; set; }

        // ------------------------------------ //

        public string Empresa { get; set; }

        public string Deposito { get; set; }

        public decimal Cantidad { get; set; }
    }
}
