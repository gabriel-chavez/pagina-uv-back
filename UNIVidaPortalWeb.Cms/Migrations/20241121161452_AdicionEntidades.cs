using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class AdicionEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannerPaginaPrincipal",
                schema: "PaginaDinamica");

            migrationBuilder.CreateTable(
                name: "CatEstiloBanner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEstiloBanner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoBannerPaginaPrincipal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoBannerPaginaPrincipal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BannerPaginaPrincipalMaestro",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CatTipoBannerPaginaPrincipalId = table.Column<int>(type: "integer", nullable: false),
                    CatEstiloBannerId = table.Column<int>(type: "integer", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPaginaPrincipalMaestro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerPaginaPrincipalMaestro_CatEstiloBanner_CatEstiloBanne~",
                        column: x => x.CatEstiloBannerId,
                        principalTable: "CatEstiloBanner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannerPaginaPrincipalMaestro_CatTipoBannerPaginaPrincipal_C~",
                        column: x => x.CatTipoBannerPaginaPrincipalId,
                        principalTable: "CatTipoBannerPaginaPrincipal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BannerPaginaPrincipalDetalle",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    Enlace = table.Column<string>(type: "text", nullable: false),
                    RecursoId = table.Column<int>(type: "integer", nullable: false),
                    BannerPaginaPrincipalMaestroId = table.Column<int>(type: "integer", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPaginaPrincipalDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerPaginaPrincipalDetalle_BannerPaginaPrincipalMaestro_B~",
                        column: x => x.BannerPaginaPrincipalMaestroId,
                        principalSchema: "PaginaDinamica",
                        principalTable: "BannerPaginaPrincipalMaestro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannerPaginaPrincipalDetalle_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalSchema: "Recurso",
                        principalTable: "Recursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaPrincipalDetalle_BannerPaginaPrincipalMaestroId",
                schema: "PaginaDinamica",
                table: "BannerPaginaPrincipalDetalle",
                column: "BannerPaginaPrincipalMaestroId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaPrincipalDetalle_RecursoId",
                schema: "PaginaDinamica",
                table: "BannerPaginaPrincipalDetalle",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaPrincipalMaestro_CatEstiloBannerId",
                schema: "PaginaDinamica",
                table: "BannerPaginaPrincipalMaestro",
                column: "CatEstiloBannerId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaPrincipalMaestro_CatTipoBannerPaginaPrincipalId",
                schema: "PaginaDinamica",
                table: "BannerPaginaPrincipalMaestro",
                column: "CatTipoBannerPaginaPrincipalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannerPaginaPrincipalDetalle",
                schema: "PaginaDinamica");

            migrationBuilder.DropTable(
                name: "BannerPaginaPrincipalMaestro",
                schema: "PaginaDinamica");

            migrationBuilder.DropTable(
                name: "CatEstiloBanner");

            migrationBuilder.DropTable(
                name: "CatTipoBannerPaginaPrincipal");

            migrationBuilder.CreateTable(
                name: "BannerPaginaPrincipal",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecursoId = table.Column<int>(type: "integer", nullable: false),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    Enlace = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    NroSlider = table.Column<int>(type: "integer", nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    Titulo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPaginaPrincipal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerPaginaPrincipal_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalSchema: "Recurso",
                        principalTable: "Recursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaPrincipal_RecursoId",
                schema: "PaginaDinamica",
                table: "BannerPaginaPrincipal",
                column: "RecursoId");
        }
    }
}
