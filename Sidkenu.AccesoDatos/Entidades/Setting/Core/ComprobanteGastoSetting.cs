using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ComprobanteGastoSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ComprobanteGasto>
    {
        public void Configure(EntityTypeBuilder<ComprobanteGasto> builder)
        {
            // Propiedades
            builder.Property(x => x.TipoGastoId)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(500)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasOne(x => x.TipoGasto)
                .WithMany(x => x.ComprobanteGastos)
                .HasForeignKey(x => x.TipoGastoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
