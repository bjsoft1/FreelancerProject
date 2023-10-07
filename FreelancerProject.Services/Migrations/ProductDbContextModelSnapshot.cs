﻿// <auto-generated />
using System;
using FreelancerProject.Services.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FreelancerProject.Services.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FreelancerProject.Models.Product.ProductModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("Image")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("image");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModificationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<float>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(0f);

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50000"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/0.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-0",
                            Price = 1500f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50001"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/1.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-1",
                            Price = 1620f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50002"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/2.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-2",
                            Price = 1740f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50003"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/3.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-3",
                            Price = 1860f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50004"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/4.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-4",
                            Price = 1980f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50005"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/5.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-5",
                            Price = 2100f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50006"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/6.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-6",
                            Price = 2220f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50007"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/7.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-7",
                            Price = 2340f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50008"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/8.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-8",
                            Price = 2460f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50009"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/9.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-9",
                            Price = 2580f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50010"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/10.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-10",
                            Price = 2700f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50011"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/11.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-11",
                            Price = 2820f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50012"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/12.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-12",
                            Price = 2940f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50013"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/13.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-13",
                            Price = 3060f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50014"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/14.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-14",
                            Price = 3180f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50015"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/15.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-15",
                            Price = 3300f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50016"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/16.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-16",
                            Price = 3420f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50017"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/17.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-17",
                            Price = 3540f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50018"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/18.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-18",
                            Price = 3660f
                        },
                        new
                        {
                            Id = new Guid("a9f06a70-8dfd-4e64-9c4c-42614ec50019"),
                            CreationTime = new DateTime(2023, 10, 7, 15, 44, 0, 0, DateTimeKind.Unspecified),
                            Image = "assets/images/products/19.png",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "My Product-19",
                            Price = 3780f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
