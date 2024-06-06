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
    [Migration("20240528121444_UpdateClients")]
    partial class UpdateClients
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComerciPlus.Models.clientes", b =>
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

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ComerciPlus.Models.creditos", b =>
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

                    b.ToTable("creditos");
                });

            modelBuilder.Entity("ComerciPlus.Models.proveedores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("direccionEmpresa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nombreEmpresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("nombreVendedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("telefonoEmpresa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.ToTable("proveedores");
                });

            modelBuilder.Entity("ComerciPlus.Models.usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("ComerciPlus.Models.creditos", b =>
                {
                    b.HasOne("ComerciPlus.Models.clientes", "Cliente")
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
