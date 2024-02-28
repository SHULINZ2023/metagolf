using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class updateTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_gameMilestoneTs",
                table: "gameMilestoneTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gameMilestones",
                table: "gameMilestones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gameMilestoneMatchTs",
                table: "gameMilestoneMatchTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gameMilestoneMatches",
                table: "gameMilestoneMatches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gameMatchStrokes",
                table: "gameMatchStrokes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gameMatchScoreCards",
                table: "gameMatchScoreCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gameHoleRoadmaps",
                table: "gameHoleRoadmaps");

            migrationBuilder.RenameTable(
                name: "gameMilestoneTs",
                newName: "GameMilestoneTs");

            migrationBuilder.RenameTable(
                name: "gameMilestones",
                newName: "GameMilestones");

            migrationBuilder.RenameTable(
                name: "gameMilestoneMatchTs",
                newName: "GameMilestoneMatchTs");

            migrationBuilder.RenameTable(
                name: "gameMilestoneMatches",
                newName: "GameMilestoneMatches");

            migrationBuilder.RenameTable(
                name: "gameMatchStrokes",
                newName: "GameMatchStrokes");

            migrationBuilder.RenameTable(
                name: "gameMatchScoreCards",
                newName: "GameMatchScoreCards");

            migrationBuilder.RenameTable(
                name: "gameHoleRoadmaps",
                newName: "GameHoleRoadmaps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneTs",
                table: "GameMilestoneTs",
                column: "game_milestoneT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestones",
                table: "GameMilestones",
                column: "game_milestone_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatchTs",
                table: "GameMilestoneMatchTs",
                column: "game_milestone_matchT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatches",
                table: "GameMilestoneMatches",
                column: "game_milestone_match_id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "gameMilestoneTs");

            migrationBuilder.RenameTable(
                name: "GameMilestones",
                newName: "gameMilestones");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatchTs",
                newName: "gameMilestoneMatchTs");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatches",
                newName: "gameMilestoneMatches");

            migrationBuilder.RenameTable(
                name: "GameMatchStrokes",
                newName: "gameMatchStrokes");

            migrationBuilder.RenameTable(
                name: "GameMatchScoreCards",
                newName: "gameMatchScoreCards");

            migrationBuilder.RenameTable(
                name: "GameHoleRoadmaps",
                newName: "gameHoleRoadmaps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameMilestoneTs",
                table: "gameMilestoneTs",
                column: "game_milestoneT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameMilestones",
                table: "gameMilestones",
                column: "game_milestone_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameMilestoneMatchTs",
                table: "gameMilestoneMatchTs",
                column: "game_milestone_matchT_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameMilestoneMatches",
                table: "gameMilestoneMatches",
                column: "game_milestone_match_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameMatchStrokes",
                table: "gameMatchStrokes",
                column: "game_match_stroke_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameMatchScoreCards",
                table: "gameMatchScoreCards",
                column: "game_match_score_card_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gameHoleRoadmaps",
                table: "gameHoleRoadmaps",
                column: "game_hole_roadmap_id");
        }
    }
}
