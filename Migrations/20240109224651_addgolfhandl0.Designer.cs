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
    [Migration("20240109224651_addgolfhandl0")]
    partial class addgolfhandl0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Common.Entities.Area", b =>
                {
                    b.Property<long>("area_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("area_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("area_id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Common.Entities.CourseHoleCoordinates", b =>
                {
                    b.Property<long>("course_hole_coordinate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("course_hole_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("golf_course_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("latitude")
                        .HasColumnType("double");

                    b.Property<double>("longitude")
                        .HasColumnType("double");

                    b.Property<double>("maxdistance")
                        .HasColumnType("double");

                    b.Property<string>("moe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("course_hole_coordinate_id");

                    b.ToTable("CourseHoleCoordinates");
                });

            modelBuilder.Entity("Common.Entities.CourseHoles", b =>
                {
                    b.Property<long>("course_hole_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("GolfCoursesgolf_course_id")
                        .HasColumnType("bigint");

                    b.Property<int>("course_hole_no")
                        .HasColumnType("int");

                    b.Property<long>("golf_course_id")
                        .HasColumnType("bigint");

                    b.HasKey("course_hole_id");

                    b.HasIndex("GolfCoursesgolf_course_id");

                    b.ToTable("CourseHoles");
                });

            modelBuilder.Entity("Common.Entities.CourseTeeNames", b =>
                {
                    b.Property<long>("course_teename_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("golf_course_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("course_teename_id");

                    b.ToTable("CourseTeeNames");
                });

            modelBuilder.Entity("Common.Entities.CourseTees", b =>
                {
                    b.Property<long>("course_tee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("course_hole_no")
                        .HasColumnType("int");

                    b.Property<long>("course_teename_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("golf_course_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("teedistance")
                        .HasColumnType("double");

                    b.HasKey("course_tee_id");

                    b.ToTable("CourseTees");
                });

            modelBuilder.Entity("Common.Entities.GameGolfers", b =>
                {
                    b.Property<long>("game_golfer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("game_id")
                        .HasColumnType("bigint");

                    b.Property<long>("golfer_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_golfer_id");

                    b.ToTable("GameGolfers");
                });

            modelBuilder.Entity("Common.Entities.GameTypes", b =>
                {
                    b.Property<long>("game_type_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("game_type_code")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_type_id");

                    b.ToTable("GameTypes");
                });

            modelBuilder.Entity("Common.Entities.Games", b =>
                {
                    b.Property<long>("game_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("creator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("game_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("game_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("game_type_id")
                        .HasColumnType("bigint");

                    b.Property<long>("golf_course_id")
                        .HasColumnType("bigint");

                    b.Property<string>("golfhandle0")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle4")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle5")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle6")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfhandle7")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("start_half_id")
                        .HasColumnType("bigint");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Common.Entities.GolfCourses", b =>
                {
                    b.Property<long>("golf_course_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("area_id")
                        .HasColumnType("bigint");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("contact_person")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("golf_course_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golf_course_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("par_9")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("golf_course_id");

                    b.ToTable("GolfCourses");
                });

            modelBuilder.Entity("Common.Entities.Level", b =>
                {
                    b.Property<long>("level_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("level_limit")
                        .HasColumnType("bigint");

                    b.Property<string>("level_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("level_id");

                    b.ToTable("Level");
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

            modelBuilder.Entity("Common.Entities.TournamenTypes", b =>
                {
                    b.Property<long>("tournament_type_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tournament_type_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("tournament_type_id");

                    b.ToTable("TournamenTypes");
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

            modelBuilder.Entity("Common.Entities.CourseHoles", b =>
                {
                    b.HasOne("Common.Entities.GolfCourses", null)
                        .WithMany("CourseHoles")
                        .HasForeignKey("GolfCoursesgolf_course_id");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGame", b =>
                {
                    b.HasOne("Common.Entities.GolfCourses", "GolfCourses")
                        .WithMany()
                        .HasForeignKey("GolfCourseSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GolfCourses");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameStroke", b =>
                {
                    b.HasOne("Common.Entities.CourseHoles", "CourseHoles")
                        .WithMany()
                        .HasForeignKey("GolfCourseHoleSystemId");

                    b.HasOne("Common.Entities.ThePerfectGameUser", "ThePerfectGameUser")
                        .WithMany("ThePerfectGameStrokes")
                        .HasForeignKey("ThePerfectGameUserSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseHoles");

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

            modelBuilder.Entity("Common.Entities.GolfCourses", b =>
                {
                    b.Navigation("CourseHoles");
                });

            modelBuilder.Entity("Common.Entities.ThePerfectGameUser", b =>
                {
                    b.Navigation("ThePerfectGameStrokes");
                });
#pragma warning restore 612, 618
        }
    }
}
