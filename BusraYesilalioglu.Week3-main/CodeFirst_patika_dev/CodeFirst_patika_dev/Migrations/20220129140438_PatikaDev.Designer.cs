﻿// <auto-generated />
using System;
using CodeFirst_patika_dev;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst_patika_dev.Migrations
{
    [DbContext(typeof(PatikaDBContext))]
    [Migration("20220129140438_PatikaDev")]
    partial class PatikaDev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Assistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.ToTable("Assistants");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AttendanceWeek8")
                        .HasColumnType("real");

                    b.Property<int?>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int?>("SuccesszId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentsId");

                    b.HasIndex("SuccesszId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EducationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Partipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Partipants");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Success", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StudentsId")
                        .HasColumnType("int");

                    b.Property<float>("SuccessStatus")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("StudentsId");

                    b.ToTable("Successz");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EducationPartipant", b =>
                {
                    b.Property<int>("EducationsId")
                        .HasColumnType("int");

                    b.Property<int>("PartipantsId")
                        .HasColumnType("int");

                    b.HasKey("EducationsId", "PartipantsId");

                    b.HasIndex("PartipantsId");

                    b.ToTable("EducationPartipant");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Assistant", b =>
                {
                    b.HasOne("CodeFirst_patika_dev.Entity.Education", null)
                        .WithMany("Assistants")
                        .HasForeignKey("EducationId");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Attendance", b =>
                {
                    b.HasOne("CodeFirst_patika_dev.Entity.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentsId");

                    b.HasOne("CodeFirst_patika_dev.Entity.Success", "Successz")
                        .WithMany()
                        .HasForeignKey("SuccesszId");

                    b.Navigation("Students");

                    b.Navigation("Successz");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Student", b =>
                {
                    b.HasOne("CodeFirst_patika_dev.Entity.Education", null)
                        .WithMany("Students")
                        .HasForeignKey("EducationId");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Success", b =>
                {
                    b.HasOne("CodeFirst_patika_dev.Entity.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentsId");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Teacher", b =>
                {
                    b.HasOne("CodeFirst_patika_dev.Entity.Education", null)
                        .WithMany("Teachers")
                        .HasForeignKey("EducationId");
                });

            modelBuilder.Entity("EducationPartipant", b =>
                {
                    b.HasOne("CodeFirst_patika_dev.Entity.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_patika_dev.Entity.Partipant", null)
                        .WithMany()
                        .HasForeignKey("PartipantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst_patika_dev.Entity.Education", b =>
                {
                    b.Navigation("Assistants");

                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
