using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfiguracionBalanza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinIdentificarTipo",
                table: "ConfiguracionBalanzas",
                newName: "CantidadIdentificarTipo");

            migrationBuilder.RenameColumn(
                name: "FinIdentificarImportePrecio",
                table: "ConfiguracionBalanzas",
                newName: "CantidadIdentificarImportePrecio");

            migrationBuilder.RenameColumn(
                name: "FinIdentificarCodigoArcitulo",
                table: "ConfiguracionBalanzas",
                newName: "CantidadIdentificarCodigoArcitulo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CantidadIdentificarTipo",
                table: "ConfiguracionBalanzas",
                newName: "FinIdentificarTipo");

            migrationBuilder.RenameColumn(
                name: "CantidadIdentificarImportePrecio",
                table: "ConfiguracionBalanzas",
                newName: "FinIdentificarImportePrecio");

            migrationBuilder.RenameColumn(
                name: "CantidadIdentificarCodigoArcitulo",
                table: "ConfiguracionBalanzas",
                newName: "FinIdentificarCodigoArcitulo");
        }
    }
}
