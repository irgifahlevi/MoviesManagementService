using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreatingDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Biographies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biographies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Biographies_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movies_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresID = table.Column<int>(type: "int", nullable: false),
                    MoviesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresID, x.MoviesID });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresID",
                        column: x => x.GenresID,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesID",
                        column: x => x.MoviesID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "FirstName", "LastName", "RowStatus", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9397), "SYSTEM", "Johan", "Malik", 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9413) },
                    { 2, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9417), "SYSTEM", "Hannah", "Lakley", 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9418) }
                });

            migrationBuilder.InsertData(
                table: "Biographies",
                columns: new[] { "ID", "ActorID", "Age", "CreatedAt", "CreatedBy", "Description", "Gender", "RowStatus", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 34, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9735), "SYSTEM", "", "Male", 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9739) },
                    { 2, 2, 28, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9743), "SYSTEM", "", "Female", 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9744) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "ActorID", "CreatedAt", "CreatedBy", "Description", "Duration", "MovieName", "Rating", "RowStatus", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9786), "SYSTEM", "The legend movies", "2 Hours", "Avatar", 4.9000000000000004, 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9788) },
                    { 2, 1, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9794), "SYSTEM", "In The End", "1 Hours", "Transformers 3", 4.5, 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9795) },
                    { 3, 2, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9797), "SYSTEM", "Zombie world war", "1.5 Hours", "Umbrella", 4.2999999999999998, 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9798) },
                    { 5, 2, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9801), "SYSTEM", "The collection funny movies", "2 Hours", "No Party No Hapy", 4.9000000000000004, 0, new DateTime(2024, 1, 7, 16, 39, 53, 860, DateTimeKind.Local).AddTicks(9802) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biographies_ActorID",
                table: "Biographies",
                column: "ActorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesID",
                table: "GenreMovie",
                column: "MoviesID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorID",
                table: "Movies",
                column: "ActorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biographies");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Actors");
        }
    }
}
