﻿// <auto-generated />
using System;
using DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GolfApi.Migrations
{
    [DbContext(typeof(GolfDbContext))]
    [Migration("20231222020315_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Common.Entities.GolfCourse", b =>
                {
                    b.Property<long>("GolfCourseSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<double>("GolfCourseInitalLocationLat")
                        .HasColumnType("double");

                    b.Property<double>("GolfCourseInitalLocationLong")
                        .HasColumnType("double");

                    b.Property<string>("GolfCourseName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GolfCourseSystemId");

                    b.ToTable("GolfCoursse");
                });

            modelBuilder.Entity("Common.Entities.GolfCourseHole", b =>
                {
                    b.Property<long>("GolfCourseHoleSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("GolfCourseHoleNumber")
                        .HasColumnType("int");

                    b.Property<long>("GolfCourseSystemId")
                        .HasColumnType("bigint");

                    b.HasKey("GolfCourseHoleSystemId");

                    b.HasIndex("GolfCourseSystemId");

                    b.ToTable("GolfCourseHoles");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGame", b =>
                {
                    b.Property<long>("ThePerfectGameSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("GolfCourseSystemId")
                        .HasColumnType("bigint");

                    b.Property<int>("StartingHole")
                        .HasColumnType("int");

                    b.HasKey("ThePerfectGameSystemId");

                    b.HasIndex("GolfCourseSystemId");

                    b.ToTable("ThePerfectGame");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameStroke", b =>
                {
                    b.Property<long>("ThePerfectGameStrokeSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("BallLie")
                        .HasColumnType("int");

                    b.Property<decimal>("Distance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<long?>("EndingLat")
                        .HasColumnType("bigint");

                    b.Property<long?>("EndingLong")
                        .HasColumnType("bigint");

                    b.Property<long?>("GolfCourseHoleSystemId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StartingLat")
                        .HasColumnType("bigint");

                    b.Property<long?>("StartingLong")
                        .HasColumnType("bigint");

                    b.Property<int>("StrokeNumber")
                        .HasColumnType("int");

                    b.Property<long>("ThePerfectGameUserSystemId")
                        .HasColumnType("bigint");

                    b.HasKey("ThePerfectGameStrokeSystemId");

                    b.HasIndex("GolfCourseHoleSystemId");

                    b.HasIndex("ThePerfectGameUserSystemId");

                    b.ToTable("ThePerfectGameStroke");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameUser", b =>
                {
                    b.Property<long>("ThePerfectGameUserSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("MinDistanceForGoodShot")
                        .HasColumnType("bigint");

                    b.Property<long>("UserSystemId")
                        .HasColumnType("bigint");

                    b.HasKey("ThePerfectGameUserSystemId");

                    b.HasIndex("UserSystemId");

                    b.ToTable("ThePerfectGameUser");
                });

            modelBuilder.Entity("Common.Entities.User", b =>
                {
                    b.Property<long>("UserSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserSystemId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Common.Entities.GolfCourseHole", b =>
                {
                    b.HasOne("Common.Entities.GolfCourse", "GolfCourseEntity")
                        .WithMany("GolfCourseHoles")
                        .HasForeignKey("GolfCourseSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GolfCourseEntity");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGame", b =>
                {
                    b.HasOne("Common.Entities.GolfCourse", "GolfCourse")
                        .WithMany()
                        .HasForeignKey("GolfCourseSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GolfCourse");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameStroke", b =>
                {
                    b.HasOne("Common.Entities.GolfCourseHole", "GolfCourseHole")
                        .WithMany()
                        .HasForeignKey("GolfCourseHoleSystemId");

                    b.HasOne("Common.Entities.ThePerfectGameUser", "ThePerfectGameUser")
                        .WithMany("ThePerfectGameStrokes")
                        .HasForeignKey("ThePerfectGameUserSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GolfCourseHole");

                    b.Navigation("ThePerfectGameUser");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameUser", b =>
                {
                    b.HasOne("Common.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Common.Entities.GolfCourse", b =>
                {
                    b.Navigation("GolfCourseHoles");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameUser", b =>
                {
                    b.Navigation("ThePerfectGameStrokes");
                });
#pragma warning restore 612, 618
        }
    }
}