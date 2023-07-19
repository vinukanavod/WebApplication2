﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webapplication2.Database;

#nullable disable

namespace Webapplication2.Database.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20230714054431_Authorupdate")]
    partial class Authorupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication2.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "vinuka",
                            LastName = "navod"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "kavindu",
                            LastName = "hasintha"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "pravindu",
                            LastName = "bhashitha"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Nethmi",
                            LastName = "anjani"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Nethmi",
                            LastName = "Nishara"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Todoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Animal")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Animal = 0,
                            AuthorId = 1,
                            Created = new DateTime(2023, 7, 14, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2466),
                            Description = " A",
                            Due = new DateTime(2023, 7, 19, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2480),
                            Status = 2,
                            Title = "row 1 "
                        },
                        new
                        {
                            Id = 2,
                            Animal = 0,
                            AuthorId = 2,
                            Created = new DateTime(2023, 7, 14, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2485),
                            Description = " B",
                            Due = new DateTime(2023, 7, 20, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2486),
                            Status = 1,
                            Title = "row 2"
                        },
                        new
                        {
                            Id = 3,
                            Animal = 0,
                            AuthorId = 3,
                            Created = new DateTime(2023, 7, 14, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2487),
                            Description = "C",
                            Due = new DateTime(2023, 7, 21, 11, 14, 30, 896, DateTimeKind.Local).AddTicks(2487),
                            Status = 2,
                            Title = "row 3 "
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Todoomommy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Todoomommies");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Description = "Hello Machan KOhomada IThin.....",
                            Name = "Vinuka Nvod",
                            number = 714703776
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Todoo", b =>
                {
                    b.HasOne("WebApplication2.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
