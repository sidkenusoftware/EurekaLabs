using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class MedioPagoEnCaja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AceptaMedioPagoCheque",
                table: "Cajas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AceptaMedioPagoCtaCte",
                table: "Cajas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AceptaMedioPagoEfectivo",
                table: "Cajas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AceptaMedioPagoTarjeta",
                table: "Cajas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AceptaMedioPagoTransferencia",
                table: "Cajas",
                type: "bit",
                nullable: false,
                defaultValue: false);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AceptaMedioPagoCheque",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "AceptaMedioPagoCtaCte",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "AceptaMedioPagoEfectivo",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "AceptaMedioPagoTarjeta",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "AceptaMedioPagoTransferencia",
                table: "Cajas");
        }
    }
}
