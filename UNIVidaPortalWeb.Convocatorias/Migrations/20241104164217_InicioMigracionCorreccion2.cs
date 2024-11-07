using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class InicioMigracionCorreccion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreadoPor",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModificadoPor",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreadoPor",
                schema: "Convocatorias",
                table: "Notificacion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                schema: "Convocatorias",
                table: "Notificacion",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                schema: "Convocatorias",
                table: "Notificacion",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModificadoPor",
                schema: "Convocatorias",
                table: "Notificacion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreadoPor",
                schema: "Convocatorias",
                table: "Convocatoria",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                schema: "Convocatorias",
                table: "Convocatoria",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                schema: "Convocatorias",
                table: "Convocatoria",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModificadoPor",
                schema: "Convocatorias",
                table: "Convocatoria",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreadoPor",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "CreadoPor",
                schema: "Convocatorias",
                table: "Notificacion");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                schema: "Convocatorias",
                table: "Notificacion");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                schema: "Convocatorias",
                table: "Notificacion");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                schema: "Convocatorias",
                table: "Notificacion");

            migrationBuilder.DropColumn(
                name: "CreadoPor",
                schema: "Convocatorias",
                table: "Convocatoria");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                schema: "Convocatorias",
                table: "Convocatoria");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                schema: "Convocatorias",
                table: "Convocatoria");

            migrationBuilder.DropColumn(
                name: "ModificadoPor",
                schema: "Convocatorias",
                table: "Convocatoria");
        }
    }
}
