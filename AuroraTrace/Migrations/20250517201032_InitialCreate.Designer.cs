﻿// <auto-generated />
using System;
using AuroraTrace.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace AuroraTrace.Migrations
{
    [DbContext(typeof(AuroraTraceContext))]
    [Migration("20250517201032_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Camera", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("InstaladaEm")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("instalada_em");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("nome");

                    b.Property<long>("PatioId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Posicao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("posicao");

                    b.HasKey("Id");

                    b.HasIndex("PatioId");

                    b.ToTable("Cameras", (string)null);
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Funcionario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("cargo");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("matricula");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios", (string)null);
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Imagem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CameraId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("CaminhoArquivo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)")
                        .HasColumnName("caminho_arquivo");

                    b.Property<DateTime>("CapturadaEm")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("capturada_em");

                    b.Property<long?>("MotoId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("CameraId");

                    b.HasIndex("MotoId");

                    b.ToTable("Imagens", (string)null);
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Localizacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("longitude");

                    b.Property<DateTime>("RegistradaEm")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("registrada_em");

                    b.HasKey("Id");

                    b.ToTable("Localizacoes", (string)null);
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Moto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("FuncionarioId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("LocalizacaoId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("modelo");

                    b.Property<long>("PatioId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("placa");

                    b.Property<int>("Status")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("status");

                    b.Property<DateTime>("UltimaAtualizacao")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("ultima_atualizacao");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("LocalizacaoId");

                    b.HasIndex("PatioId");

                    b.ToTable("Motos", (string)null);
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Patio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("cidade");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("nome");

                    b.Property<double>("TamanhoMetros")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("tamanho_metros");

                    b.HasKey("Id");

                    b.ToTable("Patios", (string)null);
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Camera", b =>
                {
                    b.HasOne("AuroraTrace.Domain.Entity.Patio", "Patio")
                        .WithMany()
                        .HasForeignKey("PatioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patio");
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Imagem", b =>
                {
                    b.HasOne("AuroraTrace.Domain.Entity.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AuroraTrace.Domain.Entity.Moto", "Moto")
                        .WithMany()
                        .HasForeignKey("MotoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Camera");

                    b.Navigation("Moto");
                });

            modelBuilder.Entity("AuroraTrace.Domain.Entity.Moto", b =>
                {
                    b.HasOne("AuroraTrace.Domain.Entity.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("AuroraTrace.Domain.Entity.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AuroraTrace.Domain.Entity.Patio", "Patio")
                        .WithMany()
                        .HasForeignKey("PatioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Funcionario");

                    b.Navigation("Localizacao");

                    b.Navigation("Patio");
                });
#pragma warning restore 612, 618
        }
    }
}
