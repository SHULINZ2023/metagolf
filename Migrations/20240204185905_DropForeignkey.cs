using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class DropForeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        



         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        

            migrationBuilder.CreateIndex(
                name: "IX_CourseHoles_golf_course_id",
                table: "CourseHoles",
                column: "golf_course_id");

        
        }
    }
}
