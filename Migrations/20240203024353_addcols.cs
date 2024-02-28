using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class addcols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "course_hole_id",
                table: "GameMatchScoreCard",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "hole_roadmap_id",
                table: "GameMatchScoreCard",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "course_hole_id",
                table: "GameMatchScoreCard");

            migrationBuilder.DropColumn(
                name: "hole_roadmap_id",
                table: "GameMatchScoreCard");
        }
    }
}
