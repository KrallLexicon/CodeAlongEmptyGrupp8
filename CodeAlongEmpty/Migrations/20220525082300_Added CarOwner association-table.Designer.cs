﻿// <auto-generated />
using CodeAlongEmpty.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeAlongEmpty.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220525082300_Added CarOwner association-table")]
    partial class AddedCarOwnerassociationtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeAlongEmpty.Models.Car", b =>
                {
                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegNumber");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CodeAlongEmpty.Models.CarOwner", b =>
                {
                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RegNumber", "SSN");

                    b.HasIndex("SSN");

                    b.ToTable("CarOwners");
                });

            modelBuilder.Entity("CodeAlongEmpty.Models.Person", b =>
                {
                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SSN");

                    b.ToTable("People");
                });

            modelBuilder.Entity("CodeAlongEmpty.Models.CarOwner", b =>
                {
                    b.HasOne("CodeAlongEmpty.Models.Car", "Car")
                        .WithMany("CarOwners")
                        .HasForeignKey("RegNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAlongEmpty.Models.Person", "Owner")
                        .WithMany("CarOwners")
                        .HasForeignKey("SSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
