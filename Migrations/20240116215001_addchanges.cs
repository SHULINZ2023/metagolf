using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class addchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "course_teename_id",
                table: "CourseTees");

            migrationBuilder.AddColumn<string>(
                name: "course_teename",
                table: "CourseTees",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "latitude",
                table: "CourseHoles",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "longitude",
                table: "CourseHoles",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "maxdistance",
                table: "CourseHoles",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "moe",
                table: "CourseHoles",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "par",
                table: "CourseHoles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "course_teename",
                table: "CourseTees");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "CourseHoles");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "CourseHoles");

            migrationBuilder.DropColumn(
                name: "maxdistance",
                table: "CourseHoles");

            migrationBuilder.DropColumn(
                name: "moe",
                table: "CourseHoles");

            migrationBuilder.DropColumn(
                name: "par",
                table: "CourseHoles");

            migrationBuilder.AddColumn<long>(
                name: "course_teename_id",
                table: "CourseTees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
