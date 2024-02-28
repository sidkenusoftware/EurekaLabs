using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ComprobanteTransferenciaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ComprobanteTransferencia>
    {
        public void Configure(EntityTypeBuilder<ComprobanteTransferencia> builder)
        {
            // Propiedades
            builder.Property(x => x.Descripcion)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
