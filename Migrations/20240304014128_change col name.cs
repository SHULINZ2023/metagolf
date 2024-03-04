using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class changecolname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "golf_id",
                table: "JoinOpenTournaments",
                newName: "golfer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "golfer_id",
                table: "JoinOpenTournaments",
                newName: "golf_id");
        }
    }
}
