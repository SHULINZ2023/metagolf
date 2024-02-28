using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class changecols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hole_roadmap_id",
                table: "GameMatchScoreCard",
                newName: "roadmap_sequence");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "roadmap_sequence",
                table: "GameMatchScoreCard",
                newName: "hole_roadmap_id");
        }
    }
}
