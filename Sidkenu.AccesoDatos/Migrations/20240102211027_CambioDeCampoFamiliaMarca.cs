using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class CambioDeCampoFamiliaMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.RenameColumn(
                name: "TipoValorPublicoImpuesto",
                table: "Marcas",
                newName: "TipoValorPublicoListaPrecio");

            migrationBuilder.RenameColumn(
                name: "AumentoPrecioPublicoImpuesto",
                table: "Marcas",
                newName: "AumentoPrecioPublicoListaPrecio");

            migrationBuilder.RenameColumn(
                name: "ActivarAumentoPrecioPublicoImpuesto",
                table: "Marcas",
                newName: "ActivarAumentoPrecioPublicoListaPrecio");

            migrationBuilder.RenameColumn(
                name: "TipoValorPublicoImpuesto",
                table: "Familias",
                newName: "TipoValorPublicoListaPrecio");

            migrationBuilder.RenameColumn(
                name: "AumentoPrecioPublicoImpuesto",
                table: "Familias",
                newName: "AumentoPrecioPublicoListaPrecio");

            migrationBuilder.RenameColumn(
                name: "ActivarAumentoPrecioPublicoImpuesto",
                table: "Familias",
                newName: "ActivarAumentoPrecioPublicoListaPrecio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoValorPublicoListaPrecio",
                table: "Marcas",
                newName: "TipoValorPublicoImpuesto");

            migrationBuilder.RenameColumn(
                name: "AumentoPrecioPublicoListaPrecio",
                table: "Marcas",
                newName: "AumentoPrecioPublicoImpuesto");

            migrationBuilder.RenameColumn(
                name: "ActivarAumentoPrecioPublicoListaPrecio",
                table: "Marcas",
                newName: "ActivarAumentoPrecioPublicoImpuesto");

            migrationBuilder.RenameColumn(
                name: "TipoValorPublicoListaPrecio",
                table: "Familias",
                newName: "TipoValorPublicoImpuesto");

            migrationBuilder.RenameColumn(
                name: "AumentoPrecioPublicoListaPrecio",
                table: "Familias",
                newName: "AumentoPrecioPublicoImpuesto");

            migrationBuilder.RenameColumn(
                name: "ActivarAumentoPrecioPublicoListaPrecio",
                table: "Familias",
                newName: "ActivarAumentoPrecioPublicoImpuesto");
        }
    }
}
