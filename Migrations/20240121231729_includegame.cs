using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class includegame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gameHoleRoadmaps",
                columns: table => new
                {
                    game_hole_roadmap_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_type_id = table.Column<long>(type: "bigint", nullable: false),
                    sequence = table.Column<int>(type: "int", nullable: false),
                    roadmap_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shot_limit = table.Column<int>(type: "int", nullable: false),
                    end_indc = table.Column<int>(type: "int", nullable: false),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameHoleRoadmaps", x => x.game_hole_roadmap_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gameMatchScoreCards",
                columns: table => new
                {
                    game_match_score_card_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_milestone_match_id = table.Column<long>(type: "bigint", nullable: false),
                    golfer_id = table.Column<long>(type: "bigint", nullable: false),
                    hole_1_status = table.Column<int>(type: "int", nullable: false),
                    hole_1_score = table.Column<double>(type: "double", nullable: false),
                    hole_2_status = table.Column<int>(type: "int", nullable: false),
                    hole_2_score = table.Column<double>(type: "double", nullable: false),
                    hole_3_status = table.Column<int>(type: "int", nullable: false),
                    hole_3_score = table.Column<double>(type: "double", nullable: false),
                    hole_4_status = table.Column<int>(type: "int", nullable: false),
                    hole_4_score = table.Column<double>(type: "double", nullable: false),
                    hole_5_status = table.Column<int>(type: "int", nullable: false),
                    hole_5_score = table.Column<double>(type: "double", nullable: false),
                    hole_6_status = table.Column<int>(type: "int", nullable: false),
                    hole_6_score = table.Column<double>(type: "double", nullable: false),
                    hole_7_status = table.Column<int>(type: "int", nullable: false),
                    hole_7_score = table.Column<double>(type: "double", nullable: false),
                    hole_8_status = table.Column<int>(type: "int", nullable: false),
                    hole_8_score = table.Column<double>(type: "double", nullable: false),
                    hole_9_status = table.Column<int>(type: "int", nullable: false),
                    hole_9_score = table.Column<double>(type: "double", nullable: false),
                    hole_10_status = table.Column<int>(type: "int", nullable: false),
                    hole_10_score = table.Column<double>(type: "double", nullable: false),
                    hole_11_status = table.Column<int>(type: "int", nullable: false),
                    hole_11_score = table.Column<double>(type: "double", nullable: false),
                    hole_12_status = table.Column<int>(type: "int", nullable: false),
                    hole_12_score = table.Column<double>(type: "double", nullable: false),
                    hole_13_status = table.Column<int>(type: "int", nullable: false),
                    hole_13_score = table.Column<double>(type: "double", nullable: false),
                    hole_14_status = table.Column<int>(type: "int", nullable: false),
                    hole_14_score = table.Column<double>(type: "double", nullable: false),
                    hole_15_status = table.Column<int>(type: "int", nullable: false),
                    hole_15_score = table.Column<double>(type: "double", nullable: false),
                    hole_16_status = table.Column<int>(type: "int", nullable: false),
                    hole_16_score = table.Column<double>(type: "double", nullable: false),
                    hole_17_status = table.Column<int>(type: "int", nullable: false),
                    hole_17_score = table.Column<double>(type: "double", nullable: false),
                    hole_18_status = table.Column<int>(type: "int", nullable: false),
                    hole_18_score = table.Column<double>(type: "double", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameMatchScoreCards", x => x.game_match_score_card_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gameMatchStrokes",
                columns: table => new
                {
                    game_match_stroke_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_match_score_card_id = table.Column<long>(type: "bigint", nullable: false),
                    golf_course_hole_id = table.Column<long>(type: "bigint", nullable: false),
                    game_hole_roadmap_id = table.Column<long>(type: "bigint", nullable: false),
                    stroke_seqno = table.Column<int>(type: "int", nullable: false),
                    latitude = table.Column<double>(type: "double", nullable: false),
                    longitude = table.Column<double>(type: "double", nullable: false),
                    stoke_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    course_tee_id = table.Column<long>(type: "bigint", nullable: false),
                    distance = table.Column<long>(type: "bigint", nullable: false),
                    location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isin_putter_length = table.Column<int>(type: "int", nullable: false),
                    isin_hole = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameMatchStrokes", x => x.game_match_stroke_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gameMilestoneMatches",
                columns: table => new
                {
                    game_milestone_match_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_milestone_id = table.Column<long>(type: "bigint", nullable: false),
                    game_id = table.Column<long>(type: "bigint", nullable: false),
                    match_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    golfer_1 = table.Column<long>(type: "bigint", nullable: false),
                    golfer_2 = table.Column<long>(type: "bigint", nullable: false),
                    sequence = table.Column<int>(type: "int", nullable: false),
                    milestone_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    golfer_1_score = table.Column<double>(type: "double", nullable: false),
                    golfer_2_score = table.Column<double>(type: "double", nullable: false),
                    final_indc = table.Column<int>(type: "int", nullable: false),
                    winner = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameMilestoneMatches", x => x.game_milestone_match_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gameMilestoneMatchTs",
                columns: table => new
                {
                    game_milestone_matchT_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_milestoneT_id = table.Column<long>(type: "bigint", nullable: false),
                    match_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    golfer_1 = table.Column<long>(type: "bigint", nullable: false),
                    golfer_1_rule = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    golfer_2 = table.Column<long>(type: "bigint", nullable: false),
                    golfer_2_rule = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    final_indc = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameMilestoneMatchTs", x => x.game_milestone_matchT_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gameMilestones",
                columns: table => new
                {
                    game_milestone_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_milestoneT_id = table.Column<long>(type: "bigint", nullable: false),
                    game_id = table.Column<long>(type: "bigint", nullable: false),
                    handlesize = table.Column<int>(type: "int", nullable: false),
                    sequence = table.Column<int>(type: "int", nullable: false),
                    milestone_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    final_indc = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameMilestones", x => x.game_milestone_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gameMilestoneTs",
                columns: table => new
                {
                    game_milestoneT_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_type_id = table.Column<long>(type: "bigint", nullable: false),
                    handlesize = table.Column<int>(type: "int", nullable: false),
                    sequence = table.Column<int>(type: "int", nullable: false),
                    milestone_code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    final_indc = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameMilestoneTs", x => x.game_milestoneT_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gameHoleRoadmaps");

            migrationBuilder.DropTable(
                name: "gameMatchScoreCards");

            migrationBuilder.DropTable(
                name: "gameMatchStrokes");

            migrationBuilder.DropTable(
                name: "gameMilestoneMatches");

            migrationBuilder.DropTable(
                name: "gameMilestoneMatchTs");

            migrationBuilder.DropTable(
                name: "gameMilestones");

            migrationBuilder.DropTable(
                name: "gameMilestoneTs");
        }
    }
}
