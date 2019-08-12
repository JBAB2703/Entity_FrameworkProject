﻿// <auto-generated />
using System;
using Entity_FrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity_FrameworkProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190808193845_added Schedule Class")]
    partial class addedScheduleClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity_FrameworkProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Credit");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("MajorId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("MajorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Entity_FrameworkProject.Models.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("MinSat");

                    b.HasKey("Id");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("Entity_FrameworkProject.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("Grade");

                    b.Property<int>("MajorId");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Entity_FrameworkProject.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("GPA");

                    b.Property<bool>("IsFulltime");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int?>("MajorId");

                    b.Property<int>("SAT");

                    b.HasKey("Id");

                    b.HasIndex("MajorId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Entity_FrameworkProject.Models.Course", b =>
                {
                    b.HasOne("Entity_FrameworkProject.Models.Major", "Major")
                        .WithMany()
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entity_FrameworkProject.Models.Student", b =>
                {
                    b.HasOne("Entity_FrameworkProject.Models.Major", "Major")
                        .WithMany()
                        .HasForeignKey("MajorId");
                });
#pragma warning restore 612, 618
        }
    }
}
