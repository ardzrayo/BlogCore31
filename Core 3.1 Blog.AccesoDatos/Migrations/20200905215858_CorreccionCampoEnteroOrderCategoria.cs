﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_3._1_Blog.AccesoDatos.Migrations
{
    public partial class CorreccionCampoEnteroOrderCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Orden",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Orden",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
