using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddCampoTarjeta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {           
            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaId",
                table: "Tarjetas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "PlanTarjetas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Tarjetas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "PlanTarjetas");
        }
    }
}
