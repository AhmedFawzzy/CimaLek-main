﻿// <auto-generated />
using System;
using CimaLek.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CimaLek.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211101192537_UpdataDlete1")]
    partial class UpdataDlete1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CimaLek.Models.Author", b =>
                {
                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageURl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("CimaLek.Models.AuthorToFilm", b =>
                {
                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("authorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("filmId", "authorId");

                    b.HasIndex("authorId");

                    b.ToTable("AuthorToFilms");
                });

            modelBuilder.Entity("CimaLek.Models.AuthorToSeries", b =>
                {
                    b.Property<string>("serieId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("authorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("serieId", "authorId");

                    b.HasIndex("authorId");

                    b.ToTable("AuthorToSeries");
                });

            modelBuilder.Entity("CimaLek.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Entertment.Models.episode", b =>
                {
                    b.Property<int>("Episode_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Episode_num")
                        .HasColumnType("int");

                    b.Property<string>("SerieId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Episode_Id");

                    b.HasIndex("SerieId");

                    b.ToTable("episode");
                });

            modelBuilder.Entity("Entertment.Models.episodeWatch", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("episodeId")
                        .HasColumnType("int");

                    b.Property<string>("seriesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LinkId");

                    b.HasIndex("episodeId");

                    b.HasIndex("seriesId");

                    b.ToTable("episodeWatch");
                });

            modelBuilder.Entity("Entertment.Models.film", b =>
                {
                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describtion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerURl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("filmId");

                    b.ToTable("films");
                });

            modelBuilder.Entity("Entertment.Models.filmSeriesType", b =>
                {
                    b.Property<int>("typeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("typeID");

                    b.ToTable("filmSeriesTypes");

                    b.HasData(
                        new
                        {
                            typeID = 1,
                            type = "aomance"
                        },
                        new
                        {
                            typeID = 2,
                            type = "action"
                        },
                        new
                        {
                            typeID = 3,
                            type = "animation"
                        },
                        new
                        {
                            typeID = 4,
                            type = "drama"
                        },
                        new
                        {
                            typeID = 5,
                            type = "comedy"
                        },
                        new
                        {
                            typeID = 6,
                            type = "history"
                        },
                        new
                        {
                            typeID = 7,
                            type = "war"
                        },
                        new
                        {
                            typeID = 8,
                            type = "CV"
                        },
                        new
                        {
                            typeID = 9,
                            type = "mystery"
                        },
                        new
                        {
                            typeID = 10,
                            type = "murder"
                        },
                        new
                        {
                            typeID = 11,
                            type = "fiction"
                        },
                        new
                        {
                            typeID = 12,
                            type = "scary"
                        },
                        new
                        {
                            typeID = 14,
                            type = "sport"
                        },
                        new
                        {
                            typeID = 15,
                            type = "adventure"
                        },
                        new
                        {
                            typeID = 16,
                            type = "musical "
                        },
                        new
                        {
                            typeID = 17,
                            type = "documentary "
                        });
                });

            modelBuilder.Entity("Entertment.Models.filmWatch", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerName4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LinkId");

                    b.HasIndex("filmId");

                    b.ToTable("filmWatches");
                });

            modelBuilder.Entity("Entertment.Models.filmtype", b =>
                {
                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("typeId")
                        .HasColumnType("int");

                    b.HasKey("filmId", "typeId");

                    b.HasIndex("typeId");

                    b.ToTable("filmtypes");
                });

            modelBuilder.Entity("Entertment.Models.serie", b =>
                {
                    b.Property<string>("seriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describtion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerURl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("seriesId");

                    b.ToTable("serie");
                });

            modelBuilder.Entity("Entertment.Models.serieType", b =>
                {
                    b.Property<string>("serieId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("typeId")
                        .HasColumnType("int");

                    b.HasKey("serieId", "typeId");

                    b.HasIndex("typeId");

                    b.ToTable("serieTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CimaLek.Models.AuthorToFilm", b =>
                {
                    b.HasOne("CimaLek.Models.Author", "Author")
                        .WithMany("AuthorToFilms")
                        .HasForeignKey("authorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entertment.Models.film", "film")
                        .WithMany("AuthorToFilms")
                        .HasForeignKey("filmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("film");
                });

            modelBuilder.Entity("CimaLek.Models.AuthorToSeries", b =>
                {
                    b.HasOne("CimaLek.Models.Author", "Author")
                        .WithMany("AuthorToSeries")
                        .HasForeignKey("authorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entertment.Models.serie", "serie")
                        .WithMany("AuthorToSeries")
                        .HasForeignKey("serieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("serie");
                });

            modelBuilder.Entity("Entertment.Models.episode", b =>
                {
                    b.HasOne("Entertment.Models.serie", "serie")
                        .WithMany("episodes")
                        .HasForeignKey("SerieId");

                    b.Navigation("serie");
                });

            modelBuilder.Entity("Entertment.Models.episodeWatch", b =>
                {
                    b.HasOne("Entertment.Models.episode", "episode")
                        .WithMany("episodeWatches")
                        .HasForeignKey("episodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entertment.Models.serie", null)
                        .WithMany("episodeWatches")
                        .HasForeignKey("seriesId");

                    b.Navigation("episode");
                });

            modelBuilder.Entity("Entertment.Models.filmWatch", b =>
                {
                    b.HasOne("Entertment.Models.film", "film")
                        .WithMany("filmWatches")
                        .HasForeignKey("filmId");

                    b.Navigation("film");
                });

            modelBuilder.Entity("Entertment.Models.filmtype", b =>
                {
                    b.HasOne("Entertment.Models.film", "film")
                        .WithMany("filmtypes")
                        .HasForeignKey("filmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entertment.Models.filmSeriesType", "type")
                        .WithMany("filmtypes")
                        .HasForeignKey("typeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("film");

                    b.Navigation("type");
                });

            modelBuilder.Entity("Entertment.Models.serieType", b =>
                {
                    b.HasOne("Entertment.Models.serie", "serie")
                        .WithMany("serieTypes")
                        .HasForeignKey("serieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entertment.Models.filmSeriesType", "type")
                        .WithMany("serieTypes")
                        .HasForeignKey("typeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("serie");

                    b.Navigation("type");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CimaLek.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CimaLek.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CimaLek.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CimaLek.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CimaLek.Models.Author", b =>
                {
                    b.Navigation("AuthorToFilms");

                    b.Navigation("AuthorToSeries");
                });

            modelBuilder.Entity("Entertment.Models.episode", b =>
                {
                    b.Navigation("episodeWatches");
                });

            modelBuilder.Entity("Entertment.Models.film", b =>
                {
                    b.Navigation("AuthorToFilms");

                    b.Navigation("filmtypes");

                    b.Navigation("filmWatches");
                });

            modelBuilder.Entity("Entertment.Models.filmSeriesType", b =>
                {
                    b.Navigation("filmtypes");

                    b.Navigation("serieTypes");
                });

            modelBuilder.Entity("Entertment.Models.serie", b =>
                {
                    b.Navigation("AuthorToSeries");

                    b.Navigation("episodes");

                    b.Navigation("episodeWatches");

                    b.Navigation("serieTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
