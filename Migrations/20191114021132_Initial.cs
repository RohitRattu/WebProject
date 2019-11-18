using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RecipeAssignment.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeName = table.Column<string>(nullable: false),
                    Directions = table.Column<string>(nullable: true),
                    Ingredients = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    RatingReview = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
