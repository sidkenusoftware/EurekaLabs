using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class balanza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.DropColumn(
                name: "ConfiguracionPorPeso",
                table: "ConfiguracionBalanzas");

            migrationBuilder.AlterColumn<int>(
                name: "LongitudTotal",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "InicioIdentificarTipo",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "InicioIdentificarImportePrecio",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "InicioIdentificarCodigoArcitulo",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "FinIdentificarTipo",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "FinIdentificarImportePrecio",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "FinIdentificarCodigoArcitulo",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "DecimalesImporte",
                table: "ConfiguracionBalanzas",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "DecimalPeso",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoIdentificarPeso",
                table: "ConfiguracionBalanzas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoIdentificarImporte",
                table: "ConfiguracionBalanzas",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "LongitudTotal",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "InicioIdentificarTipo",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "InicioIdentificarImportePrecio",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "InicioIdentificarCodigoArcitulo",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinIdentificarTipo",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinIdentificarImportePrecio",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "FinIdentificarCodigoArcitulo",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "DecimalesImporte",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "DecimalPeso",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoIdentificarPeso",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoIdentificarImporte",
                table: "ConfiguracionBalanzas",
                type: "decimal(18,2)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<bool>(
                name: "ConfiguracionPorPeso",
                table: "ConfiguracionBalanzas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
