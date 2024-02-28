using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class FamiliaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Familia>
    {
        public void Configure(EntityTypeBuilder<Familia> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired(false);

            builder.Property(x => x.Codigo)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            // =============================================================== //

            builder.Property(x => x.ActivarRestriccionHoraVenta)
                .IsRequired();

            builder.Property(x => x.RestriccionHoraVentaDesde)
                .IsRequired(false);

            builder.Property(x => x.RestriccionHoraVentaHasta)
                .IsRequired(false);

            // =============================================================== //

            builder.Property(x => x.ActivarAumentoPrecioHoraVenta)
                .IsRequired();

            builder.Property(x => x.AumentoPrecioHoraVenta)
                .IsRequired(false);

            builder.Property(x => x.AumentoPrecioHoraVentaDesde)
                .IsRequired(false);

            builder.Property(x => x.AumentoPrecioHoraVentaHasta)
                .IsRequired(false);

            builder.Property(x => x.TipoValor)
                .IsRequired(false);

            // =============================================================== //

            builder.Property(x => x.ActivarAumentoPrecioPublico)
                .IsRequired();

            builder.Property(x => x.AumentoPrecioPublico)
                .IsRequired(false);

            builder.Property(x => x.TipoValorPublico)
                .IsRequired(false);

            // ---------------------------------------------------------------- //

            builder.Property(x => x.ActivarAumentoPrecioPublicoListaPrecio)
                .IsRequired();

            builder.Property(x => x.AumentoPrecioPublicoListaPrecio)
                .IsRequired(false);

            builder.Property(x => x.TipoValorPublicoListaPrecio)
                .IsRequired(false);

            // Propiedades de Navegacion

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Familias)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Articulos)
                .WithOne(x => x.Familia)
                .HasForeignKey(x => x.FamiliaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.FamiliaCajas)
                .WithOne(x => x.Familia)
                .HasForeignKey(x => x.FamiliaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.FamiliaListaPrecios)
                .WithOne(x => x.Familia)
                .HasForeignKey(x => x.FamiliaId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}