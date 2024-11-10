using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Convocatorias.Migrations
{
    /// <inheritdoc />
    public partial class InicioMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Postulantes");

            migrationBuilder.EnsureSchema(
                name: "Convocatorias");

            migrationBuilder.CreateTable(
                name: "ParEstadoConvocatoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParEstadoConvocatoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParEstadoPostulacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Notificar = table.Column<bool>(type: "boolean", nullable: false),
                    ContenidoNotificacion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParEstadoPostulacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParIdioma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParIdioma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParNivelConocimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParNivelConocimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParNivelFormacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParNivelFormacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParParentesco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParParentesco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParPrograma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParPrograma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParTipoCapacitacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParTipoCapacitacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Postulante",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "text", nullable: false),
                    DocumentoExpedido = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CiudadNacimiento = table.Column<string>(type: "text", nullable: false),
                    PaisNacimiento = table.Column<string>(type: "text", nullable: false),
                    CiudadResidencia = table.Column<string>(type: "text", nullable: false),
                    PaisResidencia = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Zona = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    TelefonoMovil = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Convocatoria",
                schema: "Convocatorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    ParEstadoConvocatoriaId = table.Column<int>(type: "integer", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaTermino = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PuntajeMinimo = table.Column<int>(type: "integer", nullable: false),
                    PuntajeTotal = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convocatoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Convocatoria_ParEstadoConvocatoria_ParEstadoConvocatoriaId",
                        column: x => x.ParEstadoConvocatoriaId,
                        principalTable: "ParEstadoConvocatoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Capacitacion",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    ParTipoCapacitacionId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CentroEstudios = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    HorasAcademicas = table.Column<int>(type: "integer", nullable: false),
                    Modalidad = table.Column<string>(type: "text", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capacitacion_ParTipoCapacitacion_ParTipoCapacitacionId",
                        column: x => x.ParTipoCapacitacionId,
                        principalTable: "ParTipoCapacitacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Capacitacion_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConocimientoIdioma",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    ParIdiomaId = table.Column<int>(type: "integer", nullable: false),
                    ParNivelConocimientoLecturaId = table.Column<int>(type: "integer", nullable: false),
                    ParNivelConocimientoEscrituraId = table.Column<int>(type: "integer", nullable: false),
                    ParNivelConocimientoConversacionId = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConocimientoIdioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConocimientoIdioma_ParIdioma_ParIdiomaId",
                        column: x => x.ParIdiomaId,
                        principalTable: "ParIdioma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConocimientoIdioma_ParNivelConocimiento_ParNivelConocimient~",
                        column: x => x.ParNivelConocimientoConversacionId,
                        principalTable: "ParNivelConocimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConocimientoIdioma_ParNivelConocimiento_ParNivelConocimien~1",
                        column: x => x.ParNivelConocimientoEscrituraId,
                        principalTable: "ParNivelConocimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConocimientoIdioma_ParNivelConocimiento_ParNivelConocimien~2",
                        column: x => x.ParNivelConocimientoLecturaId,
                        principalTable: "ParNivelConocimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConocimientoIdioma_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConocimientoSistemas",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    ParProgramaId = table.Column<int>(type: "integer", nullable: false),
                    ParNivelConocimientoId = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConocimientoSistemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConocimientoSistemas_ParNivelConocimiento_ParNivelConocimie~",
                        column: x => x.ParNivelConocimientoId,
                        principalTable: "ParNivelConocimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConocimientoSistemas_ParPrograma_ParProgramaId",
                        column: x => x.ParProgramaId,
                        principalTable: "ParPrograma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConocimientoSistemas_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormacionAcademica",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    ParNivelFormacionId = table.Column<int>(type: "integer", nullable: false),
                    CentroEstudios = table.Column<string>(type: "text", nullable: false),
                    TituloObtenido = table.Column<string>(type: "text", nullable: false),
                    FechaTitulo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Ciudad = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacionAcademica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_ParNivelFormacion_ParNivelFormacionId",
                        column: x => x.ParNivelFormacionId,
                        principalTable: "ParNivelFormacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormacionAcademica_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferenciaLaboral",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    Empresa = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    TelefonoMovil = table.Column<string>(type: "text", nullable: false),
                    Relacion = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenciaLaboral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferenciaLaboral_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferenciaPersonal",
                schema: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    Empresa = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: false),
                    TelefonoMovil = table.Column<string>(type: "text", nullable: false),
                    ParParentescoId = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenciaPersonal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferenciaPersonal_ParParentesco_ParParentescoId",
                        column: x => x.ParParentescoId,
                        principalTable: "ParParentesco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReferenciaPersonal_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Postulacion",
                schema: "Convocatorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConvocatoriaId = table.Column<int>(type: "integer", nullable: false),
                    PostulanteId = table.Column<int>(type: "integer", nullable: false),
                    FechaPostulacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PuntajeObtenido = table.Column<int>(type: "integer", nullable: false),
                    ParEstadoPostulacionId = table.Column<int>(type: "integer", nullable: false),
                    PostulanteDatosJSON = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postulacion_Convocatoria_ConvocatoriaId",
                        column: x => x.ConvocatoriaId,
                        principalSchema: "Convocatorias",
                        principalTable: "Convocatoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulacion_ParEstadoPostulacion_ParEstadoPostulacionId",
                        column: x => x.ParEstadoPostulacionId,
                        principalTable: "ParEstadoPostulacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulacion_Postulante_PostulanteId",
                        column: x => x.PostulanteId,
                        principalSchema: "Postulantes",
                        principalTable: "Postulante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notificacion",
                schema: "Convocatorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostulacionId = table.Column<int>(type: "integer", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificacion_Postulacion_PostulacionId",
                        column: x => x.PostulacionId,
                        principalSchema: "Convocatorias",
                        principalTable: "Postulacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Capacitacion_ParTipoCapacitacionId",
                schema: "Postulantes",
                table: "Capacitacion",
                column: "ParTipoCapacitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Capacitacion_PostulanteId",
                schema: "Postulantes",
                table: "Capacitacion",
                column: "PostulanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoIdioma_ParIdiomaId",
                schema: "Postulantes",
                table: "ConocimientoIdioma",
                column: "ParIdiomaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoIdioma_ParNivelConocimientoConversacionId",
                schema: "Postulantes",
                table: "ConocimientoIdioma",
                column: "ParNivelConocimientoConversacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoIdioma_ParNivelConocimientoEscrituraId",
                schema: "Postulantes",
                table: "ConocimientoIdioma",
                column: "ParNivelConocimientoEscrituraId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoIdioma_ParNivelConocimientoLecturaId",
                schema: "Postulantes",
                table: "ConocimientoIdioma",
                column: "ParNivelConocimientoLecturaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoIdioma_PostulanteId",
                schema: "Postulantes",
                table: "ConocimientoIdioma",
                column: "PostulanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoSistemas_ParNivelConocimientoId",
                schema: "Postulantes",
                table: "ConocimientoSistemas",
                column: "ParNivelConocimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoSistemas_ParProgramaId",
                schema: "Postulantes",
                table: "ConocimientoSistemas",
                column: "ParProgramaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConocimientoSistemas_PostulanteId",
                schema: "Postulantes",
                table: "ConocimientoSistemas",
                column: "PostulanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Convocatoria_ParEstadoConvocatoriaId",
                schema: "Convocatorias",
                table: "Convocatoria",
                column: "ParEstadoConvocatoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_ParNivelFormacionId",
                schema: "Postulantes",
                table: "FormacionAcademica",
                column: "ParNivelFormacionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormacionAcademica_PostulanteId",
                schema: "Postulantes",
                table: "FormacionAcademica",
                column: "PostulanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_PostulacionId",
                schema: "Convocatorias",
                table: "Notificacion",
                column: "PostulacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulacion_ConvocatoriaId",
                schema: "Convocatorias",
                table: "Postulacion",
                column: "ConvocatoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulacion_ParEstadoPostulacionId",
                schema: "Convocatorias",
                table: "Postulacion",
                column: "ParEstadoPostulacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulacion_PostulanteId",
                schema: "Convocatorias",
                table: "Postulacion",
                column: "PostulanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenciaLaboral_PostulanteId",
                schema: "Postulantes",
                table: "ReferenciaLaboral",
                column: "PostulanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenciaPersonal_ParParentescoId",
                schema: "Postulantes",
                table: "ReferenciaPersonal",
                column: "ParParentescoId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenciaPersonal_PostulanteId",
                schema: "Postulantes",
                table: "ReferenciaPersonal",
                column: "PostulanteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capacitacion",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "ConocimientoIdioma",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "ConocimientoSistemas",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "FormacionAcademica",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "Notificacion",
                schema: "Convocatorias");

            migrationBuilder.DropTable(
                name: "ReferenciaLaboral",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "ReferenciaPersonal",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "ParTipoCapacitacion");

            migrationBuilder.DropTable(
                name: "ParIdioma");

            migrationBuilder.DropTable(
                name: "ParNivelConocimiento");

            migrationBuilder.DropTable(
                name: "ParPrograma");

            migrationBuilder.DropTable(
                name: "ParNivelFormacion");

            migrationBuilder.DropTable(
                name: "Postulacion",
                schema: "Convocatorias");

            migrationBuilder.DropTable(
                name: "ParParentesco");

            migrationBuilder.DropTable(
                name: "Convocatoria",
                schema: "Convocatorias");

            migrationBuilder.DropTable(
                name: "ParEstadoPostulacion");

            migrationBuilder.DropTable(
                name: "Postulante",
                schema: "Postulantes");

            migrationBuilder.DropTable(
                name: "ParEstadoConvocatoria");
        }
    }
}
