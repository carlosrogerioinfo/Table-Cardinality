using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.EFCore.Test.Migrations
{
    public partial class relationshipv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "efcore_autor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_autor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "efcore_curso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "efcore_livro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    AnoLancamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_livro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "efcore_pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    TipoPessoa = table.Column<char>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "efcore_aluno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_efcore_aluno_efcore_curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "efcore_curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "efcore_livro_autor",
                columns: table => new
                {
                    LivroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_livro_autor", x => new { x.AutorId, x.LivroId });
                    table.ForeignKey(
                        name: "FK_efcore_livro_autor_efcore_autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "efcore_autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_efcore_livro_autor_efcore_livro_LivroId",
                        column: x => x.LivroId,
                        principalTable: "efcore_livro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "efcore_pessoa_endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_efcore_pessoa_endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_efcore_pessoa_endereco_efcore_pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "efcore_pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_efcore_aluno_CursoId",
                table: "efcore_aluno",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_efcore_livro_autor_LivroId",
                table: "efcore_livro_autor",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_efcore_pessoa_endereco_PessoaId",
                table: "efcore_pessoa_endereco",
                column: "PessoaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "efcore_aluno");

            migrationBuilder.DropTable(
                name: "efcore_livro_autor");

            migrationBuilder.DropTable(
                name: "efcore_pessoa_endereco");

            migrationBuilder.DropTable(
                name: "efcore_curso");

            migrationBuilder.DropTable(
                name: "efcore_autor");

            migrationBuilder.DropTable(
                name: "efcore_livro");

            migrationBuilder.DropTable(
                name: "efcore_pessoa");
        }
    }
}
