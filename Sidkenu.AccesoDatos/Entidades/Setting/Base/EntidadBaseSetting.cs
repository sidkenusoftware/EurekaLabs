using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Base
{
    public class EntidadBaseSetting : IEntityTypeConfiguration<EntidadBase>
    {
        public void Configure(EntityTypeBuilder<EntidadBase> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.User)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.EstaEliminado)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
