using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ArticuloDepositoSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ArticuloDeposito>
    {
        public void Configure(EntityTypeBuilder<ArticuloDeposito> builder)
        {
            // Propiedades

            builder.Property(x => x.ArticuloId)
                .IsRequired();

            builder.Property(x => x.DepositoId)
                .IsRequired();

            builder.Property(x => x.Cantidad)
                .HasPrecision(18, 6)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasOne(x => x.Articulo)
                .WithMany(x => x.ArticuloDepositos)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Deposito)
                .WithMany(x => x.ArticuloDepositos)
                .HasForeignKey(x => x.DepositoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}