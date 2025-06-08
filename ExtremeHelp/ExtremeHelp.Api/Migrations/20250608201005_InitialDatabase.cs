using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExtremeHelp.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_EH_ALERTA",
                columns: table => new
                {
                    CD_ALERTA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DS_TITULO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DS_MENSAGEM = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DT_PUBLICACAO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EH_ALERTA", x => x.CD_ALERTA);
                });

            migrationBuilder.CreateTable(
                name: "T_EH_DICA_CATEGORIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EH_DICA_CATEGORIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_EH_DICA_PREPARACAO",
                columns: table => new
                {
                    CD_DICA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DS_TITULO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DS_CONTEUDO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DT_ULTIMA_ATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DicaCategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EH_DICA_PREPARACAO", x => x.CD_DICA);
                    table.ForeignKey(
                        name: "FK_T_EH_DICA_PREPARACAO_T_EH_DICA_CATEGORIA_DicaCategoriaId",
                        column: x => x.DicaCategoriaId,
                        principalTable: "T_EH_DICA_CATEGORIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_EH_DICA_PREPARACAO_DicaCategoriaId",
                table: "T_EH_DICA_PREPARACAO",
                column: "DicaCategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_EH_ALERTA");

            migrationBuilder.DropTable(
                name: "T_EH_DICA_PREPARACAO");

            migrationBuilder.DropTable(
                name: "T_EH_DICA_CATEGORIA");
        }
    }
}
