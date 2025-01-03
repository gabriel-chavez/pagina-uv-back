﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UNIVidaPortalWeb.Noticias.Repositories;

#nullable disable

namespace UNIVidaPortalWeb.Noticias.Migrations
{
    [DbContext(typeof(DbContextNoticias))]
    partial class DbContextNoticiasModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Noticias.NoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Etiquetas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Orden")
                        .HasColumnType("integer");

                    b.Property<int>("ParCategoriaId")
                        .HasColumnType("integer");

                    b.Property<int>("ParEstadoId")
                        .HasColumnType("integer");

                    b.Property<int?>("RecursoId_ImagenPrincipal")
                        .HasColumnType("integer");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TituloCorto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParCategoriaId");

                    b.HasIndex("ParEstadoId");

                    b.HasIndex("RecursoId_ImagenPrincipal");

                    b.ToTable("Noticia", "Noticias");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Noticias.RecursoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ParTipoRecursoId")
                        .HasColumnType("integer");

                    b.Property<string>("RecursoEscritorio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecursoMovil")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParTipoRecursoId");

                    b.ToTable("Recurso", "Noticias");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Parametricas.ParCategoriaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ParCategoria", "Parametricas");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Parametricas.ParEstadoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ParEstado", "Parametricas");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Parametricas.ParTipoRecursoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ParTipoRecurso", "Parametricas");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Noticias.NoticiaModel", b =>
                {
                    b.HasOne("UNIVidaPortalWeb.Noticias.Models.Parametricas.ParCategoriaModel", "ParCategoria")
                        .WithMany()
                        .HasForeignKey("ParCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UNIVidaPortalWeb.Noticias.Models.Parametricas.ParEstadoModel", "ParEstado")
                        .WithMany()
                        .HasForeignKey("ParEstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UNIVidaPortalWeb.Noticias.Models.Noticias.RecursoModel", "Recurso")
                        .WithMany("Noticia")
                        .HasForeignKey("RecursoId_ImagenPrincipal");

                    b.Navigation("ParCategoria");

                    b.Navigation("ParEstado");

                    b.Navigation("Recurso");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Noticias.RecursoModel", b =>
                {
                    b.HasOne("UNIVidaPortalWeb.Noticias.Models.Parametricas.ParTipoRecursoModel", "ParTipoRecurso")
                        .WithMany()
                        .HasForeignKey("ParTipoRecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParTipoRecurso");
                });

            modelBuilder.Entity("UNIVidaPortalWeb.Noticias.Models.Noticias.RecursoModel", b =>
                {
                    b.Navigation("Noticia");
                });
#pragma warning restore 612, 618
        }
    }
}
