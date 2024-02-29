using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class CamposAutorizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DescuentoAutorizacion",
                table: "ConfiguracionCores",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "EmpleadoAutorizaId",
                table: "ConfiguracionCores",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PedirAutorizacion",
                table: "ConfiguracionCores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PedirAutorizacionDescuento",
                table: "ConfiguracionCores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NecesitaAutorizacion",
                table: "Articulos",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescuentoAutorizacion",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "EmpleadoAutorizaId",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "PedirAutorizacion",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "PedirAutorizacionDescuento",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "NecesitaAutorizacion",
                table: "Articulos");
        }
    }
}
