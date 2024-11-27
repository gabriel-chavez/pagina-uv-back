using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class adicionpuntos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExperienciaPuntos",
                schema: "Convocatorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConvocatoriaId = table.Column<int>(type: "integer", nullable: false),
                    Desde = table.Column<int>(type: "integer", nullable: false),
                    Hasta = table.Column<int>(type: "integer", nullable: false),
                    Puntos = table.Column<int>(type: "integer", nullable: false),
                    Especifica = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaPuntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienciaPuntos_Convocatoria_ConvocatoriaId",
                        column: x => x.ConvocatoriaId,
                        principalSchema: "Convocatorias",
                        principalTable: "Convocatoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NivelFormacionPuntos",
                schema: "Convocatorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConvocatoriaId = table.Column<int>(type: "integer", nullable: false),
                    ParNivelFormacionId = table.Column<int>(type: "integer", nullable: false),
                    Puntos = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelFormacionPuntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NivelFormacionPuntos_Convocatoria_ConvocatoriaId",
                        column: x => x.ConvocatoriaId,
                        principalSchema: "Convocatorias",
                        principalTable: "Convocatoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NivelFormacionPuntos_ParNivelFormacion_ParNivelFormacionId",
                        column: x => x.ParNivelFormacionId,
                        principalSchema: "Parametricas",
                        principalTable: "ParNivelFormacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienciaPuntos_ConvocatoriaId",
                schema: "Convocatorias",
                table: "ExperienciaPuntos",
                column: "ConvocatoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_NivelFormacionPuntos_ConvocatoriaId",
                schema: "Convocatorias",
                table: "NivelFormacionPuntos",
                column: "ConvocatoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_NivelFormacionPuntos_ParNivelFormacionId",
                schema: "Convocatorias",
                table: "NivelFormacionPuntos",
                column: "ParNivelFormacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienciaPuntos",
                schema: "Convocatorias");

            migrationBuilder.DropTable(
                name: "NivelFormacionPuntos",
                schema: "Convocatorias");
        }
    }
}
