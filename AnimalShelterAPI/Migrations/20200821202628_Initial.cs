using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Coloring = table.Column<string>(nullable: true),
                    Age = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Personality = table.Column<int>(nullable: false),
                    About = table.Column<string>(nullable: true),
                    Adopted = table.Column<bool>(nullable: false),
                    AdoptionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Coloring = table.Column<string>(nullable: true),
                    Age = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Personality = table.Column<int>(nullable: false),
                    About = table.Column<string>(nullable: true),
                    Adopted = table.Column<bool>(nullable: false),
                    AdoptionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "About", "Adopted", "AdoptionDate", "Age", "Breed", "Coloring", "Name", "Personality", "Sex", "Weight" },
                values: new object[,]
                {
                    { 249017, "Love Cheek and Chin Scratches!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, "Domestic Medium Hair", "Black", "Domino", 3, 0, 11.800000000000001 },
                    { 249281, "Always PURRing and PURRfect!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.29999999999999999, "Domestic Short Hair", "Brown Tabby", "Doug", 4, 0, 5.2000000000000002 },
                    { 249318, "Anxious around new animals and people, but very sweet!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0, "Domestic Short Hair", "Blue Tabby", "Bunny", 5, 0, 7.4000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "About", "Adopted", "AdoptionDate", "Age", "Breed", "Coloring", "Name", "Personality", "Sex", "Weight" },
                values: new object[,]
                {
                    { 248680, "Playful biter, loves chassing rabbits!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, "Labrador", "Yellow", "Angus", 6, 0, 101.3 },
                    { 227248, "A true HomeBuddy! Knows many tricks and is a quick learner!", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.8999999999999999, "American Pit Bull - Australian Shepherd", "White Brown", "Penny", 1, 1, 52.100000000000001 },
                    { 249396, "Love to Learn and Love to Cuddle. Netflix and Chill?", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5, "Dachsund", "Red White", "Churro", 0, 0, 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
