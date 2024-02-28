using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ArticuloSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            // Propiedades

            builder.Property(x => x.EmpresaId)
                .IsRequired(false);

            builder.Property(x => x.ArticuloPadreId)
                .IsRequired(false);

            builder.Property(x => x.FamiliaId)
                .IsRequired();

            builder.Property(x => x.UnidadMedidaVentaId)
                .IsRequired();

            builder.Property(x => x.UnidadMedidaCompraId)
                .IsRequired();

            builder.Property(x => x.CondicionIvaId)
                .IsRequired();

            builder.Property(x => x.VarianteValorUnoId)
                .IsRequired();

            builder.Property(x => x.VarianteValorDosId)
                .IsRequired();

            builder.Property(x => x.MarcaId)
                .IsRequired();

            builder.Property(x => x.PerfilArticulo)
                .IsRequired();

            builder.Property(x => x.TipoArticulo)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.Abreviatura)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.DescripcionAdicional)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.CodigoBarra)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Detalle)
                .HasMaxLength(4000)
                .IsRequired(false);

            builder.Property(x => x.Foto)
                .IsRequired();

            builder.Property(x => x.PermiteStockNegativo)
                .IsRequired();

            builder.Property(x => x.TienePerdida)
                .IsRequired();

            builder.Property(x => x.PorcentajePerdida).HasPrecision(18, 6)
                .IsRequired(false);

            builder.Property(x => x.ActivarLimiteVenta)
                .IsRequired();

            builder.Property(x => x.LimiteVenta).HasPrecision(18, 6)
                .IsRequired(false);

            builder.Property(x => x.EstaBloqueado)
                .IsRequired();

            builder.Property(x => x.Comision)
                .HasPrecision(18, 2)
                .IsRequired(false);

            builder.Property(x => x.ActivarBonificacion)
                .IsRequired();

            builder.Property(x => x.Bonificacion)
                .HasPrecision(18, 6)
                .IsRequired(false);

            builder.Property(x => x.TipoBonificacion)
                .IsRequired(false);

            builder.Property(x => x.BonificacionFechaDesde)
                .IsRequired(false);

            builder.Property(x => x.BonificacionFechaHasta)
                .IsRequired(false);

            builder.Property(x => x.TieneGarantia)
                .IsRequired();

            builder.Property(x => x.Garantia)
                .IsRequired(false);

            builder.Property(x => x.StockMaximo).HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.StockMinimo).HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.PuntoPedido).HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.TieneRentabilidad)
                .IsRequired();

            builder.Property(x => x.Rentabilidad).HasPrecision(18, 6)
               .IsRequired(false);

            builder.Property(x => x.PrecioCosto).HasPrecision(18, 6)
               .IsRequired();

            builder.Property(x => x.FechaVigenciaKit)
               .IsRequired(false);

            builder.Property(x => x.FacturacionPorImporte)
               .IsRequired();

            builder.Property(x => x.NecesitaAutorizacion)
               .IsRequired();

            builder.Property(x => x.PermiteMostrarFormula)
               .IsRequired();

            // Propiedades de Navegacion

            builder.HasMany(x => x.ArticuloHistorialCostos)
                    .WithOne(x => x.Articulo)
                    .HasForeignKey(x => x.ArticuloId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Articulos)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Familia)
                .WithMany(x => x.Articulos)
                .HasForeignKey(x => x.FamiliaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.CondicionIva)
                .WithMany(x => x.Articulos)
                .HasForeignKey(x => x.CondicionIvaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Marca)
                .WithMany(x => x.Articulos)
                .HasForeignKey(x => x.MarcaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.UnidadMedidaVenta)
                .WithMany(x => x.ArticulosVentas)
                .HasForeignKey(x => x.UnidadMedidaVentaId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.UnidadMedidaCompra)
                .WithMany(x => x.ArticulosCompras)
                .HasForeignKey(x => x.UnidadMedidaCompraId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.VarianteValorUno)
                .WithMany(x => x.ArticuloUnos)
                .HasForeignKey(x => x.VarianteValorUnoId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.VarianteValorDos)
                .WithMany(x => x.ArticuloDos)
                .HasForeignKey(x => x.VarianteValorDosId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ArticuloHijoKits)
                .WithOne(x => x.ArticuloHijo)
                .HasForeignKey(x => x.ArticuloHijoId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ArticuloPadreKits)
                .WithOne(x => x.ArticuloPadre)
                .HasForeignKey(x => x.ArticuloPadreId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ArticuloHijoOpcionales)
                .WithOne(x => x.ArticuloHijo)
                .HasForeignKey(x => x.ArticuloHijoId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ArticuloPadreOpcionales)
                .WithOne(x => x.ArticuloPadre)
                .HasForeignKey(x => x.ArticuloPadreId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.OrdenFabricacionDetalles)
                .WithOne(x => x.Articulo)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Detalles)
                .WithOne(x => x.Articulo)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}