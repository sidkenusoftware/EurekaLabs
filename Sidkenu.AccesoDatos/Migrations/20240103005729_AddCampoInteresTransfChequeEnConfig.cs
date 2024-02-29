using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddCampoInteresTransfChequeEnConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ActivarInteresPorCheque",
                table: "ConfiguracionCores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActivarInteresPorTransferencia",
                table: "ConfiguracionCores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "InteresPorCheque",
                table: "ConfiguracionCores",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InteresPorTransferencia",
                table: "ConfiguracionCores",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivarInteresPorCheque",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "ActivarInteresPorTransferencia",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "InteresPorCheque",
                table: "ConfiguracionCores");

            migrationBuilder.DropColumn(
                name: "InteresPorTransferencia",
                table: "ConfiguracionCores");
        }
    }
}
