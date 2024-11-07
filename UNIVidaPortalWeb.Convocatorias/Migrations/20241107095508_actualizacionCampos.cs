using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadDiasDisponibilidad",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DisponibilidadInmediata",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NombreParentescoFuncionario",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PretensionSalarial",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "TieneParentescoConFuncionario",
                schema: "Convocatorias",
                table: "Postulacion",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ExperienciaLaboral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    Empresa = table.Column<string>(type: "text", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    Sector = table.Column<string>(type: "text", nullable: false),
                    NroDependientes = table.Column<int>(type: "integer", nullable: false),
                    NombreSuperior = table.Column<string>(type: "text", nullable: false),
                    CargoSuperior = table.Column<string>(type: "text", nullable: false),
                    TelefonoEmpresa = table.Column<string>(type: "text", nullable: false),
                    Funciones = table.Column<string>(type: "text", nullable: false),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaConclusion = table.Column<DateOnly>(type: "date", nullable: false),
                    MotivoDesvinculacion = table.Column<string>(type: "text", nullable: false),
                    ActualmenteTrabajando = table.Column<bool>(type: "boolean", nullable: false),
                    ExperienciaGeneral = table.Column<bool>(type: "boolean", nullable: false),
                    ExperienciaEspecifica = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaLaboral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienciaLaboral_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienciaLaboral_PostulanteId",
                table: "ExperienciaLaboral",
                column: "PostulanteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienciaLaboral");

            migrationBuilder.DropColumn(
                name: "CantidadDiasDisponibilidad",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "DisponibilidadInmediata",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "NombreParentescoFuncionario",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "PretensionSalarial",
                schema: "Convocatorias",
                table: "Postulacion");

            migrationBuilder.DropColumn(
                name: "TieneParentescoConFuncionario",
                schema: "Convocatorias",
                table: "Postulacion");
        }
    }
}
