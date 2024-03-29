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
    [Migration("20240225164437_newColumn6")]
    partial class newColumn6
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

                    b.Property<int>("course_hole_no")
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

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("course_hole_id");

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

                    b.Property<string>("course_teename")
                        .IsRequired()
                        .HasColumnType("longtext");

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

            modelBuilder.Entity("Common.Entities.GameHoleRoadmap", b =>
                {
                    b.Property<long>("game_hole_roadmap_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("end_indc")
                        .HasColumnType("int");

                    b.Property<long>("game_type_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("roadmap_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("sequence")
                        .HasColumnType("int");

                    b.Property<int>("shot_limit")
                        .HasColumnType("int");

                    b.HasKey("game_hole_roadmap_id");

                    b.ToTable("GameHoleRoadmap");
                });

            modelBuilder.Entity("Common.Entities.GameMatchScoreCard", b =>
                {
                    b.Property<long>("game_match_score_card_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("course_hole_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("game_milestone_match_id")
                        .HasColumnType("bigint");

                    b.Property<long>("golfer_id")
                        .HasColumnType("bigint");

                    b.Property<double>("hole_10_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_10_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_11_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_11_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_12_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_12_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_13_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_13_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_14_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_14_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_15_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_15_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_16_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_16_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_17_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_17_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_18_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_18_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_1_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_1_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_2_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_2_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_3_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_3_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_4_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_4_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_5_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_5_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_6_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_6_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_7_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_7_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_8_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_8_status")
                        .HasColumnType("int");

                    b.Property<double>("hole_9_score")
                        .HasColumnType("double");

                    b.Property<int>("hole_9_status")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("roadmap_sequence")
                        .HasColumnType("bigint");

                    b.Property<double>("score")
                        .HasColumnType("double");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_match_score_card_id");

                    b.ToTable("GameMatchScoreCard");
                });

            modelBuilder.Entity("Common.Entities.GameMatchStroke", b =>
                {
                    b.Property<long>("game_match_stroke_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("course_tee_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("distance")
                        .HasColumnType("double");

                    b.Property<long>("game_hole_roadmap_id")
                        .HasColumnType("bigint");

                    b.Property<long>("game_match_score_card_id")
                        .HasColumnType("bigint");

                    b.Property<long>("golf_course_hole_id")
                        .HasColumnType("bigint");

                    b.Property<int>("isin_hole")
                        .HasColumnType("int");

                    b.Property<int>("isin_putter_length")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("latitude")
                        .HasColumnType("double");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("longitude")
                        .HasColumnType("double");

                    b.Property<int>("scorepoint")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("stoke_time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("stroke_seqno")
                        .HasColumnType("int");

                    b.HasKey("game_match_stroke_id");

                    b.ToTable("GameMatchStroke");
                });

            modelBuilder.Entity("Common.Entities.GameMilestone", b =>
                {
                    b.Property<long>("game_milestone_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("final_indc")
                        .HasColumnType("int");

                    b.Property<long>("game_id")
                        .HasColumnType("bigint");

                    b.Property<long>("game_milestoneT_id")
                        .HasColumnType("bigint");

                    b.Property<int>("handlesize")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("milestone_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("sequence")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_milestone_id");

                    b.ToTable("GameMilestone");
                });

            modelBuilder.Entity("Common.Entities.GameMilestoneMatch", b =>
                {
                    b.Property<long>("game_milestone_match_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("final_indc")
                        .HasColumnType("int");

                    b.Property<long>("game_id")
                        .HasColumnType("bigint");

                    b.Property<long>("game_milestone_id")
                        .HasColumnType("bigint");

                    b.Property<long>("game_milestone_matchT_id")
                        .HasColumnType("bigint");

                    b.Property<long>("golfer_1")
                        .HasColumnType("bigint");

                    b.Property<double>("golfer_1_score")
                        .HasColumnType("double");

                    b.Property<long>("golfer_2")
                        .HasColumnType("bigint");

                    b.Property<double>("golfer_2_score")
                        .HasColumnType("double");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("match_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("milestone_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("sequence")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("winner")
                        .HasColumnType("bigint");

                    b.HasKey("game_milestone_match_id");

                    b.ToTable("GameMilestoneMatch");
                });

            modelBuilder.Entity("Common.Entities.GameMilestoneMatchT", b =>
                {
                    b.Property<long>("game_milestone_matchT_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("final_indc")
                        .HasColumnType("int");

                    b.Property<long>("game_milestoneT_id")
                        .HasColumnType("bigint");

                    b.Property<string>("golfer_1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfer_1_rule")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfer_2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("golfer_2_rule")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("match_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_milestone_matchT_id");

                    b.ToTable("GameMilestoneMatchT");
                });

            modelBuilder.Entity("Common.Entities.GameMilestoneT", b =>
                {
                    b.Property<long>("game_milestoneT_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("final_indc")
                        .HasColumnType("int");

                    b.Property<long>("game_type_id")
                        .HasColumnType("bigint");

                    b.Property<int>("handlesize")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("milestone_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("sequence")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("game_milestoneT_id");

                    b.ToTable("GameMilestoneT");
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

                    b.Property<int>("level_limit")
                        .HasColumnType("int");

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

            modelBuilder.Entity("Common.Entities.ScoreCardSubmission", b =>
                {
                    b.Property<long>("ScoreCardSubmission_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Game_Type_id")
                        .HasColumnType("bigint");

                    b.Property<long>("Game_id")
                        .HasColumnType("bigint");

                    b.Property<long>("Game_match_score_card_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.HasKey("ScoreCardSubmission_id");

                    b.ToTable("ScoreCardSubmissions");
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

                    b.Property<long>("Level_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Scorepoint")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserSystemId");

                    b.ToTable("Users");
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

            modelBuilder.Entity("Common.Entities.ThePerfectGameUser", b =>
                {
                    b.Navigation("ThePerfectGameStrokes");
                });
#pragma warning restore 612, 618
        }
    }
}
