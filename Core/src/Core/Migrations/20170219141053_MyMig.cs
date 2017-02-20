using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core.Migrations
{
    public partial class MyMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    BancoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agencia = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    NomeBanco = table.Column<string>(nullable: true),
                    NumeroConta = table.Column<string>(nullable: true),
                    TipoConta = table.Column<int>(nullable: true),
                    Titular = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.BancoId);
                });

            migrationBuilder.CreateTable(
                name: "Conhecimentos",
                columns: table => new
                {
                    ConhecimentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Android = table.Column<int>(nullable: false),
                    AngularJs = table.Column<int>(nullable: false),
                    AspMvc = table.Column<int>(nullable: false),
                    Bootstrap = table.Column<int>(nullable: false),
                    C = table.Column<int>(nullable: true),
                    CSS = table.Column<int>(nullable: true),
                    Cake = table.Column<int>(nullable: true),
                    Cpp = table.Column<int>(nullable: true),
                    CrudProjectLink = table.Column<string>(nullable: true),
                    Django = table.Column<int>(nullable: true),
                    HTML = table.Column<int>(nullable: true),
                    IOS = table.Column<int>(nullable: false),
                    Illustrator = table.Column<int>(nullable: true),
                    Ionic = table.Column<int>(nullable: false),
                    Java = table.Column<int>(nullable: true),
                    Jquery = table.Column<int>(nullable: false),
                    Majento = table.Column<int>(nullable: true),
                    MySql = table.Column<int>(nullable: true),
                    MySqlServer = table.Column<int>(nullable: true),
                    Others = table.Column<string>(nullable: true),
                    PHP = table.Column<int>(nullable: false),
                    Photoshop = table.Column<int>(nullable: true),
                    Phyton = table.Column<int>(nullable: true),
                    Ruby = table.Column<int>(nullable: true),
                    SEO = table.Column<int>(nullable: true),
                    Salesforce = table.Column<int>(nullable: true),
                    Wordpress = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conhecimentos", x => x.ConhecimentoId);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    CandidatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BancoId = table.Column<int>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    ConhecimentoId = table.Column<int>(nullable: true),
                    Disponibilidade = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    InformacaoBancaria = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Periodo = table.Column<int>(nullable: false),
                    Portifolio = table.Column<string>(nullable: true),
                    Salario = table.Column<float>(nullable: false),
                    Skype = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.CandidatoId);
                    table.ForeignKey(
                        name: "FK_Candidatos_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "BancoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatos_Conhecimentos_ConhecimentoId",
                        column: x => x.ConhecimentoId,
                        principalTable: "Conhecimentos",
                        principalColumn: "ConhecimentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_BancoId",
                table: "Candidatos",
                column: "BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_ConhecimentoId",
                table: "Candidatos",
                column: "ConhecimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "Bancos");

            migrationBuilder.DropTable(
                name: "Conhecimentos");
        }
    }
}
