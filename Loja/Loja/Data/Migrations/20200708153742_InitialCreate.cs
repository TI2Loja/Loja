using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Product",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "foto",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fotografia",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prod_id = table.Column<int>(nullable: false),
                    order_id = table.Column<int>(nullable: false),
                    quant = table.Column<int>(nullable: false),
                    total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "description", "foto", "item", "price", "stock" },
                values: new object[,]
                {
                    { 1, "Tem Noise Canceling", null, "Fones", 15.0, 20 },
                    { 6, "Bass", null, "Fones", 16.0, 43 },
                    { 9, "JGL", null, "Fones", 14.550000000000001, 6 },
                    { 8, "Razer", null, "Fones", 16.77, 8 },
                    { 5, "Amarelos", null, "Fones", 20.0, 34 },
                    { 7, "Cor de rosa", null, "Fones", 13.99, 20 },
                    { 2, "Pretos", null, "Fones", 50.0, 15 },
                    { 3, "Pequenos", null, "Fones", 40.0, 25 },
                    { 10, "Autonomia até 30 horas", null, "Fones", 20.0, 35 },
                    { 4, "Grandes", null, "Fones", 10.0, 28 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Inc_date", "address", "email", "nome", "role", "username" },
                values: new object[,]
                {
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA SÃO LUIZ", "boggybryna@gmail.com", "Tânia Gomes", "user", "boggybryna" },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA DOIS", "aluno20179@ipt.pt", "Pedro Vinha", "admin", "Setraick" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA TRÊS", "aluno21369@ipt.pt", "Francisco Pereira", "admin", "Dead Pooh" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA UM", "hiqybunnoffu-2698@gmail.com", "Cristina Sousa", "user", "CPipas" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA B", "garguero@gmail.com", "Sónia Rosa", "user", "mrbuffed" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "R Parque Gondarim 24", "badrihanna@gmail.com", "António Santos", "user", "badrihanna" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA QUATRO", "shotscott@gmail.com", "Gustavo Alves", "user", "shotscott" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA PRINCIPAL", "sparkmarc@gmail.com", "Rosa Vieira", "user", "sparkmarc" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA A", "cleverbryna@gmail.com", "Daniel Dias", "user", "cleverbryna" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RUA PIAUI", "elflikebryna@gmail.com", "Andreia Correia", "user", "elflikebryna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "foto",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Fotografia",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
