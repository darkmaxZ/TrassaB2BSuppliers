﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NaturalPersons.Database;
using NaturalPersons.Database.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace NaturalPersons.Migrations
{
    [DbContext(typeof(NaturalPersonsContext))]
    [Migration("20180426223902_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("naturalPersons")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("NaturalPersons.Database.Models.IdentityDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Authority");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateOfExpiration");

                    b.Property<DateTime>("DateOfIssue");

                    b.Property<string>("Name");

                    b.Property<int>("NaturalPersonId");

                    b.Property<int?>("Number");

                    b.Property<string>("Patronymic");

                    b.Property<int?>("RegistrationAddressId");

                    b.Property<int>("Sex");

                    b.Property<string>("Surname");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("NaturalPersonId");

                    b.ToTable("IdentityDocuments");
                });

            modelBuilder.Entity("NaturalPersons.Database.Models.NaturalPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.Property<string>("Patronymic");

                    b.Property<string>("Sex");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("NaturalPersons");
                });

            modelBuilder.Entity("NaturalPersons.Database.Models.IdentityDocument", b =>
                {
                    b.HasOne("NaturalPersons.Database.Models.NaturalPerson", "NaturalPerson")
                        .WithMany("IdentityDocuments")
                        .HasForeignKey("NaturalPersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
