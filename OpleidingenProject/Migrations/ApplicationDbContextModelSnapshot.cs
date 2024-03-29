﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpleidingenProject.Data;

namespace OpleidingenProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OpleidingenProject.Data.CustomUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Achternaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GeboorteDatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Voornaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OpleidingenProject.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorieen");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Naam = "Retail banking"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Naam = "Verzekeringen"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Naam = "Kredieten"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Naam = "Duurzaamheid"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Naam = "Boekhouding"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Naam = "Corporate Banking"
                        });
                });

            modelBuilder.Entity("OpleidingenProject.Models.Inschrijving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SessieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomUserId");

                    b.HasIndex("SessieId");

                    b.ToTable("Inschrijvingen");
                });

            modelBuilder.Entity("OpleidingenProject.Models.Opleiding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AantalUren")
                        .HasColumnType("int");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Niveau")
                        .HasColumnType("int");

                    b.Property<int>("Taal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Opleidingen");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AantalUren = 60,
                            Beschrijving = "Korte introductie tot de wereld van verzekeringen",
                            CategorieId = 2,
                            IsDeleted = false,
                            Naam = "Verzekeringen voor beginners",
                            Niveau = 0,
                            Taal = 0
                        },
                        new
                        {
                            Id = 2,
                            AantalUren = 20,
                            Beschrijving = "Korte introductie tot de wereld van kredieten",
                            CategorieId = 3,
                            IsDeleted = false,
                            Naam = "Kredieten voor beginners",
                            Niveau = 0,
                            Taal = 2
                        },
                        new
                        {
                            Id = 3,
                            AantalUren = 50,
                            Beschrijving = "Duurzaam investeren is de toekomst.",
                            CategorieId = 4,
                            IsDeleted = false,
                            Naam = "Duurzaamheid, de wereld van morgen",
                            Niveau = 2,
                            Taal = 1
                        },
                        new
                        {
                            Id = 4,
                            AantalUren = 100,
                            Beschrijving = "Intensieve opleiding gaande van FX naar cash management",
                            CategorieId = 6,
                            IsDeleted = false,
                            Naam = "Kapitaal en markten",
                            Niveau = 1,
                            Taal = 0
                        },
                        new
                        {
                            Id = 5,
                            AantalUren = 60,
                            Beschrijving = "Opleiding voor professionelen ",
                            CategorieId = 5,
                            IsDeleted = false,
                            Naam = "Fiscaliteit en boekhouding",
                            Niveau = 2,
                            Taal = 2
                        });
                });

            modelBuilder.Entity("OpleidingenProject.Models.Sessie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AantalPlaatsen")
                        .HasColumnType("int");

                    b.Property<DateTime>("EindDatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OpleidingId")
                        .HasColumnType("int");

                    b.Property<int>("Prijs")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeLeerVorm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OpleidingId");

                    b.ToTable("Sessies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AantalPlaatsen = 20,
                            EindDatum = new DateTime(2021, 6, 17, 10, 55, 20, 393, DateTimeKind.Local).AddTicks(9847),
                            IsDeleted = false,
                            OpleidingId = 1,
                            Prijs = 250,
                            StartDatum = new DateTime(2021, 6, 11, 10, 55, 20, 388, DateTimeKind.Local).AddTicks(27),
                            TypeLeerVorm = 1
                        },
                        new
                        {
                            Id = 2,
                            AantalPlaatsen = 40,
                            EindDatum = new DateTime(2021, 6, 14, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6605),
                            IsDeleted = false,
                            OpleidingId = 1,
                            Prijs = 150,
                            StartDatum = new DateTime(2021, 6, 9, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6582),
                            TypeLeerVorm = 2
                        },
                        new
                        {
                            Id = 3,
                            AantalPlaatsen = 50,
                            EindDatum = new DateTime(2021, 6, 21, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6699),
                            IsDeleted = false,
                            OpleidingId = 1,
                            Prijs = 150,
                            StartDatum = new DateTime(2021, 6, 15, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6696),
                            TypeLeerVorm = 2
                        },
                        new
                        {
                            Id = 4,
                            AantalPlaatsen = 15,
                            EindDatum = new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6706),
                            IsDeleted = false,
                            OpleidingId = 1,
                            Prijs = 102,
                            StartDatum = new DateTime(2021, 6, 13, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6704),
                            TypeLeerVorm = 1
                        },
                        new
                        {
                            Id = 5,
                            AantalPlaatsen = 5,
                            EindDatum = new DateTime(2021, 7, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6840),
                            IsDeleted = false,
                            OpleidingId = 2,
                            Prijs = 658,
                            StartDatum = new DateTime(2021, 6, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6834),
                            TypeLeerVorm = 3
                        },
                        new
                        {
                            Id = 6,
                            AantalPlaatsen = 30,
                            EindDatum = new DateTime(2021, 7, 2, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6847),
                            IsDeleted = false,
                            OpleidingId = 2,
                            Prijs = 850,
                            StartDatum = new DateTime(2021, 6, 19, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6844),
                            TypeLeerVorm = 0
                        },
                        new
                        {
                            Id = 7,
                            AantalPlaatsen = 18,
                            EindDatum = new DateTime(2021, 6, 26, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6853),
                            IsDeleted = false,
                            OpleidingId = 2,
                            Prijs = 150,
                            StartDatum = new DateTime(2021, 6, 15, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6850),
                            TypeLeerVorm = 1
                        },
                        new
                        {
                            Id = 8,
                            AantalPlaatsen = 10,
                            EindDatum = new DateTime(2021, 6, 25, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6859),
                            IsDeleted = false,
                            OpleidingId = 3,
                            Prijs = 480,
                            StartDatum = new DateTime(2021, 6, 14, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6856),
                            TypeLeerVorm = 0
                        },
                        new
                        {
                            Id = 9,
                            AantalPlaatsen = 18,
                            EindDatum = new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6866),
                            IsDeleted = false,
                            OpleidingId = 3,
                            Prijs = 455,
                            StartDatum = new DateTime(2021, 6, 13, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6862),
                            TypeLeerVorm = 3
                        },
                        new
                        {
                            Id = 10,
                            AantalPlaatsen = 30,
                            EindDatum = new DateTime(2021, 6, 22, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6872),
                            IsDeleted = false,
                            OpleidingId = 4,
                            Prijs = 846,
                            StartDatum = new DateTime(2021, 6, 16, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6869),
                            TypeLeerVorm = 1
                        },
                        new
                        {
                            Id = 11,
                            AantalPlaatsen = 50,
                            EindDatum = new DateTime(2021, 6, 26, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6878),
                            IsDeleted = false,
                            OpleidingId = 5,
                            Prijs = 975,
                            StartDatum = new DateTime(2021, 6, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6875),
                            TypeLeerVorm = 2
                        },
                        new
                        {
                            Id = 12,
                            AantalPlaatsen = 40,
                            EindDatum = new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6884),
                            IsDeleted = false,
                            OpleidingId = 5,
                            Prijs = 105,
                            StartDatum = new DateTime(2021, 6, 22, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6881),
                            TypeLeerVorm = 1
                        },
                        new
                        {
                            Id = 13,
                            AantalPlaatsen = 60,
                            EindDatum = new DateTime(2021, 7, 2, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6891),
                            IsDeleted = false,
                            OpleidingId = 5,
                            Prijs = 804,
                            StartDatum = new DateTime(2021, 6, 27, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6887),
                            TypeLeerVorm = 0
                        },
                        new
                        {
                            Id = 14,
                            AantalPlaatsen = 80,
                            EindDatum = new DateTime(2021, 8, 26, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6897),
                            IsDeleted = false,
                            OpleidingId = 5,
                            Prijs = 642,
                            StartDatum = new DateTime(2021, 7, 17, 10, 55, 20, 394, DateTimeKind.Local).AddTicks(6894),
                            TypeLeerVorm = 2
                        });
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
                    b.HasOne("OpleidingenProject.Data.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OpleidingenProject.Data.CustomUser", null)
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

                    b.HasOne("OpleidingenProject.Data.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OpleidingenProject.Data.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpleidingenProject.Models.Inschrijving", b =>
                {
                    b.HasOne("OpleidingenProject.Data.CustomUser", "CustomUser")
                        .WithMany("Inschrijvingen")
                        .HasForeignKey("CustomUserId");

                    b.HasOne("OpleidingenProject.Models.Sessie", "Sessie")
                        .WithMany("Inschrijvingen")
                        .HasForeignKey("SessieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpleidingenProject.Models.Opleiding", b =>
                {
                    b.HasOne("OpleidingenProject.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpleidingenProject.Models.Sessie", b =>
                {
                    b.HasOne("OpleidingenProject.Models.Opleiding", "Opleiding")
                        .WithMany("Sessies")
                        .HasForeignKey("OpleidingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
