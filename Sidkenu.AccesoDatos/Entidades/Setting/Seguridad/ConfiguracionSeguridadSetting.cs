using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class ConfiguracionSeguridadSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ConfiguracionSeguridad>
    {
        public void Configure(EntityTypeBuilder<ConfiguracionSeguridad> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.LoginNormal)
                .IsRequired();

            builder.Property(x => x.UsuarioCredencial)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.PasswordCredencial)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Puerto)
                .IsRequired();

            builder.Property(x => x.Host)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.LogError)
                .IsRequired();

            builder.Property(x => x.LogWarning)
                .IsRequired();

            builder.Property(x => x.LogInformacion)
                .IsRequired();

            builder.Property(x => x.EnviarMailCreateUsuario)
                .IsRequired();
        }
    }
}
