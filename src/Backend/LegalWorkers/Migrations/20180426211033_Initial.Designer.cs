﻿// <auto-generated />
using LegalWorkers.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace LegalWorkers.Migrations
{
    [DbContext(typeof(LegalWorkersContext))]
    [Migration("20180426211033_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("legalWorkers")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("LegalWorkers.Database.Models.EmployeeFunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CounteragentType");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EmployeeFunctions");
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SectionId");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.UQPDSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("UQPDSections");
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<int>("DirectorId");

                    b.Property<int>("LegalEntityId");

                    b.Property<int>("NaturalPersonId");

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("PostId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.WorkerFunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<DateTime>("DateOfRecordCreation");

                    b.Property<DateTime>("DateOfRecordRemoval");

                    b.Property<int>("FunctionId");

                    b.Property<int>("WorkerId");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerFunctions");
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.Post", b =>
                {
                    b.HasOne("LegalWorkers.Database.Models.UQPDSection", "Section")
                        .WithMany("Posts")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.Worker", b =>
                {
                    b.HasOne("LegalWorkers.Database.Models.Worker", "Director")
                        .WithMany("Workers")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LegalWorkers.Database.Models.Post", "Post")
                        .WithMany("Workers")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LegalWorkers.Database.Models.WorkerFunction", b =>
                {
                    b.HasOne("LegalWorkers.Database.Models.EmployeeFunction", "Function")
                        .WithMany("Functions")
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LegalWorkers.Database.Models.Worker", "Worker")
                        .WithMany("Functions")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
