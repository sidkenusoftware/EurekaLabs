using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ArticuloHistorialCostoSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ArticuloHistorialCosto>
    {
        public void Configure(EntityTypeBuilder<ArticuloHistorialCosto> builder)
        {
            // Propiedades

            builder.Property(x => x.ArticuloId)
                .IsRequired();

            builder.Property(x => x.PrecioCostoNuevo)
                .IsRequired();

            builder.Property(x => x.PrecioCostoAnterior)
                .IsRequired();

            builder.Property(x => x.FechaActualizacion)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Articulo)
                .WithMany(x => x.ArticuloHistorialCostos)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}