﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perfumeria.Data;

#nullable disable

namespace Perfumeria.Migrations
{
    [DbContext(typeof(PerfumeriaContex))]
    partial class PerfumeriaContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Perfumeria.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Perfumeria"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Costumbre"
                        });
                });

            modelBuilder.Entity("Perfumeria.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<int?>("MetodoDePagoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MetodoDePagoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Ramiro"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Valentin"
                        });
                });

            modelBuilder.Entity("Perfumeria.Models.MetodoDePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MetodosDePago");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "MercadoPago"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Efectivo"
                        });
                });

            modelBuilder.Entity("Perfumeria.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaProducto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaProducto = 0,
                            Nombre = "Boos"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaProducto = 0,
                            Nombre = "Esmalte"
                        });
                });

            modelBuilder.Entity("Perfumeria.Models.Cliente", b =>
                {
                    b.HasOne("Perfumeria.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.HasOne("Perfumeria.Models.MetodoDePago", "MetodoDePago")
                        .WithMany()
                        .HasForeignKey("MetodoDePagoId");

                    b.HasOne("Perfumeria.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");

                    b.Navigation("Area");

                    b.Navigation("MetodoDePago");

                    b.Navigation("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
