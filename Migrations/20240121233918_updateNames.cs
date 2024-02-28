using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class updateNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneTs",
                table: "GameMilestoneTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestones",
                table: "GameMilestones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneMatchTs",
                table: "GameMilestoneMatchTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneMatches",
                table: "GameMilestoneMatches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMatchStrokes",
                table: "GameMatchStrokes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMatchScoreCards",
                table: "GameMatchScoreCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameHoleRoadmaps",
                table: "GameHoleRoadmaps");

            migrationBuilder.RenameTable(
                name: "GameMilestoneTs",
                newName: "GameMilestoneT");

            migrationBuilder.RenameTable(
                name: "GameMilestones",
                newName: "GameMilestone");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatchTs",
                newName: "GameMilestoneMatchT");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatches",
                newName: "GameMilestoneMatche");

            migrationBuilder.RenameTable(
                name: "GameMatchStrokes",
                newName: "GameMatchStroke");

            migrationBuilder.RenameTable(
                name: "GameMatchScoreCards",
                newName: "GameMatchScoreCard");

            migrationBuilder.RenameTable(
                name: "GameHoleRoadmaps",
                newName: "GameHoleRoadmap");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneT",
                table: "GameMilestoneT",
                column: "game_milestoneT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestone",
                table: "GameMilestone",
                column: "game_milestone_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatchT",
                table: "GameMilestoneMatchT",
                column: "game_milestone_matchT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatche",
                table: "GameMilestoneMatche",
                column: "game_milestone_match_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMatchStroke",
                table: "GameMatchStroke",
                column: "game_match_stroke_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMatchScoreCard",
                table: "GameMatchScoreCard",
                column: "game_match_score_card_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameHoleRoadmap",
                table: "GameHoleRoadmap",
                column: "game_hole_roadmap_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneT",
                table: "GameMilestoneT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneMatchT",
                table: "GameMilestoneMatchT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneMatche",
                table: "GameMilestoneMatche");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestone",
                table: "GameMilestone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMatchStroke",
                table: "GameMatchStroke");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMatchScoreCard",
                table: "GameMatchScoreCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameHoleRoadmap",
                table: "GameHoleRoadmap");

            migrationBuilder.RenameTable(
                name: "GameMilestoneT",
                newName: "GameMilestoneTs");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatchT",
                newName: "GameMilestoneMatchTs");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatche",
                newName: "GameMilestoneMatches");

            migrationBuilder.RenameTable(
                name: "GameMilestone",
                newName: "GameMilestones");

            migrationBuilder.RenameTable(
                name: "GameMatchStroke",
                newName: "GameMatchStrokes");

            migrationBuilder.RenameTable(
                name: "GameMatchScoreCard",
                newName: "GameMatchScoreCards");

            migrationBuilder.RenameTable(
                name: "GameHoleRoadmap",
                newName: "GameHoleRoadmaps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneTs",
                table: "GameMilestoneTs",
                column: "game_milestoneT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatchTs",
                table: "GameMilestoneMatchTs",
                column: "game_milestone_matchT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatches",
                table: "GameMilestoneMatches",
                column: "game_milestone_match_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestones",
                table: "GameMilestones",
                column: "game_milestone_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMatchStrokes",
                table: "GameMatchStrokes",
                column: "game_match_stroke_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMatchScoreCards",
                table: "GameMatchScoreCards",
                column: "game_match_score_card_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameHoleRoadmaps",
                table: "GameHoleRoadmaps",
                column: "game_hole_roadmap_id");
        }
    }
}
