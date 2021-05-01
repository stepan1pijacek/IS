﻿// <auto-generated />
using System;
using IS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IS.Migrations
{
    [DbContext(typeof(ISDbContext))]
    partial class ISDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IS.Data.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyName = "FEKT"
                        });
                });

            modelBuilder.Entity("IS.Data.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Score1")
                        .HasColumnType("int");

                    b.Property<int?>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentsId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("IS.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "golian@seznam.cz",
                            FacultyId = 1,
                            Name = "Igor",
                            Phone = 734220456,
                            Surname = "Golian",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("IS.Data.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("IS.Data.Score", b =>
                {
                    b.HasOne("IS.Data.Student", "Students")
                        .WithMany("Scores")
                        .HasForeignKey("StudentsId");

                    b.HasOne("IS.Data.Subject", "Subject")
                        .WithMany("Scores")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Students");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("IS.Data.Student", b =>
                {
                    b.HasOne("IS.Data.Faculty", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("IS.Data.Faculty", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("IS.Data.Student", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("IS.Data.Subject", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}