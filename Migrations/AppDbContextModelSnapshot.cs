﻿// <auto-generated />
using System;
using Lista_de_tarefas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lista_de_tarefas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lista_de_tarefas.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = "trabalho",
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = "casa",
                            Nome = "Casa"
                        },
                        new
                        {
                            CategoriaId = "faculdade",
                            Nome = "Faculdade"
                        },
                        new
                        {
                            CategoriaId = "compras",
                            Nome = "Compras"
                        },
                        new
                        {
                            CategoriaId = "academia",
                            Nome = "Academia"
                        });
                });

            modelBuilder.Entity("Lista_de_tarefas.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "aberto",
                            Nome = "Aberto"
                        },
                        new
                        {
                            StatusId = "completo",
                            Nome = "Completo"
                        });
                });

            modelBuilder.Entity("Lista_de_tarefas.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DataDeVencimento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("StatusId");

                    b.ToTable("tarefas");
                });

            modelBuilder.Entity("Lista_de_tarefas.Models.Tarefa", b =>
                {
                    b.HasOne("Lista_de_tarefas.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lista_de_tarefas.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
