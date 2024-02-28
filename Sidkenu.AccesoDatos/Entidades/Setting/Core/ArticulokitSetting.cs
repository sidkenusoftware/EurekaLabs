using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ArticulokitSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ArticuloKit>
    {
        public void Configure(EntityTypeBuilder<ArticuloKit> builder)
        {
            // Propiedades

            builder.Property(x => x.ArticuloPadreId)
                .IsRequired();

            builder.Property(x => x.ArticuloHijoId)
                .IsRequired();

            builder.Property(x => x.Cantidad).HasPrecision(18, 6)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.ArticuloPadre)
                .WithMany(x => x.ArticuloPadreKits)
                .HasForeignKey(x => x.ArticuloPadreId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.ArticuloHijo)
                .WithMany(x => x.ArticuloHijoKits)
                .HasForeignKey(x => x.ArticuloHijoId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}