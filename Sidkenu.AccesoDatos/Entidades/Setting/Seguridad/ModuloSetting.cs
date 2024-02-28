using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class ModuloSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.Seguridad)
                .IsRequired();

            builder.Property(x => x.PuntoVenta)
                .IsRequired();

            builder.Property(x => x.Inventario)
                .IsRequired();

            builder.Property(x => x.Compra)
                .IsRequired();

            builder.Property(x => x.Fabricacion)
                .IsRequired();

            builder.Property(x => x.Venta)
                .IsRequired();

            builder.Property(x => x.Caja)
                .IsRequired();

            builder.Property(x => x.Dashboard)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Modulos)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
