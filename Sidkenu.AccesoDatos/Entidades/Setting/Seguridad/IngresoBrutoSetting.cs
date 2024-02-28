using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class IngresoBrutoSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<IngresoBruto>
    {
        public void Configure(EntityTypeBuilder<IngresoBruto> builder)
        {
            // Propiedades

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasMany(x => x.Empresas)
                .WithOne(x => x.IngresoBruto)
                .HasForeignKey(x => x.IngresoBrutoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
