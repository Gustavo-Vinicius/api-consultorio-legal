﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio_Legal.DATA.Migrations
{
    /// <inheritdoc />
    public partial class AddTelefones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Clientes");

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => new { x.ClienteId, x.Numero });
                    table.ForeignKey(
                        name: "FK_Telefones_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
