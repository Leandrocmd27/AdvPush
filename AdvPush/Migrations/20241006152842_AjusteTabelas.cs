using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvPush.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Cliente_ClienteId",
                table: "Processo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Processo",
                table: "Processo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Processo",
                newName: "Processos");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Processo_ClienteId",
                table: "Processos",
                newName: "IX_Processos_ClienteId");

            migrationBuilder.UpdateData(
                table: "Processos",
                keyColumn: "TipoAcao",
                keyValue: null,
                column: "TipoAcao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TipoAcao",
                table: "Processos",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Processos",
                keyColumn: "NumeroProcesso",
                keyValue: null,
                column: "NumeroProcesso",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroProcesso",
                table: "Processos",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Processos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ImagemUrl",
                keyValue: null,
                column: "ImagemUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Clientes",
                type: "varchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processos",
                table: "Processos",
                column: "ProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processos_Clientes_ClienteId",
                table: "Processos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Clientes_ClienteId",
                table: "Processos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Processos",
                table: "Processos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Processos");

            migrationBuilder.RenameTable(
                name: "Processos",
                newName: "Processo");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Processos_ClienteId",
                table: "Processo",
                newName: "IX_Processo_ClienteId");

            migrationBuilder.AlterColumn<string>(
                name: "TipoAcao",
                table: "Processo",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroProcesso",
                table: "Processo",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Cliente",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(350)",
                oldMaxLength: 350)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processo",
                table: "Processo",
                column: "ProcessoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Cliente_ClienteId",
                table: "Processo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
