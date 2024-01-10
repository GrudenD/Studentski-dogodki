using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentskiDogodki.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dogodki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Lokacija = table.Column<string>(type: "TEXT", nullable: false),
                    Nastopajoci = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogodki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Popusti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Koda = table.Column<string>(type: "TEXT", nullable: false),
                    Procent = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popusti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uporabniki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Priimek = table.Column<string>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: false),
                    DatumRojstva = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Geslo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uporabniki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fotografije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PotDoFotografije = table.Column<string>(type: "TEXT", nullable: false),
                    DogodekId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotografije_Dogodki_DogodekId",
                        column: x => x.DogodekId,
                        principalTable: "Dogodki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StKart = table.Column<int>(type: "INTEGER", nullable: false),
                    DogodekId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cena = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Karte_Dogodki_DogodekId",
                        column: x => x.DogodekId,
                        principalTable: "Dogodki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nakupi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DogodekId = table.Column<int>(type: "INTEGER", nullable: false),
                    stKart = table.Column<int>(type: "INTEGER", nullable: false),
                    KartaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PopustId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nakupi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nakupi_Dogodki_DogodekId",
                        column: x => x.DogodekId,
                        principalTable: "Dogodki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nakupi_Karte_KartaId",
                        column: x => x.KartaId,
                        principalTable: "Karte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nakupi_Popusti_PopustId",
                        column: x => x.PopustId,
                        principalTable: "Popusti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UporabnikId = table.Column<int>(type: "INTEGER", nullable: false),
                    DogodekId = table.Column<int>(type: "INTEGER", nullable: false),
                    KartaId = table.Column<int>(type: "INTEGER", nullable: false),
                    StKart = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Dogodki_DogodekId",
                        column: x => x.DogodekId,
                        principalTable: "Dogodki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Karte_KartaId",
                        column: x => x.KartaId,
                        principalTable: "Karte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Uporabniki_UporabnikId",
                        column: x => x.UporabnikId,
                        principalTable: "Uporabniki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotografije_DogodekId",
                table: "Fotografije",
                column: "DogodekId");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_DogodekId",
                table: "Karte",
                column: "DogodekId");

            migrationBuilder.CreateIndex(
                name: "IX_Nakupi_DogodekId",
                table: "Nakupi",
                column: "DogodekId");

            migrationBuilder.CreateIndex(
                name: "IX_Nakupi_KartaId",
                table: "Nakupi",
                column: "KartaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nakupi_PopustId",
                table: "Nakupi",
                column: "PopustId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_DogodekId",
                table: "Rezervacije",
                column: "DogodekId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KartaId",
                table: "Rezervacije",
                column: "KartaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_UporabnikId",
                table: "Rezervacije",
                column: "UporabnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotografije");

            migrationBuilder.DropTable(
                name: "Nakupi");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Popusti");

            migrationBuilder.DropTable(
                name: "Karte");

            migrationBuilder.DropTable(
                name: "Uporabniki");

            migrationBuilder.DropTable(
                name: "Dogodki");
        }
    }
}
