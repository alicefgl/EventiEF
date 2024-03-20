using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FogliettaA_5I_EventiEF.Migrations
{
    /// <inheritdoc />
    public partial class Prova2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "Membri",
                columns: table => new
                {
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cognome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membri", x => x.Nickname);
                });

            migrationBuilder.CreateTable(
                name: "TerritoriP",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerritoriP", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    IdPost = table.Column<string>(type: "TEXT", nullable: false),
                    Commento = table.Column<string>(type: "TEXT", nullable: false),
                    Voto = table.Column<float>(type: "REAL", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    MembroNickname = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.IdPost);
                    table.ForeignKey(
                        name: "FK_Posts_Membri_MembroNickname",
                        column: x => x.MembroNickname,
                        principalTable: "Membri",
                        principalColumn: "Nickname");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    CodEvento = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    titolo = table.Column<string>(type: "TEXT", nullable: false),
                    Artisti = table.Column<string>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    MembroNickname = table.Column<string>(type: "TEXT", nullable: false),
                    NomeProvincia = table.Column<string>(type: "TEXT", nullable: false),
                    TerritorioPNome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.CodEvento);
                    table.ForeignKey(
                        name: "FK_Events_Membri_MembroNickname",
                        column: x => x.MembroNickname,
                        principalTable: "Membri",
                        principalColumn: "Nickname",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_TerritoriP_TerritorioPNome",
                        column: x => x.TerritorioPNome,
                        principalTable: "TerritoriP",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appertenenti",
                columns: table => new
                {
                    IdAppartenenza = table.Column<string>(type: "TEXT", nullable: false),
                    CodEvento = table.Column<string>(type: "TEXT", nullable: true),
                    EventoCodEvento = table.Column<string>(type: "TEXT", nullable: true),
                    Categorie = table.Column<string>(type: "TEXT", nullable: true),
                    CategoriaNome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appertenenti", x => x.IdAppartenenza);
                    table.ForeignKey(
                        name: "FK_Appertenenti_Categorie_CategoriaNome",
                        column: x => x.CategoriaNome,
                        principalTable: "Categorie",
                        principalColumn: "Nome");
                    table.ForeignKey(
                        name: "FK_Appertenenti_Events_EventoCodEvento",
                        column: x => x.EventoCodEvento,
                        principalTable: "Events",
                        principalColumn: "CodEvento");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appertenenti_CategoriaNome",
                table: "Appertenenti",
                column: "CategoriaNome");

            migrationBuilder.CreateIndex(
                name: "IX_Appertenenti_EventoCodEvento",
                table: "Appertenenti",
                column: "EventoCodEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Events_MembroNickname",
                table: "Events",
                column: "MembroNickname");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TerritorioPNome",
                table: "Events",
                column: "TerritorioPNome");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_MembroNickname",
                table: "Posts",
                column: "MembroNickname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appertenenti");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Membri");

            migrationBuilder.DropTable(
                name: "TerritoriP");
        }
    }
}
