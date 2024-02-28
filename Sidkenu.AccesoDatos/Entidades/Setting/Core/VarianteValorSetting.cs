using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class VarianteValorSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<VarianteValor>
    {
        public void Configure(EntityTypeBuilder<VarianteValor> builder)
        {
            // Propiedades
            builder.Property(x => x.VarianteId)
                .IsRequired(false);

            builder.Property(x => x.Codigo)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(150)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasOne(x => x.Variante)
                .WithMany(x => x.VarianteValores)
                .HasForeignKey(x => x.VarianteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ArticuloUnos)
                .WithOne(x => x.VarianteValorUno)
                .HasForeignKey(x => x.VarianteValorUnoId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ArticuloDos)
                .WithOne(x => x.VarianteValorDos)
                .HasForeignKey(x => x.VarianteValorDosId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}