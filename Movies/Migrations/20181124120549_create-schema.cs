using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class createschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MoviesApp");

            migrationBuilder.CreateTable(
                name: "tblMovies",
                schema: "MoviesApp",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    DirectorName = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MovieId", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "tblCastMembers",
                schema: "MoviesApp",
                columns: table => new
                {
                    CastMemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActorName = table.Column<string>(nullable: true),
                    CharacterName = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CastMemberId", x => x.CastMemberId);
                    table.ForeignKey(
                        name: "FK_tblCastMembers_tblMovies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "MoviesApp",
                        principalTable: "tblMovies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCastMembers_MovieId",
                schema: "MoviesApp",
                table: "tblCastMembers",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCastMembers",
                schema: "MoviesApp");

            migrationBuilder.DropTable(
                name: "tblMovies",
                schema: "MoviesApp");
        }
    }
}
