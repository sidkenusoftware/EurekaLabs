using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class PedidoSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {

        }
    }
}