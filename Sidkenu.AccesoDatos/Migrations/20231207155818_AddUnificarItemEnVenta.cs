using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddUnificarItemEnVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.AddColumn<bool>(
                name: "UnificarRenglonesIngresarMismoArticulo",
                table: "ConfiguracionCores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.DropColumn(
                name: "UnificarRenglonesIngresarMismoArticulo",
                table: "ConfiguracionCores");            
        }
    }
}
