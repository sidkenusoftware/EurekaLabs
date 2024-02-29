using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddCambioPresicionMontosEnComprobante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Neto",
                table: "ComprobanteTotales",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Iva",
                table: "ComprobanteTotales",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Alicuota",
                table: "ComprobanteTotales",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Comprobantes",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Comprobantes",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Descuento",
                table: "Comprobantes",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "ComprobanteDetalles",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Neto",
                table: "ComprobanteDetalles",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Iva",
                table: "ComprobanteDetalles",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                table: "ComprobanteDetalles",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Alicuota",
                table: "ComprobanteDetalles",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "ComprobanteDetalleFabricaciones",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioPublico",
                table: "ComprobanteDetalleFabricaciones",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                table: "ComprobanteDetalleFabricaciones",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Neto",
                table: "ComprobanteTotales",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Iva",
                table: "ComprobanteTotales",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Alicuota",
                table: "ComprobanteTotales",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Comprobantes",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Comprobantes",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Descuento",
                table: "Comprobantes",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "ComprobanteDetalles",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Neto",
                table: "ComprobanteDetalles",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Iva",
                table: "ComprobanteDetalles",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                table: "ComprobanteDetalles",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Alicuota",
                table: "ComprobanteDetalles",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "ComprobanteDetalleFabricaciones",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioPublico",
                table: "ComprobanteDetalleFabricaciones",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                table: "ComprobanteDetalleFabricaciones",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)",
                oldPrecision: 18,
                oldScale: 6);
        }
    }
}
