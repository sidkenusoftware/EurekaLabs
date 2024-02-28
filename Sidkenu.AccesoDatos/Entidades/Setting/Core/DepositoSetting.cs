using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class DepositoSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Deposito>
    {
        public void Configure(EntityTypeBuilder<Deposito> builder)
        {
            // Propiedades

            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.PersonaId)
                .IsRequired(false);

            builder.Property(x => x.Abreviatura)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Direccion)
                .HasMaxLength(250)
                .IsRequired(false);

            builder.Property(x => x.TipoDeposito)
                .IsRequired();

            builder.Property(x => x.Predeterminado)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Depositos)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Persona)
                .WithMany(x => x.Depositos)
                .HasForeignKey(x => x.PersonaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ArticuloDepositos)
                .WithOne(x => x.Deposito)
                .HasForeignKey(x => x.DepositoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ConfiguracionCoreDepositoPorDefectoParaCompras)
                .WithOne(x => x.DepositoPorDefectoParaCompra)
                .HasForeignKey(x => x.DepositoPorDefectoParaCompraId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ConfiguracionCoreDepositoPorDefectoParaVentas)
                .WithOne(x => x.DepositoPorDefectoParaVenta)
                .HasForeignKey(x => x.DepositoPorDefectoParaVentaId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.OrdenFabricacionDestinos)
                .WithOne(x => x.DepositoDestino)
                .HasForeignKey(x => x.DepositoDestinoId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.OrdenFabricacionOrigenes)
                .WithOne(x => x.DepositoOrigen)
                .HasForeignKey(x => x.DepositoOrigenId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}