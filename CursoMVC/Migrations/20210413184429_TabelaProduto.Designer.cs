﻿// <auto-generated />
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CursoMVC.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210413184429_TabelaProduto")]
    partial class TabelaProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CursoMVC.Models.Categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("CursoMVC.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoriaId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CursoMVC.Models.Produto", b =>
                {
                    b.HasOne("CursoMVC.Models.Categoria", "categoria")
                        .WithMany("produtos")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}