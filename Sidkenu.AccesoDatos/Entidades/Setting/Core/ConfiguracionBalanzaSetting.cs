using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ConfiguracionBalanzaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ConfiguracionBalanza>
    {
        public void Configure(EntityTypeBuilder<ConfiguracionBalanza> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.CodigoIdentificarImporte)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.DecimalesImporte)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.CodigoIdentificarImporte)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.DecimalesImporte)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.ConvierteUnidadPeso)
                .IsRequired();

            builder.Property(x => x.Equivalencia).HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.LongitudTotal)
                .IsRequired();

            builder.Property(x => x.InicioIdentificarTipo)
                .IsRequired();

            builder.Property(x => x.CantidadIdentificarTipo)
                .IsRequired();

            builder.Property(x => x.InicioIdentificarCodigoArcitulo)
                .IsRequired();

            builder.Property(x => x.CantidadIdentificarCodigoArcitulo)
                .IsRequired();

            builder.Property(x => x.InicioIdentificarImportePrecio)
                .IsRequired();

            builder.Property(x => x.CantidadIdentificarImportePrecio)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.ConfiguracionBalanzas)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
