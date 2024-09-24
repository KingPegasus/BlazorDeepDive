﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerManagement.Data;

#nullable disable

namespace ServerManagement.Migrations
{
    [DbContext(typeof(ServerManagementContext))]
    [Migration("20240924100032_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServerManagement.Models.Server", b =>
                {
                    b.Property<int>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServerId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServerId");

                    b.ToTable("Servers");

                    b.HasData(
                        new
                        {
                            ServerId = 1,
                            City = "Toronto",
                            IsOnline = false,
                            Name = "Server1"
                        },
                        new
                        {
                            ServerId = 2,
                            City = "Toronto",
                            IsOnline = false,
                            Name = "Server2"
                        },
                        new
                        {
                            ServerId = 3,
                            City = "Toronto",
                            IsOnline = false,
                            Name = "Server3"
                        },
                        new
                        {
                            ServerId = 4,
                            City = "Toronto",
                            IsOnline = false,
                            Name = "Server4"
                        },
                        new
                        {
                            ServerId = 5,
                            City = "Montreal",
                            IsOnline = true,
                            Name = "Server5"
                        },
                        new
                        {
                            ServerId = 6,
                            City = "Montreal",
                            IsOnline = false,
                            Name = "Server6"
                        },
                        new
                        {
                            ServerId = 7,
                            City = "Montreal",
                            IsOnline = false,
                            Name = "Server7"
                        },
                        new
                        {
                            ServerId = 8,
                            City = "Ottawa",
                            IsOnline = false,
                            Name = "Server8"
                        },
                        new
                        {
                            ServerId = 9,
                            City = "Ottawa",
                            IsOnline = true,
                            Name = "Server9"
                        },
                        new
                        {
                            ServerId = 10,
                            City = "Calgary",
                            IsOnline = true,
                            Name = "Server10"
                        },
                        new
                        {
                            ServerId = 11,
                            City = "Calgary",
                            IsOnline = false,
                            Name = "Server11"
                        },
                        new
                        {
                            ServerId = 12,
                            City = "Halifax",
                            IsOnline = true,
                            Name = "Server12"
                        },
                        new
                        {
                            ServerId = 13,
                            City = "Halifax",
                            IsOnline = false,
                            Name = "Server13"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
