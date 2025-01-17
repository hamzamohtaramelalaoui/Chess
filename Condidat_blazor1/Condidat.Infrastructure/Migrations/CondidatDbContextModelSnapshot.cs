﻿// <auto-generated />
using System;
using Condidat.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Condidat.Infrastructure.Migrations
{
    [DbContext(typeof(CondidatDbContext))]
    partial class CondidatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Condidat.Domain.Entities.Commune", b =>
                {
                    b.Property<string>("CommuneId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VilleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommuneId");

                    b.HasIndex("VilleId");

                    b.ToTable("Communes");

                    b.HasData(
                        new
                        {
                            CommuneId = "1",
                            Name = "Assilah",
                            VilleId = "10"
                        },
                        new
                        {
                            CommuneId = "2",
                            Name = "M'diq-Fnideq",
                            VilleId = "10"
                        },
                        new
                        {
                            CommuneId = "3",
                            Name = "Fahs-Anjra",
                            VilleId = "10"
                        },
                        new
                        {
                            CommuneId = "4",
                            Name = "Larache",
                            VilleId = "11"
                        },
                        new
                        {
                            CommuneId = "5",
                            Name = "Ouezzane",
                            VilleId = "11"
                        },
                        new
                        {
                            CommuneId = "7",
                            Name = "Elhajeb",
                            VilleId = "8"
                        },
                        new
                        {
                            CommuneId = "8",
                            Name = "Boulmane",
                            VilleId = "9"
                        },
                        new
                        {
                            CommuneId = "9",
                            Name = "Taounate",
                            VilleId = "9"
                        },
                        new
                        {
                            CommuneId = "10",
                            Name = "Skhirat-Temara",
                            VilleId = "1"
                        },
                        new
                        {
                            CommuneId = "11",
                            Name = "Khemissat",
                            VilleId = "1"
                        },
                        new
                        {
                            CommuneId = "12",
                            Name = "Sidi kasem",
                            VilleId = "3"
                        },
                        new
                        {
                            CommuneId = "13",
                            Name = "Sidi Sliman",
                            VilleId = "2"
                        },
                        new
                        {
                            CommuneId = "14",
                            Name = "Mohemmedia",
                            VilleId = "4"
                        },
                        new
                        {
                            CommuneId = "15",
                            Name = "Nouacer",
                            VilleId = "4"
                        },
                        new
                        {
                            CommuneId = "16",
                            Name = "Sidi Bennour",
                            VilleId = "5"
                        },
                        new
                        {
                            CommuneId = "17",
                            Name = "Chichaoua",
                            VilleId = "6"
                        },
                        new
                        {
                            CommuneId = "18",
                            Name = "Al Haouz",
                            VilleId = "6"
                        },
                        new
                        {
                            CommuneId = "19",
                            Name = "Rehamna",
                            VilleId = "7"
                        },
                        new
                        {
                            CommuneId = "20",
                            Name = "Youssofia",
                            VilleId = "7"
                        });
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Condidate", b =>
                {
                    b.Property<string>("CondidatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Situation")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sexe")
                        .HasColumnType("int");

                    b.Property<string>("ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CondidatId");

                    b.ToTable("Condidats");
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Region", b =>
                {
                    b.Property<string>("RegionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            RegionId = "1",
                            Name = "Rabat,Sale,Kenitra"
                        },
                        new
                        {
                            RegionId = "2",
                            Name = "Casablanca,Settat"
                        },
                        new
                        {
                            RegionId = "3",
                            Name = "Marrakech-Safi"
                        },
                        new
                        {
                            RegionId = "4",
                            Name = "Fes,Meknes"
                        },
                        new
                        {
                            RegionId = "5",
                            Name = "Tnger,Tetouin,Al houcaima"
                        });
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Ville", b =>
                {
                    b.Property<string>("VilleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("VilleId");

                    b.HasIndex("RegionId");

                    b.ToTable("Villes");

                    b.HasData(
                        new
                        {
                            VilleId = "1",
                            Name = "Rabat",
                            RegionId = "1"
                        },
                        new
                        {
                            VilleId = "2",
                            Name = "Sale",
                            RegionId = "1"
                        },
                        new
                        {
                            VilleId = "3",
                            Name = "kenitra",
                            RegionId = "1"
                        },
                        new
                        {
                            VilleId = "4",
                            Name = "Casablanca",
                            RegionId = "2"
                        },
                        new
                        {
                            VilleId = "5",
                            Name = "Settat",
                            RegionId = "2"
                        },
                        new
                        {
                            VilleId = "6",
                            Name = "Marrakech",
                            RegionId = "3"
                        },
                        new
                        {
                            VilleId = "7",
                            Name = "Safi",
                            RegionId = "3"
                        },
                        new
                        {
                            VilleId = "8",
                            Name = "Fes",
                            RegionId = "4"
                        },
                        new
                        {
                            VilleId = "9",
                            Name = "Meknes",
                            RegionId = "4"
                        },
                        new
                        {
                            VilleId = "10",
                            Name = "Tanger",
                            RegionId = "5"
                        },
                        new
                        {
                            VilleId = "11",
                            Name = "Tetouin",
                            RegionId = "5"
                        },
                        new
                        {
                            VilleId = "12",
                            Name = "Al houcaima",
                            RegionId = "5"
                        });
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Commune", b =>
                {
                    b.HasOne("Condidat.Domain.Entities.Ville", "Ville")
                        .WithMany("Communes")
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ville");
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Ville", b =>
                {
                    b.HasOne("Condidat.Domain.Entities.Region", "Region")
                        .WithMany("Villes")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Region", b =>
                {
                    b.Navigation("Villes");
                });

            modelBuilder.Entity("Condidat.Domain.Entities.Ville", b =>
                {
                    b.Navigation("Communes");
                });
#pragma warning restore 612, 618
        }
    }
}
