using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ComprobanteSalonSetting : ComprobanteSetting,
        IEntityTypeConfiguration<ComprobanteSalon>
    {
        public void Configure(EntityTypeBuilder<ComprobanteSalon> builder)
        {
            // Propiedades
            builder.Property(x => x.MesaId)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Mesa)
                .WithMany(x => x.ComprobantesSalones)
                .HasForeignKey(x => x.MesaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
