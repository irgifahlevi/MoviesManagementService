﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesManagement.DataAccess.Context;

#nullable disable

namespace MoviesManagement.DataAccess.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesID")
                        .HasColumnType("int");

                    b.HasKey("GenresID", "MoviesID");

                    b.HasIndex("MoviesID");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RowStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9397),
                            CreatedBy = "SYSTEM",
                            FirstName = "Johan",
                            LastName = "Malik",
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9413)
                        },
                        new
                        {
                            ID = 2,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9417),
                            CreatedBy = "SYSTEM",
                            FirstName = "Hannah",
                            LastName = "Lakley",
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9418)
                        });
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Biography", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RowStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ActorID")
                        .IsUnique();

                    b.ToTable("Biographies");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActorID = 1,
                            Age = 34,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9735),
                            CreatedBy = "SYSTEM",
                            Description = "",
                            Gender = "Male",
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9739)
                        },
                        new
                        {
                            ID = 2,
                            ActorID = 2,
                            Age = 28,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9743),
                            CreatedBy = "SYSTEM",
                            Description = "",
                            Gender = "Female",
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9744)
                        });
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RowStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RowStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ActorID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActorID = 1,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9786),
                            CreatedBy = "SYSTEM",
                            Description = "The legend movies",
                            Duration = "2 Hours",
                            MovieName = "Avatar",
                            Rating = 4.9000000000000004,
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9788)
                        },
                        new
                        {
                            ID = 2,
                            ActorID = 1,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9794),
                            CreatedBy = "SYSTEM",
                            Description = "In The End",
                            Duration = "1 Hours",
                            MovieName = "Transformers 3",
                            Rating = 4.5,
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9795)
                        },
                        new
                        {
                            ID = 3,
                            ActorID = 2,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9797),
                            CreatedBy = "SYSTEM",
                            Description = "Zombie world war",
                            Duration = "1.5 Hours",
                            MovieName = "Umbrella",
                            Rating = 4.2999999999999998,
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9798)
                        },
                        new
                        {
                            ID = 5,
                            ActorID = 2,
                            CreatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9801),
                            CreatedBy = "SYSTEM",
                            Description = "The collection funny movies",
                            Duration = "2 Hours",
                            MovieName = "No Party No Hapy",
                            Rating = 4.9000000000000004,
                            RowStatus = 0,
                            UpdatedAt = new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9802)
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("MoviesManagement.Domain.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesManagement.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Biography", b =>
                {
                    b.HasOne("MoviesManagement.Domain.Entities.Actor", "Actor")
                        .WithOne("Biography")
                        .HasForeignKey("MoviesManagement.Domain.Entities.Biography", "ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Movie", b =>
                {
                    b.HasOne("MoviesManagement.Domain.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Actor", b =>
                {
                    b.Navigation("Biography");

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}