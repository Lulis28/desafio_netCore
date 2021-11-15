using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_itau.Migrations
{
    public partial class TabelasDesafioItau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moeda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebHook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebHookParameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moeda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorTaxa = table.Column<double>(type: "float", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmento", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "AtualizadoEm", "CriadoEm", "Descricao", "WebHook", "WebHookParameter" },
                values: new object[,]
                {
                    { new Guid("bc410d91-ab65-4fe1-a9cf-eeb002d8dde4"), new DateTime(2021, 11, 15, 15, 7, 15, 748, DateTimeKind.Local).AddTicks(730), new DateTime(2021, 11, 15, 15, 7, 15, 748, DateTimeKind.Local).AddTicks(74), "Dólar Americano", "https://economia.awesomeapi.com.br/last/USD-BRL", "USDBRL" },
                    { new Guid("dd00f3d5-012f-4fa8-a2e6-9664a12a534e"), new DateTime(2021, 11, 15, 15, 7, 15, 748, DateTimeKind.Local).AddTicks(1598), new DateTime(2021, 11, 15, 15, 7, 15, 748, DateTimeKind.Local).AddTicks(1593), "Euro", "https://economia.awesomeapi.com.br/last/EUR-BRL", "EURBRL" }
                });

            migrationBuilder.InsertData(
                table: "Segmento",
                columns: new[] { "Id", "AtualizadoEm", "CriadoEm", "Descricao", "ValorTaxa" },
                values: new object[,]
                {
                    { new Guid("66146a1a-6e80-44ba-a8e9-873db86c1fd2"), new DateTime(2021, 11, 15, 15, 7, 15, 745, DateTimeKind.Local).AddTicks(8459), new DateTime(2021, 11, 15, 15, 7, 15, 744, DateTimeKind.Local).AddTicks(5210), "Varejo", 3.5 },
                    { new Guid("ef085db4-2425-4ab6-b9c2-447fcfac86ae"), new DateTime(2021, 11, 15, 15, 7, 15, 745, DateTimeKind.Local).AddTicks(9086), new DateTime(2021, 11, 15, 15, 7, 15, 745, DateTimeKind.Local).AddTicks(9080), "Personnalite", 1.5 },
                    { new Guid("b5f43905-c60d-4a53-a7c4-fdc28fd832e0"), new DateTime(2021, 11, 15, 15, 7, 15, 745, DateTimeKind.Local).AddTicks(9090), new DateTime(2021, 11, 15, 15, 7, 15, 745, DateTimeKind.Local).AddTicks(9089), "Private", 0.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moeda");

            migrationBuilder.DropTable(
                name: "Segmento");
        }
    }
}
