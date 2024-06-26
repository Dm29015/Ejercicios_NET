﻿// <auto-generated />
using ComerciPlus.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComerciPlus.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240622185242_ApiComerciPlus")]
    partial class ApiComerciPlus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComerciPlus.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApellidoCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CedulaCliente")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DireccionCliente")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("EstadoCliente")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("TelefonoCliente")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CedulaCliente")
                        .IsUnique();

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ComerciPlus.Models.Credito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("AbonosTotal")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("DeudaActual")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("DeudaTotal")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("Credito");
                });

            modelBuilder.Entity("ComerciPlus.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DireccionEmpresa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NombreVendedor")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TelefonoEmpresa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("ComerciPlus.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ComerciPlus.Models.Credito", b =>
                {
                    b.HasOne("ComerciPlus.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
