using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace photodotnet.Migrations
{
    public partial class removeRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Photo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Photo",
                nullable: false,
                defaultValue: 0);
        }
    }
}
