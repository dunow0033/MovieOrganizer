﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieOrganizer.Data;

#nullable disable

namespace MovieOrganizer.Migrations
{
    [DbContext(typeof(MovieDBContext))]
    [Migration("20241030233209_updating user interface")]
    partial class updatinguserinterface
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieOrganizer.Models.Domain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Action",
                            Rating = "R",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Action",
                            Rating = "R",
                            Title = "The Rock"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Action",
                            Rating = "R",
                            Title = "The Terminator"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Action",
                            Rating = "R",
                            Title = "Gladiator"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Action",
                            Rating = "R",
                            Title = "The Departed"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Comedy",
                            Rating = "PG",
                            Title = "Beetlejuice"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Comedy",
                            Rating = "PG",
                            Title = "Ghostbusters"
                        });
                });

            modelBuilder.Entity("MovieOrganizer.Models.Domain.MovieLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieLogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comments = "Great Action",
                            MovieId = 4,
                            Title = "Gladiator",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            Comments = "Sean Connery was great",
                            MovieId = 2,
                            Title = "The Rock",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Comments = "Great Special Effects",
                            MovieId = 1,
                            Title = "The Matrix",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Comments = "Michael Keaton was hilarious",
                            MovieId = 6,
                            Title = "Beetlejuice",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Comments = "Great comedy and special effects",
                            MovieId = 7,
                            Title = "Ghostbusters",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("MovieOrganizer.Models.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ff774316-9eb3-4ffc-9233-43890175f1a0",
                            Email = "chris@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Chris",
                            PasswordHash = "AQAAAAIAAYagAAAAEEcogbEC9OQg3tyvNtNoL19se2uE2QR7pCdcXSVhP0rssv9PzS68urhJ4P29Y+h68w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95719580-999e-4814-a163-2434c9ec822e",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "30d31012-5c80-401e-ad34-91045579e840",
                            Email = "dan@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Dan",
                            PasswordHash = "AQAAAAIAAYagAAAAEM9Ei9LbUR8SIUcyAo6Qhmp8ZT+LtuQ8k3u7rxShYmFVf+NLOCOjoiurASDhPJ1rew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3ea3d67f-1274-46eb-a76f-40e1370430f3",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb3fb9c5-2841-4b41-9978-b125e6423eff",
                            Email = "tom@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Tom",
                            PasswordHash = "AQAAAAIAAYagAAAAEJIPgiF8LKHyy56qhkkhc9B2HsaY1aqGqm5bxZBqeWG1QexOEVmgeTNWHQqWR6LsMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "805ec9b2-6d52-4bb6-a298-386600541692",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("MovieOrganizer.Models.Domain.MovieLog", b =>
                {
                    b.HasOne("MovieOrganizer.Models.Domain.Movie", null)
                        .WithMany("MovieLogs")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieOrganizer.Models.Domain.User", "User")
                        .WithMany("MovieLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MovieOrganizer.Models.Domain.User", b =>
                {
                    b.HasOne("MovieOrganizer.Models.Domain.Movie", null)
                        .WithMany("Users")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieOrganizer.Models.Domain.Movie", b =>
                {
                    b.Navigation("MovieLogs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("MovieOrganizer.Models.Domain.User", b =>
                {
                    b.Navigation("MovieLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
