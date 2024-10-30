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
    [Migration("20241029154712_initial migration")]
    partial class initialmigration
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
                            ConcurrencyStamp = "5c3ae68e-d4aa-48d2-a26b-a349b0ebfdf2",
                            Email = "chris@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Chris",
                            PasswordHash = "AQAAAAIAAYagAAAAENOnBy7o5RlHeB5Jb/MtmI4uH8uvwsJmFUtdPAB+KWK0MJ3jmv3w5aOMiIePzPnc4Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f830c409-58f4-475c-999b-ca16e8757455",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba2fcde8-e680-4d31-a7a3-a1188e2cd708",
                            Email = "dan@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Dan",
                            PasswordHash = "AQAAAAIAAYagAAAAEG3PGdL3Y1HbHEpuvIEfKrQGMP70XLfqL4ZgEQfGwDPLSAb3tpCxqDFp+9mDOvqDsA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bbd5f7c1-9615-4a73-91f6-c30863e2166d",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3cf7731f-8be2-4941-93ba-119a977fe35a",
                            Email = "tom@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Tom",
                            PasswordHash = "AQAAAAIAAYagAAAAEBLk8mM96F56k/fn+DJzvHL8adnhASu71DlYRVT3p4Myt+rfb6q95WMY9R5xLk2hpQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9edc77fd-3acc-4786-a038-c1590729f937",
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