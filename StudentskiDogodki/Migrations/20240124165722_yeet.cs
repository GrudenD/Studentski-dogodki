using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentskiDogodki.Migrations
{
    /// <inheritdoc />
    public partial class yeet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PotDoNaslovnce",
                table: "Dogodki",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PotDoNaslovnce",
                table: "Dogodki");
        }
    }
}
