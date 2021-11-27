﻿// <auto-generated />
using System;
using BankFinderAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankFinderAPI.Migrations
{
    [DbContext(typeof(BanksDbContext))]
    partial class BanksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("BankFinderAPI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuildingNumber")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<int>("PoBoxNumber")
                        .HasColumnType("int");

                    b.Property<string>("PoBoxZipCode")
                        .HasColumnType("text");

                    b.Property<string>("Post")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("Voivodeship")
                        .HasColumnType("text");

                    b.Property<string>("ZpiCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BankFinderAPI.Models.BicCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int>("SortCodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SortCodeId");

                    b.ToTable("BicCode");
                });

            modelBuilder.Entity("BankFinderAPI.Models.FaxNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("FaxNumber");
                });

            modelBuilder.Entity("BankFinderAPI.Models.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCompanyStart")
                        .HasColumnType("datetime");

                    b.Property<int>("InstitutionNumber")
                        .HasColumnType("int");

                    b.Property<string>("InstitutionSubType")
                        .HasColumnType("text");

                    b.Property<string>("InstitutionType")
                        .HasColumnType("text");

                    b.Property<string>("LEIIdent")
                        .HasColumnType("text");

                    b.Property<string>("Lettersymbol")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("TIN")
                        .HasColumnType("text");

                    b.Property<string>("WWW")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Institution");
                });

            modelBuilder.Entity("BankFinderAPI.Models.OpeningHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Friday")
                        .HasColumnType("text");

                    b.Property<string>("Monday")
                        .HasColumnType("text");

                    b.Property<string>("Thursday")
                        .HasColumnType("text");

                    b.Property<string>("Tuesday")
                        .HasColumnType("text");

                    b.Property<string>("Wednesday")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OpeningHours");
                });

            modelBuilder.Entity("BankFinderAPI.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("PhoneNumber");
                });

            modelBuilder.Entity("BankFinderAPI.Models.SortCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("CodeName")
                        .HasColumnType("text");

                    b.Property<DateTime>("GenerationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("SortCode");
                });

            modelBuilder.Entity("BankFinderAPI.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCompanyStart")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("InstitutionId")
                        .HasColumnType("int");

                    b.Property<string>("LetterSymbol")
                        .HasColumnType("text");

                    b.Property<int>("OpeningHoursId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("text");

                    b.Property<string>("UnitName")
                        .HasColumnType("text");

                    b.Property<string>("UnitType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("InstitutionId");

                    b.HasIndex("OpeningHoursId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("BankFinderAPI.Models.BicCode", b =>
                {
                    b.HasOne("BankFinderAPI.Models.SortCode", "SortCode")
                        .WithMany("BicCodes")
                        .HasForeignKey("SortCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SortCode");
                });

            modelBuilder.Entity("BankFinderAPI.Models.FaxNumber", b =>
                {
                    b.HasOne("BankFinderAPI.Models.Unit", "Unit")
                        .WithMany("FaxNumbers")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("BankFinderAPI.Models.PhoneNumber", b =>
                {
                    b.HasOne("BankFinderAPI.Models.Unit", "Unit")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("BankFinderAPI.Models.SortCode", b =>
                {
                    b.HasOne("BankFinderAPI.Models.Unit", "Unit")
                        .WithMany("SortCode")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("BankFinderAPI.Models.Unit", b =>
                {
                    b.HasOne("BankFinderAPI.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankFinderAPI.Models.Institution", null)
                        .WithMany("Unit")
                        .HasForeignKey("InstitutionId");

                    b.HasOne("BankFinderAPI.Models.OpeningHours", "OpeningHours")
                        .WithMany()
                        .HasForeignKey("OpeningHoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("OpeningHours");
                });

            modelBuilder.Entity("BankFinderAPI.Models.Institution", b =>
                {
                    b.Navigation("Unit");
                });

            modelBuilder.Entity("BankFinderAPI.Models.SortCode", b =>
                {
                    b.Navigation("BicCodes");
                });

            modelBuilder.Entity("BankFinderAPI.Models.Unit", b =>
                {
                    b.Navigation("FaxNumbers");

                    b.Navigation("PhoneNumbers");

                    b.Navigation("SortCode");
                });
#pragma warning restore 612, 618
        }
    }
}
