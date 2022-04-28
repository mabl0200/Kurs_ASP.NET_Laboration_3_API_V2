using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb3.API.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "varchar(200)", nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    HobbyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Links_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonHobbies",
                columns: table => new
                {
                    PersonHobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    HobbyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonHobbies", x => x.PersonHobbyId);
                    table.ForeignKey(
                        name: "FK_PersonHobbies_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonHobbies_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Chess is a board game played between two players", "Chess" },
                    { 2, "Playing and listening to music", "Music" },
                    { 3, "Team sport where you score a goal by kicking a ball", "Football" },
                    { 4, "Cross-country skiing is a form of skiing where skiers rely on their own locomotion to move across snow-covered terrain, rather than using ski lifts or other forms of assistance", "Cross-country skiing" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Tobias", "Karlsson", "0701234569" },
                    { 2, "Lisa", "Nilsson", "0707412589" },
                    { 3, "Therese", "Skog", "0708523698" },
                    { 4, "Jesper", "Svensk", "0701472536" },
                    { 5, "Ture", "Sventon", "0703698521" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "HobbyId", "PersonId", "URL" },
                values: new object[,]
                {
                    { 3, 3, 1, "laliga.com/en-GB" },
                    { 5, 4, 2, "lofsdalen.com/en/cross-country-skiing" },
                    { 2, 2, 3, "open.spotify.com/" },
                    { 1, 1, 4, "en.wikipedia.org/wiki/Chess" },
                    { 4, 4, 5, "fis-ski.com/en/cross-country" }
                });

            migrationBuilder.InsertData(
                table: "PersonHobbies",
                columns: new[] { "PersonHobbyId", "HobbyId", "PersonId" },
                values: new object[,]
                {
                    { 3, 3, 1 },
                    { 7, 2, 1 },
                    { 5, 4, 2 },
                    { 6, 3, 2 },
                    { 2, 2, 3 },
                    { 1, 1, 4 },
                    { 4, 4, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_HobbyId",
                table: "Links",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonId",
                table: "Links",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHobbies_HobbyId",
                table: "PersonHobbies",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHobbies_PersonId",
                table: "PersonHobbies",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "PersonHobbies");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
