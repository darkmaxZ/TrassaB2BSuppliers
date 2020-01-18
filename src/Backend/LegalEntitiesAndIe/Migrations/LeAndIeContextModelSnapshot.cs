﻿// <auto-generated />
using System;
using LegalEntitiesAndIe.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LegalEntitiesAndIe.Migrations
{
    [DbContext(typeof(LeAndIeContext))]
    partial class LeAndIeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("LegalEntitiesAndIe")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571");

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeAccountingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("EntryDateInEgrip");

                    b.Property<long>("Grn");

                    b.Property<int>("IndividualEntrepreneurId");

                    b.Property<long>("Inn");

                    b.Property<string>("RegistrationAuthorityName");

                    b.Property<string>("TaxAuthorityName");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEntrepreneurId")
                        .IsUnique();

                    b.ToTable("IeAccountingInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeAuthorityInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateIntEgrip");

                    b.Property<long>("Grn");

                    b.Property<int>("IndividualEntrepreneurId");

                    b.Property<string>("Patronymic");

                    b.Property<int>("RegistrationAuthorityId");

                    b.Property<string>("RegistrationAuthorityName");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEntrepreneurId")
                        .IsUnique();

                    b.ToTable("IeAuthorityInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeFullName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateIntEgrip");

                    b.Property<long>("Grn");

                    b.Property<int>("IndividualEntrepreneurId");

                    b.Property<string>("Name");

                    b.Property<string>("Patronymic");

                    b.Property<string>("RegistrationAuthorityName");

                    b.Property<int>("Sex");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEntrepreneurId")
                        .IsUnique();

                    b.ToTable("IeFullNames");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeNationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateInEgrip");

                    b.Property<long>("Grn");

                    b.Property<int>("IndividualEntrepreneurId");

                    b.Property<string>("Nationality");

                    b.Property<string>("RegistrationAuthorityName");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEntrepreneurId")
                        .IsUnique();

                    b.ToTable("IeNationalities");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeRegistrationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateInOgrnip");

                    b.Property<int>("IndividualEntrepreneurId");

                    b.Property<long>("Ogrnip");

                    b.Property<string>("OldRegistrationAuthority");

                    b.Property<DateTime>("OldRegistrationDate");

                    b.Property<long>("OldRegistrationNumber");

                    b.Property<string>("ReistrationAuthorityName");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEntrepreneurId")
                        .IsUnique();

                    b.ToTable("IeRegistrationInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeTerminationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateInEgrip");

                    b.Property<long>("Grn");

                    b.Property<int>("IndividualEntrepreneurId");

                    b.Property<string>("RegistrationAuthorityName");

                    b.Property<DateTime>("TerminationDate");

                    b.Property<string>("TerminationMethod");

                    b.HasKey("Id");

                    b.HasIndex("IndividualEntrepreneurId")
                        .IsUnique();

                    b.ToTable("IeTerminationInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateInOgrnip");

                    b.Property<long>("Inn");

                    b.Property<int>("NaturalPersonId");

                    b.Property<long>("Ogrnip");

                    b.Property<DateTime>("TerminationDate");

                    b.HasKey("Id");

                    b.ToTable("IndividualEntrepreneurs");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeAccountingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateInEgrul");

                    b.Property<long>("Grn");

                    b.Property<long>("Inn");

                    b.Property<long>("Kpp");

                    b.Property<int>("LegalEntityId");

                    b.Property<DateTime>("RegistationDate");

                    b.Property<string>("TaxAuthorityName");

                    b.HasKey("Id");

                    b.HasIndex("LegalEntityId")
                        .IsUnique();

                    b.ToTable("LeAccountingInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeAuthorityInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("EntryDateInEgrul");

                    b.Property<long>("Grn");

                    b.Property<int>("LegalEntityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LegalEntityId")
                        .IsUnique();

                    b.ToTable("LeAuthorityInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LegalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AssignmentDateOfOgrn");

                    b.Property<int>("CentralOfficeAddressId");

                    b.Property<string>("Founder");

                    b.Property<string>("Head");

                    b.Property<int>("LegalAddressId");

                    b.Property<int>("PostAddressId");

                    b.Property<DateTime>("TerminationDate");

                    b.HasKey("Id");

                    b.ToTable("LegalEntities");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeLocationAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressesId");

                    b.Property<DateTime>("EntryDateInEgrul");

                    b.Property<long>("Grn");

                    b.Property<int>("LegalEntityId");

                    b.HasKey("Id");

                    b.HasIndex("LegalEntityId")
                        .IsUnique();

                    b.ToTable("LeLocationAddresses");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDateInEgrul");

                    b.Property<string>("FullName");

                    b.Property<long>("Grn");

                    b.Property<int>("LegalEntityId");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.HasIndex("LegalEntityId")
                        .IsUnique();

                    b.ToTable("LeNames");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeRegistrationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AssignmentDateOfOgrn");

                    b.Property<DateTime>("EntryDateInEgrul");

                    b.Property<long>("Grn");

                    b.Property<int>("LegalEntityId");

                    b.Property<long>("Ogrn");

                    b.Property<string>("OldRegistrationAuthority");

                    b.Property<long>("OldRegistrationNumber");

                    b.HasKey("Id");

                    b.HasIndex("LegalEntityId")
                        .IsUnique();

                    b.ToTable("LeRegistrationInfos");
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeAccountingInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", "IndividualEntrepreneur")
                        .WithOne("IeAccountingInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.IeAccountingInfo", "IndividualEntrepreneurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeAuthorityInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", "IndividualEntrepreneur")
                        .WithOne("IeAuthorityInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.IeAuthorityInfo", "IndividualEntrepreneurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeFullName", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", "IndividualEntrepreneur")
                        .WithOne("IeFullName")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.IeFullName", "IndividualEntrepreneurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeNationality", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", "IndividualEntrepreneur")
                        .WithOne("IeNationality")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.IeNationality", "IndividualEntrepreneurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeRegistrationInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", "IndividualEntrepreneur")
                        .WithOne("IeRegistrationInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.IeRegistrationInfo", "IndividualEntrepreneurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.IeTerminationInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.IndividualEntrepreneur", "IndividualEntrepreneur")
                        .WithOne("IeTerminationInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.IeTerminationInfo", "IndividualEntrepreneurId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeAccountingInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.LegalEntity", "LegalEntity")
                        .WithOne("LeAccountingInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.LeAccountingInfo", "LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeAuthorityInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.LegalEntity", "LegalEntity")
                        .WithOne("LeAuthorityInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.LeAuthorityInfo", "LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeLocationAddress", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.LegalEntity", "LegalEntity")
                        .WithOne("LeLocationAddress")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.LeLocationAddress", "LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeName", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.LegalEntity", "LegalEntity")
                        .WithOne("LeName")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.LeName", "LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalEntitiesAndIe.Database.Models.LeRegistrationInfo", b =>
                {
                    b.HasOne("LegalEntitiesAndIe.Database.Models.LegalEntity", "LegalEntity")
                        .WithOne("LeRegistrationInfo")
                        .HasForeignKey("LegalEntitiesAndIe.Database.Models.LeRegistrationInfo", "LegalEntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
