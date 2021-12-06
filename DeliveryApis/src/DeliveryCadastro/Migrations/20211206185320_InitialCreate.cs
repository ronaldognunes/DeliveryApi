using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DeliveryCadastro.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "varchar(100)", nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(30)", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(15)", nullable: false),
                    SENHA = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO_USUARIO",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    RUA = table.Column<string>(type: "varchar(150)", nullable: true),
                    NUMERO = table.Column<int>(type: "int", nullable: true),
                    MUNICIPIO = table.Column<string>(type: "varchar(100)", nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(100)", nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(9)", nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO_USUARIO", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_ENDERECO_USUARIO_USUARIOS_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "USUARIOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENDERECO_USUARIO");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
