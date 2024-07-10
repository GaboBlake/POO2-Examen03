using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POO_Examen3.Migrations
{
    /// <inheritdoc />
    public partial class CrearRelacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Toys",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "KindId",
                table: "Toys",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toys_CategoryId",
                table: "Toys",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Toys_KindId",
                table: "Toys",
                column: "KindId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toys_CategoryToys_CategoryId",
                table: "Toys",
                column: "CategoryId",
                principalTable: "CategoryToys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Toys_KindToys_KindId",
                table: "Toys",
                column: "KindId",
                principalTable: "KindToys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toys_CategoryToys_CategoryId",
                table: "Toys");

            migrationBuilder.DropForeignKey(
                name: "FK_Toys_KindToys_KindId",
                table: "Toys");

            migrationBuilder.DropIndex(
                name: "IX_Toys_CategoryId",
                table: "Toys");

            migrationBuilder.DropIndex(
                name: "IX_Toys_KindId",
                table: "Toys");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Toys");

            migrationBuilder.DropColumn(
                name: "KindId",
                table: "Toys");
        }
    }
}
