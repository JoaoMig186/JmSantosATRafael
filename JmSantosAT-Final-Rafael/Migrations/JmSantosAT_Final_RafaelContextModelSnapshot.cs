﻿// <auto-generated />
using System;
using JmSantosAT_Final_Rafael.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JmSantosAT_Final_Rafael.Migrations
{
    [DbContext(typeof(JmSantosAT_Final_RafaelContext))]
    partial class JmSantosAT_Final_RafaelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Amigo", b =>
                {
                    b.Property<int>("AmigoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmigoId"), 1L, 1);

                    b.Property<string>("AmigoEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AmigoId1")
                        .HasColumnType("int");

                    b.Property<string>("AmigoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmigoSobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmigoTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AniversarioAmigo")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoAmigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemAmigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisAmigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AmigoId");

                    b.HasIndex("AmigoId1");

                    b.ToTable("Amigo");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Estado", b =>
                {
                    b.Property<int>("EstadosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadosId"), 1L, 1);

                    b.Property<string>("EstadoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadosNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("EstadosId");

                    b.HasIndex("PaisId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaisId"), 1L, 1);

                    b.Property<int>("EstadosId")
                        .HasColumnType("int");

                    b.Property<string>("PaisImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaisId");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Amigo", b =>
                {
                    b.HasOne("JmSantosAT_Final_Rafael.Models.Amigo", null)
                        .WithMany("AmigosLista")
                        .HasForeignKey("AmigoId1");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Estado", b =>
                {
                    b.HasOne("JmSantosAT_Final_Rafael.Models.Pais", "Paises")
                        .WithMany("EstadoLista")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Amigo", b =>
                {
                    b.Navigation("AmigosLista");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Pais", b =>
                {
                    b.Navigation("EstadoLista");
                });
#pragma warning restore 612, 618
        }
    }
}
