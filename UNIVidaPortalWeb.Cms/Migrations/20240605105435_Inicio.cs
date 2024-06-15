using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatTipoRecurso",
                columns: table => new
                {
                    CatTipoRecursoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoRecurso", x => x.CatTipoRecursoId);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoSeccion",
                columns: table => new
                {
                    CatTipoSeccionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoSeccion", x => x.CatTipoSeccionId);
                });

            migrationBuilder.CreateTable(
                name: "PaginasDinamicas",
                columns: table => new
                {
                    PaginaDinamicaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Ruta = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginasDinamicas", x => x.PaginaDinamicaId);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    RecursoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CatTipoRecursoId = table.Column<int>(type: "integer", nullable: false),
                    RecursoEscritorio = table.Column<string>(type: "text", nullable: false),
                    RecursoMovil = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.RecursoId);
                    table.ForeignKey(
                        name: "FK_Recursos_CatTipoRecurso_CatTipoRecursoId",
                        column: x => x.CatTipoRecursoId,
                        principalTable: "CatTipoRecurso",
                        principalColumn: "CatTipoRecursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                columns: table => new
                {
                    SeccionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CatTipoSeccionId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    SubTitulo = table.Column<string>(type: "text", nullable: false),
                    Clase = table.Column<string>(type: "text", nullable: false),
                    PaginaDinamicaId = table.Column<int>(type: "integer", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secciones", x => x.SeccionId);
                    table.ForeignKey(
                        name: "FK_Secciones_CatTipoSeccion_CatTipoSeccionId",
                        column: x => x.CatTipoSeccionId,
                        principalTable: "CatTipoSeccion",
                        principalColumn: "CatTipoSeccionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Secciones_PaginasDinamicas_PaginaDinamicaId",
                        column: x => x.PaginaDinamicaId,
                        principalTable: "PaginasDinamicas",
                        principalColumn: "PaginaDinamicaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BannerPaginaDinamica",
                columns: table => new
                {
                    BannerPaginaDinamicaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaginaDinamicaId = table.Column<int>(type: "integer", nullable: false),
                    RecursoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPaginaDinamica", x => x.BannerPaginaDinamicaId);
                    table.ForeignKey(
                        name: "FK_BannerPaginaDinamica_PaginasDinamicas_PaginaDinamicaId",
                        column: x => x.PaginaDinamicaId,
                        principalTable: "PaginasDinamicas",
                        principalColumn: "PaginaDinamicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannerPaginaDinamica_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recursos",
                        principalColumn: "RecursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Datos",
                columns: table => new
                {
                    DatoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatoTexto = table.Column<string>(type: "text", nullable: false),
                    DatoFechaHora = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DatoUrl = table.Column<string>(type: "text", nullable: false),
                    RecursoId = table.Column<int>(type: "integer", nullable: false),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    Fila = table.Column<int>(type: "integer", nullable: false),
                    Columna = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos", x => x.DatoId);
                    table.ForeignKey(
                        name: "FK_Datos_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recursos",
                        principalColumn: "RecursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Datos_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "SeccionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaDinamica_PaginaDinamicaId",
                table: "BannerPaginaDinamica",
                column: "PaginaDinamicaId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerPaginaDinamica_RecursoId",
                table: "BannerPaginaDinamica",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_RecursoId",
                table: "Datos",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_SeccionId",
                table: "Datos",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_CatTipoRecursoId",
                table: "Recursos",
                column: "CatTipoRecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_CatTipoSeccionId",
                table: "Secciones",
                column: "CatTipoSeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_PaginaDinamicaId",
                table: "Secciones",
                column: "PaginaDinamicaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannerPaginaDinamica");

            migrationBuilder.DropTable(
                name: "Datos");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Secciones");

            migrationBuilder.DropTable(
                name: "CatTipoRecurso");

            migrationBuilder.DropTable(
                name: "CatTipoSeccion");

            migrationBuilder.DropTable(
                name: "PaginasDinamicas");
        }
    }
}
