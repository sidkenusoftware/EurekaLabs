using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ArticuloFormulaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ArticuloFormula>
    {
        public void Configure(EntityTypeBuilder<ArticuloFormula> builder)
        {
            // Propiedades

            builder.Property(x => x.ArticuloId)
                .IsRequired();

            builder.Property(x => x.ArticuloSecundarioId)
                .IsRequired();

            builder.Property(x => x.Cantidad).HasPrecision(18, 6)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Articulo)
                .WithMany(x => x.ArticuloFormulas)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.ArticuloSecundario)
                .WithMany(x => x.ArticuloSecundarioFormulas)
                .HasForeignKey(x => x.ArticuloSecundarioId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}