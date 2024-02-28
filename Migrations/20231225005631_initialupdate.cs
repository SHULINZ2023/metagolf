using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class initialupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GolfCourseInitalLocationLat",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "GolfCourseInitalLocationLong",
                table: "GolfCoursse");

            migrationBuilder.RenameColumn(
                name: "GolfCourseName",
                table: "GolfCoursse",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "GolfCourseSystemId",
                table: "GolfCoursse",
                newName: "golf_course_id");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "area_id",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "contact_person",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "create_time",
                table: "GolfCoursse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "golf_course_code",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "golf_course_name",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "last_upt_time",
                table: "GolfCoursse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "par_9",
                table: "GolfCoursse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "province",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "GolfCoursse",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "area_id",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "city",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "comments",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "contact_person",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "create_time",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "golf_course_code",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "golf_course_name",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "last_upt_time",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "location",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "par_9",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "province",
                table: "GolfCoursse");

            migrationBuilder.DropColumn(
                name: "status",
                table: "GolfCoursse");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "GolfCoursse",
                newName: "GolfCourseName");

            migrationBuilder.RenameColumn(
                name: "golf_course_id",
                table: "GolfCoursse",
                newName: "GolfCourseSystemId");

            migrationBuilder.AddColumn<double>(
                name: "GolfCourseInitalLocationLat",
                table: "GolfCoursse",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "GolfCourseInitalLocationLong",
                table: "GolfCoursse",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
