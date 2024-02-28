using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class altertablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneMatche",
                table: "GameMilestoneMatche");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatche",
                newName: "GameMilestoneMatch");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatch",
                table: "GameMilestoneMatch",
                column: "game_milestone_match_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameMilestoneMatch",
                table: "GameMilestoneMatch");

            migrationBuilder.RenameTable(
                name: "GameMilestoneMatch",
                newName: "GameMilestoneMatche");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameMilestoneMatche",
                table: "GameMilestoneMatche",
                column: "game_milestone_match_id");
        }
    }
}
