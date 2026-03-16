using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraProgamada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CESTA_RECOMENDACAO",
                columns: table => new
                {
                    ID_CESTA_RECOMENDACAO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ATIVO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DATA_DESATIVACAO = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CESTA_RECOMENDACAO", x => x.ID_CESTA_RECOMENDACAO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CLIENTES",
                columns: table => new
                {
                    ID_CLIENTE = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "VARCHAR(11)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALOR_MENSAL = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    ATIVO = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    DATA_ADESAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTES", x => x.ID_CLIENTE);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CONTAS_GRAFICAS",
                columns: table => new
                {
                    ID_CONTA_GRAFICA = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CLIENTE_ID = table.Column<long>(type: "bigint", nullable: false),
                    NUMERO_CONTA = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TIPO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTAS_GRAFICAS", x => x.ID_CONTA_GRAFICA);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CONTAS_MASTER",
                columns: table => new
                {
                    ID_CONTA_MASTER = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(500)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRECO = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTAS_MASTER", x => x.ID_CONTA_MASTER);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_COTACOES",
                columns: table => new
                {
                    ID_COTACAO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DATA_PREGAO = table.Column<DateTime>(type: "DATE", nullable: false),
                    TICKER = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRECO_ABERTURA = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    PRECO_FECHAMENTO = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    PRECO_MAXIMO = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    PRECO_MINIMO = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COTACOES", x => x.ID_COTACAO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CUSTODIAS",
                columns: table => new
                {
                    ID_CUSTODIA = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CONTA_GRAFICA_ID = table.Column<long>(type: "bigint", nullable: false),
                    TICKER = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    PRECO_MEDIO = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    DATA_ULTIMA_ATUALIZACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CUSTODIAS", x => x.ID_CUSTODIA);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_DISTRIBUICOES",
                columns: table => new
                {
                    ID_DISTRIBUICAO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ORDEM_COMPRA_ID = table.Column<long>(type: "bigint", nullable: false),
                    CUSTODIA_FILHOTE_ID = table.Column<long>(type: "bigint", nullable: false),
                    TICKER = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    PRECO_UNITARIO = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    DATA_DISTRIBUICAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DISTRIBUICOES", x => x.ID_DISTRIBUICAO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_EVENTOS_IR",
                columns: table => new
                {
                    ID_EVENTO_IR = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CLIENTE_ID = table.Column<long>(type: "bigint", nullable: false),
                    TIPO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALOR_BASE = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    VALOR_IR = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    PUBLICADO_KAFKA = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DATA_EVENTO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EVENTOS_IR", x => x.ID_EVENTO_IR);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_ITENS_CESTA",
                columns: table => new
                {
                    ID_ITEM_CESTA = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CESTA_ID = table.Column<long>(type: "bigint", nullable: false),
                    TICKER = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PERCENTUAL = table.Column<decimal>(type: "DECIMAL(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ITENS_CESTA", x => x.ID_ITEM_CESTA);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_ORDENS_COMPRA",
                columns: table => new
                {
                    ID_ORDEM_COMPRA = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CONTA_MASTER_ID = table.Column<long>(type: "bigint", nullable: false),
                    TICKER = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    PRECO_UNITARIO = table.Column<decimal>(type: "DECIMAL(18,4)", nullable: false),
                    TIPO_MERCADO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_EXECUCAO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ORDENS_COMPRA", x => x.ID_ORDEM_COMPRA);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_REBALANCEAMENTOS",
                columns: table => new
                {
                    ID_REBALANCEAMENTO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CLIENTE_ID = table.Column<long>(type: "bigint", nullable: false),
                    TIPO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TICKER_VENDIDO = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TICKER_COMPRADO = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    VALOR_VENDA = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    DATA_REBALANCEAMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_REBALANCEAMENTOS", x => x.ID_REBALANCEAMENTO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTES_CPF",
                table: "TB_CLIENTES",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_GRAFICAS_NUMERO_CONTA",
                table: "TB_CONTAS_GRAFICAS",
                column: "NUMERO_CONTA",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CESTA_RECOMENDACAO");

            migrationBuilder.DropTable(
                name: "TB_CLIENTES");

            migrationBuilder.DropTable(
                name: "TB_CONTAS_GRAFICAS");

            migrationBuilder.DropTable(
                name: "TB_CONTAS_MASTER");

            migrationBuilder.DropTable(
                name: "TB_COTACOES");

            migrationBuilder.DropTable(
                name: "TB_CUSTODIAS");

            migrationBuilder.DropTable(
                name: "TB_DISTRIBUICOES");

            migrationBuilder.DropTable(
                name: "TB_EVENTOS_IR");

            migrationBuilder.DropTable(
                name: "TB_ITENS_CESTA");

            migrationBuilder.DropTable(
                name: "TB_ORDENS_COMPRA");

            migrationBuilder.DropTable(
                name: "TB_REBALANCEAMENTOS");
        }
    }
}
