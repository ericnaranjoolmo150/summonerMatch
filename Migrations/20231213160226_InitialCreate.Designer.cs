﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SummonerMatch;

#nullable disable

namespace SummonerMatch.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231213160226_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SummonerMatch.Equipo", b =>
                {
                    b.Property<int>("IdEquipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipo"), 1L, 1);

                    b.Property<int?>("FkRangoEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("IdPartida")
                        .HasColumnType("int");

                    b.Property<bool?>("PosicionAdc")
                        .HasColumnType("bit");

                    b.Property<bool?>("PosicionJungla")
                        .HasColumnType("bit");

                    b.Property<bool?>("PosicionMid")
                        .HasColumnType("bit");

                    b.Property<bool?>("PosicionSupport")
                        .HasColumnType("bit");

                    b.Property<bool?>("PosicionTop")
                        .HasColumnType("bit");

                    b.HasKey("IdEquipo");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("SummonerMatch.ImagenPerfil", b =>
                {
                    b.Property<int>("IdImagenPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdImagenPerfil"), 1L, 1);

                    b.Property<byte[]>("ArchivoImagen")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("IdImagenPerfil");

                    b.ToTable("ImagenPerfil");
                });

            modelBuilder.Entity("SummonerMatch.Partida", b =>
                {
                    b.Property<int>("IdCardPartida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCardPartida"), 1L, 1);

                    b.Property<int?>("FKIdTorneo")
                        .HasColumnType("int");

                    b.Property<int?>("FkIdCreador")
                        .HasColumnType("int");

                    b.Property<int?>("FkTipoPartida")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HoraCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraExpiracion")
                        .HasColumnType("datetime2");

                    b.Property<string>("posicionAdc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posicionJungle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posicionMid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posicionSupport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posicionTop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tituloPartida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCardPartida");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("SummonerMatch.Posicion", b =>
                {
                    b.Property<int>("IdPosicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPosicion"), 1L, 1);

                    b.Property<string>("NombrePosicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPosicion");

                    b.ToTable("Posicion");
                });

            modelBuilder.Entity("SummonerMatch.Rango", b =>
                {
                    b.Property<int>("IdRango")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRango"), 1L, 1);

                    b.Property<string>("NombreRango")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRango");

                    b.ToTable("Rango");
                });

            modelBuilder.Entity("SummonerMatch.RegionServidor", b =>
                {
                    b.Property<int>("IdRegionServidor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegionServidor"), 1L, 1);

                    b.Property<string>("NombreRegion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRegionServidor");

                    b.ToTable("RegionServidor");
                });

            modelBuilder.Entity("SummonerMatch.TipoPartida", b =>
                {
                    b.Property<int>("IdTipoPartida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPartida"), 1L, 1);

                    b.Property<string>("NombreTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoPartida");

                    b.ToTable("TipoPartida");
                });

            modelBuilder.Entity("SummonerMatch.Torneo", b =>
                {
                    b.Property<int>("IdTorneo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTorneo"), 1L, 1);

                    b.Property<int?>("CantEquipos")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionTorneo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FkIdCreador")
                        .HasColumnType("int");

                    b.Property<string>("NombreTorneo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTorneo");

                    b.ToTable("Torneo");
                });

            modelBuilder.Entity("SummonerMatch.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"), 1L, 1);

                    b.Property<bool?>("admin")
                        .HasColumnType("bit");

                    b.Property<string>("correoElectonico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("fkIdEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("fkImagenPerfil")
                        .HasColumnType("int");

                    b.Property<int?>("fkPosicion")
                        .HasColumnType("int");

                    b.Property<int?>("fkRango")
                        .HasColumnType("int");

                    b.Property<int?>("fkRegionServidor")
                        .HasColumnType("int");

                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userNickname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SummonerMatch.Valoracion", b =>
                {
                    b.Property<int>("IdValoracion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdValoracion"), 1L, 1);

                    b.Property<int?>("FkUsuario")
                        .HasColumnType("int");

                    b.Property<float?>("Media")
                        .HasColumnType("real");

                    b.Property<int?>("NumValoraciones")
                        .HasColumnType("int");

                    b.HasKey("IdValoracion");

                    b.ToTable("Valoracion");
                });
#pragma warning restore 612, 618
        }
    }
}