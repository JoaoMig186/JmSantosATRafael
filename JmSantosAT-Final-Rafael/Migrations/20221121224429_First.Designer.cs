﻿// <auto-generated />
using System;
using JmSantosAT_Final_Rafael.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JmSantosAT_Final_Rafael.Migrations
{
    [DbContext(typeof(JmSantosAT_Final_RafaelContext))]
    [Migration("20221121224429_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AmigoId1")
                        .HasColumnType("int");

                    b.Property<string>("AmigoNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmigoSobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmigoTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AniversarioAmigo")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoAmigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemAmigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisAmigo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AmigoId");

                    b.HasIndex("AmigoId1");

                    b.ToTable("Amigo");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Amigo", b =>
                {
                    b.HasOne("JmSantosAT_Final_Rafael.Models.Amigo", null)
                        .WithMany("AmigosLista")
                        .HasForeignKey("AmigoId1");
                });

            modelBuilder.Entity("JmSantosAT_Final_Rafael.Models.Amigo", b =>
                {
                    b.Navigation("AmigosLista");
                });
#pragma warning restore 612, 618
        }
    }
}